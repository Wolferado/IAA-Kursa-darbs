using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IAA_Kursa_darbs
{
    public class ImageClass
    {
        public PixelRGB[,] img_original; // Double dimensional array for original image.
        public PixelRGB[,] img_cleared; // Double dimensional array for clean image.

        private int[,] img_noiseDiff;
        private int[,] img_laplacian;

        public HistogramRGBClass histogram_original; // Histogram for original image.

        // Method to read the image with Bitmap as a parameter.
        public void ReadImage(Bitmap bmp)
        {
            // Assigning to the local variables Bitmap's parameters of width and height.
            img_original = new PixelRGB[bmp.Width, bmp.Height];
            img_cleared = new PixelRGB[bmp.Width, bmp.Height];

            img_noiseDiff = new int[bmp.Width, bmp.Height];
            img_laplacian = new int[bmp.Width, bmp.Height];

            histogram_original = new HistogramRGBClass();

            // Creating a variable and locking Bitmap into the memory.
            var bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, bmp.PixelFormat);

            // Creating a null pointer.
            IntPtr ptr = IntPtr.Zero;

            // Variable for pixel components (how much color values are there).
            int pixelComponents = 0;

            // If statement to choose pixel format based on its components amount. If other formats aren't supported, components will remain as 0.
            if (bmpData.PixelFormat == PixelFormat.Format24bppRgb)
                pixelComponents = 3;
            else if (bmpData.PixelFormat == PixelFormat.Format32bppRgb)
                pixelComponents = 4;

            // Creating a byte array of Bitmap width that is multiplied by Pixel components.
            var row = new byte[bmp.Width * pixelComponents];

            // Loop to go through each pixel of the Bitmap.
            for (int y = 0; y < bmp.Height; y++) // For each row
            {
                ptr = bmpData.Scan0 + y * bmpData.Stride; // Assigning a pixel data in the Bitmap of the row to the pointer. Scan0 - gets an address of the first pixel in the Bitmap. Stride - gets scan width of the Bitmap.
                Marshal.Copy(ptr, row, 0, row.Length); // Copying pointer into the memory with information (pointer), destination (row variable) and length (row variable length).

                for (int x = 0; x < bmp.Width; x++) // For each pixel in row.
                {
                    // Assign to the variables information about the image (with one pixel at the time).
                    img_original[x, y] = new PixelRGB(row[pixelComponents * x + 2], row[pixelComponents * x + 1], row[pixelComponents * x]);
                    img_cleared[x, y] = new PixelRGB(row[pixelComponents * x + 2], row[pixelComponents * x + 1], row[pixelComponents * x]);
                }
            }
            bmp.UnlockBits(bmpData); // Freeing up the assigned memory

            histogram_original.ReadHistogram(img_original); // Get Image color data into histogram.
        }

        // Method to apply 3x3 noise median filter to the image.
        public void NoiseMedianFilter3x3()
        {
            // Create arrays for color values.
            int[] r_values = new int[9];
            int[] g_values = new int[9];
            int[] b_values = new int[9];
            int[] i_values = new int[9];

            for (int x = 1; x < img_original.GetLength(0) - 1; x++) // For each pixel row except first and last
            {
                for (int y = 1; y < img_original.GetLength(1) - 1; y++) // For each pixel column except first and last
                {
                    // Get pixels colors in 3x3 pixel square
                    Get3x3Pixels(r_values, g_values, b_values, i_values, x, y);

                    // Sort color values in ascending order
                    Array.Sort(r_values);
                    Array.Sort(g_values);
                    Array.Sort(b_values);
                    Array.Sort(i_values);

                    // Apply the median value to the pixel
                    img_cleared[x, y].R = (byte)r_values[4];
                    img_cleared[x, y].G = (byte)g_values[4];
                    img_cleared[x, y].B = (byte)b_values[4];
                    img_cleared[x, y].I = (byte)i_values[4];
                }
            }
        }

        // Method to get pixels colors in 3x3 pixels square.
        public void Get3x3Pixels(int[] arrayR, int[] arrayG, int[] arrayB, int[] arrayI, int currentPixelX, int currentPixelY)
        {
            int counter = 0; // Variable to keep track of inserted values

            for (int x = -1; x < 2; x++) // For each nearby pixel row
            {
                for (int y = -1; y < 2; y++) // For each nearby pixel column
                {
                    // Get colors and increment the variable.
                    arrayR[counter] = img_original[currentPixelX + x, currentPixelY + y].R;
                    arrayG[counter] = img_original[currentPixelX + x, currentPixelY + y].G;
                    arrayB[counter] = img_original[currentPixelX + x, currentPixelY + y].B;
                    arrayI[counter] = img_original[currentPixelX + x, currentPixelY + y].I;
                    counter++;
                }
            }
        }

        public int GetHistogramContrast()
        {
            int[] points = histogram_original.GetHistogramStartEndPoints();

            return points[1] - points[0];

        }
      
        private float CalculateVariance(int[,] image)
        {
            float count = 0;
            float sum = 0;

            for (int x = 0; x < image.GetLength(0); x++)
            {
                for (int y = 0; y < image.GetLength(1); y++)
                {
                    count++;
                    sum += image[x, y];
                }
            }

            float median = sum / count;
            float variance = 0;

            for (int x = 0; x < image.GetLength(0); x++)
            {
                for (int y = 0; y < image.GetLength(1); y++)
                {
                    variance += (float)Math.Pow(Math.Abs((image[x, y] - median)), 2);
                }
            }

            return variance / count;
        }

        public float CalculateNoiseLevel()
        {
            NoiseMedianFilter3x3();

            for (int x = 0; x < img_noiseDiff.GetLength(0); x++)
            {
                for (int y = 0; y < img_noiseDiff.GetLength(1); y++)
                {
                    img_noiseDiff[x, y] = img_cleared[x, y].I - img_original[x, y].I;
                }
            }

            float mse = CalculateVariance(img_noiseDiff);

            return mse;
        }

       public int[] GetBresenhamIntensityValues(int x0, int y0, int x1, int y1)
        {
            int lengthOfRadius = (int)Math.Sqrt(Math.Pow(img_original.GetLength(0) / 2, 2) + Math.Pow(img_original.GetLength(0) / 2, 2));
            int[] result = new int[lengthOfRadius];
            int dx = Math.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
            int dy = Math.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2, e2;
            int count = 0;

            while (true)
            {
                result[count] = img_original[x0, y0].I;
                if (x0 == x1 && y0 == y1) break;
                e2 = err;
                if (e2 > -dx) { err -= dy; x0 += sx; }
                if (e2 < dy) { err += dx; y0 += sy; }
                count++;
            }

            return result;
        }

        public float GetVignetteSize()
        {
            int centerX = img_original.GetLength(0) / 2;
            int centerY = img_original.GetLength(1) / 2;

            int[] leftUpperToCenter = GetBresenhamIntensityValues(0, 0, centerX, centerY);
            int[] leftLowerToCenter = GetBresenhamIntensityValues(0, img_original.GetLength(1) - 1, centerX, centerY);
            int[] rightLowerToCenter = GetBresenhamIntensityValues(img_original.GetLength(0) - 1, img_original.GetLength(1) - 1, centerX, centerY);
            int[] rightUpperToCenter = GetBresenhamIntensityValues(img_original.GetLength(0) - 1, 0, centerX, centerY);

            if (IsVignettePresent(leftUpperToCenter)
                && IsVignettePresent(leftLowerToCenter)
                && IsVignettePresent(rightUpperToCenter)
                && IsVignettePresent(rightLowerToCenter))
                return CalculateVignetteSize(leftUpperToCenter, rightUpperToCenter);
            else
                return 0;
        }

        private bool IsVignettePresent(int[] array)
        {
            for (int i = 0; i < array.Length / 10; i++)
            {
                if (Math.Abs(array[i] - array[i + 1]) >= 10 || array[i] >= 128)
                {
                    return false;
                }
            }

            return true;
        }

        private float CalculateVignetteSize(int[] leftUpperArray, int[] rightUpperArray)
        {
            float result = 0.0f;

            for (int i = 0; i < leftUpperArray.Length - 1; i++)
            {
                if (Math.Abs(leftUpperArray[i] - rightUpperArray[i]) >= 15)
                {
                    result = i * 100 / leftUpperArray.Length;
                    break;
                }
            }

            return result;
        }

        // Method to get Laplacian Filter value.
        public float GetLaplacianFilterValue()
        {
            int[,] f = new int[3, 3] { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } }; // Laplacian filter matrix.
            int k = 0;

            for (int fi = 0; fi < 3; fi++)
                for (int fj = 0; fj < 3; fj++)
                    k += f[fi, fj];

            // Go through each pixel and get I value
            for (int x = 1; x < img_original.GetLength(0) - 1; x++)
            {
                for (int y = 1; y < img_original.GetLength(1) - 1; y++)
                {
                    int i = 0;

                    for (int fi = 0; fi < 3; fi++)
                    {
                        for (int fj = 0; fj < 3; fj++)
                        {
                            i += img_original[x + (fi - 1), y + (fj - 1)].I * f[fi, fj];
                        }
                    }


                    if (k != 0)
                        i = Math.Max(0, Math.Min(255, i /= k));
                    else
                        i = Math.Max(0, Math.Min(255, i));

                    img_laplacian[x, y] = i;
                }
            }

            return CalculateVariance(img_laplacian);
        }
    }
}
