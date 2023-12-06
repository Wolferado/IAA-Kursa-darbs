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
        public PixelRGB[,] img_original; // Double dimensional array for original Image.
        public PixelRGB[,] img_rgb; // Double dimensional array for Image RGB colors.

        public HistogramClass histogram_original; // Histogram for original image.
        public HistogramClass histogram_custom; // Histogram for custom image.

        // Method to read the image with Bitmap as a parameter.
        public void ReadImage(Bitmap bmp)
        {
            // Assigning to the local variables Bitmap's parameters of width and height.
            img_original = new PixelRGB[bmp.Width, bmp.Height];
            img_rgb = new PixelRGB[bmp.Width, bmp.Height];

            histogram_original = new HistogramClass();
            histogram_custom = new HistogramClass();

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
                    img_rgb[x, y] = new PixelRGB(row[pixelComponents * x + 2], row[pixelComponents * x + 1], row[pixelComponents * x]);
                }
            }
            bmp.UnlockBits(bmpData); // Freeing up the assigned memory

            histogram_original.ReadHistogramRGB(img_original);
        }

        // Method to get Bitmap of the image.
        public Bitmap DrawImage(PixelRGB[,] img)
        {
            IntPtr ptr = IntPtr.Zero; // Create a null pointer.

            var bmp = new Bitmap(img.GetLength(0), img.GetLength(1), PixelFormat.Format24bppRgb); // Create a Bitmap.

            var bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat); // Creating a variable and locking Bitmap into the memory.

            // Creating a byte array of Bitmap width that is multiplied by Pixel components.
            var row = new byte[bmp.Width * 3];

            // Loop to go through each pixel of the Bitmap.
            for (int y = 0; y < bmp.Height; y++) // For each row
            {
                for (int x = 0; x < bmp.Width; x++) // For each pixel in that row
                {
                    // Assign the information about the color to the each byte in row for RGB system.
                    row[3 * x + 2] = img[x, y].R;
                    row[3 * x + 1] = img[x, y].G;
                    row[3 * x] = img[x, y].B;
                }

                ptr = bmpData.Scan0 + y * bmpData.Stride; // Assigning a pixel data in the Bitmap of the row to the pointer.
                Marshal.Copy(row, 0, ptr, row.Length); // Copying pointer with the information, destination and length.
            }
            bmp.UnlockBits(bmpData); // Freeing up the assigned memory.

            return bmp; // Returning needed Bitmap of the image.
        }

        // Method to Invert image colors.
        public Bitmap InvertImage(PixelRGB[,] img)
        {
            Bitmap bmp = new Bitmap(img.GetLength(0), img.GetLength(1), PixelFormat.Format24bppRgb); // Creating a new Bitmap.

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat); // Creating a variable and locking Bitmap into the memory.

            IntPtr ptr = IntPtr.Zero; // Creating a null pointer.

            // Creating a byte array of Bitmap width that is multiplied by Pixel components.
            var row = new byte[bmp.Width * 3];

            // Loop to go through each pixel of the Bitmap.
            for (int y = 0; y < bmp.Height; y++) // For each row
            {
                for (int x = 0; x < bmp.Width; x++) // For each pixel in the row
                {
                    // Invert the color of the pixel and assign that to the byte array.
                    row[3 * x + 2] = (byte)((255) - (int)img[x, y].R);
                    row[3 * x + 1] = (byte)((255) - (int)img[x, y].G);
                    row[3 * x] = (byte)((255) - (int)img[x, y].B);
                }

                ptr = bmpData.Scan0 + y * bmpData.Stride; // Assigning a pixel data in the Bitmap of the row to the pointer.
                Marshal.Copy(row, 0, ptr, row.Length); // Copying pointer with the information, destination and length.
            }
            bmp.UnlockBits(bmpData); // Freeing up the assigned memory.

            return bmp; // Return a needed Bitmap of the inverted image.
        }

        // Method to apply filter to the image.
        public void FilterImage(int[,] f)
        {
            int k = 0;

            for (int fi = 0; fi < 3; fi++)
            {
                for (int fj = 0; fj < 3; fj++)
                {
                    k += f[fi, fj];
                }
            }

            // Go through each pixel and apply filter
            for (int x = 1; x < img_original.GetLength(0) - 1; x++)
            {
                for (int y = 1; y < img_original.GetLength(1) - 1; y++)
                {
                    // RGB values
                    int r = 0;
                    int g = 0;
                    int b = 0;
                    int i = 0;

                    for (int fi = 0; fi < 3; fi++)
                    {
                        for (int fj = 0; fj < 3; fj++)
                        {
                            r += img_original[x + (fi - 1), y + (fj - 1)].R * f[fi, fj];
                            g += img_original[x + (fi - 1), y + (fj - 1)].G * f[fi, fj];
                            b += img_original[x + (fi - 1), y + (fj - 1)].B * f[fi, fj];
                            i += img_original[x + (fi - 1), y + (fj - 1)].I * f[fi, fj];
                        }
                    }

                    r = Math.Max(0, Math.Min(255, r /= k));
                    g = Math.Max(0, Math.Min(255, g /= k));
                    b = Math.Max(0, Math.Min(255, b /= k));
                    i = Math.Max(0, Math.Min(255, i /= k));

                    img_rgb[x, y].R = (byte)r;
                    img_rgb[x, y].G = (byte)g;
                    img_rgb[x, y].B = (byte)b;
                    img_rgb[x, y].I = (byte)i;
                }
            }
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
                    img_rgb[x, y].R = (byte)r_values[4];
                    img_rgb[x, y].G = (byte)g_values[4];
                    img_rgb[x, y].B = (byte)b_values[4];
                    img_rgb[x, y].I = (byte)i_values[4];
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

        // Method to apply 5x5 noise median filter to the image.
        public void NoiseMedianFilter5x5()
        {
            // Create arrays for color values.
            int[] r_values = new int[25];
            int[] g_values = new int[25];
            int[] b_values = new int[25];
            int[] i_values = new int[25];

            for (int x = 2; x < img_original.GetLength(0) - 2; x++) // For each pixel row except first and last two
            {
                for (int y = 2; y < img_original.GetLength(1) - 2; y++) // For each pixel column except first and last two
                {
                    // Get pixels colors in 5x5 pixel square
                    Get5x5Pixels(r_values, g_values, b_values, i_values, x, y);

                    // Sort color values in ascending order
                    Array.Sort(r_values);
                    Array.Sort(g_values);
                    Array.Sort(b_values);
                    Array.Sort(i_values);

                    // Apply the median value to the pixel
                    img_rgb[x, y].R = (byte)r_values[12];
                    img_rgb[x, y].G = (byte)g_values[12];
                    img_rgb[x, y].B = (byte)b_values[12];
                    img_rgb[x, y].I = (byte)i_values[12];
                }
            }
        }

        // Method to get pixels colors in 5x5 pixels square.
        public void Get5x5Pixels(int[] arrayR, int[] arrayG, int[] arrayB, int[] arrayI, int currentPixelX, int currentPixelY)
        {
            int counter = 0; // Variable to keep track of inserted values

            for (int x = -2; x < 3; x++) // For each nearby pixel row
            {
                for (int y = -2; y < 3; y++) // For each nearby pixel column
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
    }
}
