using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace IAA_Kursa_darbs
{
    public class HistogramClass
    {
        // Variables for RGB Histogram.
        public int[] hR;
        public int[] hG;
        public int[] hB;
        public int[] hI;

        // Boolean to allow image enhancements.
        public bool isEnhanced = false;

        // HistogramClass consturctor (all values are 0).
        public HistogramClass()
        {
            hR = new int[256];
            hG = new int[256];
            hB = new int[256];
            hI = new int[256];
        }

        // Clearing existing RGB Histogram data.
        public void ClearHistogramRGB()
        {
            for (int i = 0; i < 256; i++)
            {
                hR[i] = 0;
                hG[i] = 0;
                hB[i] = 0;
                hI[i] = 0;
            }
        }

        // Read RGB image to get data for the Histogram.
        public void ReadHistogramRGB(PixelRGB[,] img)
        {
            ClearHistogramRGB(); // Clear existing data to prevent overlapping.

            for (int x = 0; x < img.GetLength(0); x++) // For each row
            {
                for (int y = 0; y < img.GetLength(1); y++) // For each column
                {
                    // Get RGB Pixel data for Histogram bars.
                    hR[img[x, y].R]++;
                    hG[img[x, y].G]++;
                    hB[img[x, y].B]++;
                    hI[img[x, y].I]++;
                }
            }
        }

        // Method to select needed method for drawing the Histogram.
        public void DrawHistogram(Chart chart)
        {
            // Clear all existing chart data.
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.ChartAreas.Add("ChartArea");

            DrawHistogramRGB(chart);
        }

        // Method for drawing Histogram for the RGB image.
        public void DrawHistogramRGB(Chart chart)
        {
            // Create needed series
            chart.Series.Add("R");
            chart.Series["R"].Color = Color.Red;
            chart.Series.Add("G");
            chart.Series["G"].Color = Color.Green;
            chart.Series.Add("B");
            chart.Series["B"].Color = Color.Blue;
            chart.Series.Add("I");
            chart.Series["I"].Color = Color.Black;

            // Draw all needed bars for the chart
            for (int i = 0; i < 256; i++)
            {
                chart.Series["R"].Points.AddXY(i, hR[i]);
                chart.Series["G"].Points.AddXY(i, hG[i]);
                chart.Series["B"].Points.AddXY(i, hB[i]);
                chart.Series["I"].Points.AddXY(i, hI[i]);
            }
        }

        public void StretchHistogram(Chart chart, PixelRGB[,] img)
        {
            isEnhanced = true; // Disable new possible enhancements

            int desiredRange = 255; // Declare desired range of the Histogram
            int startRangeR = -1, startRangeG = -1, startRangeB = -1, startRangeI = -1; // Variables for each start of the Histograms
            int endRangeR = -1, endRangeG = -1, endRangeB = -1, endRangeI = -1; // Variables for each end of the Histograms

            // Get all needed starts of every Histogram in RGB
            for (int i = 0; i < 256; i++)
            {
                if (hR[i] != 0 && startRangeR == -1)
                    startRangeR = i;
                if (hG[i] != 0 && startRangeG == -1)
                    startRangeG = i;
                if (hB[i] != 0 && startRangeB == -1)
                    startRangeB = i;
                if (hI[i] != 0 && startRangeI == -1)
                    startRangeI = i;
            }

            // Get all needed ends of every Histogram in RGB
            for (int i = 255; i >= 0; i--)
            {
                if (hR[i] != 0 && endRangeR == -1)
                    endRangeR = i;
                if (hG[i] != 0 && endRangeG == -1)
                    endRangeG = i;
                if (hB[i] != 0 && endRangeB == -1)
                    endRangeB = i;
                if (hI[i] != 0 && endRangeI == -1)
                    endRangeI = i;
            }

            // Get all original ranges of every Histogram in RGB
            int originalRangeR = endRangeR - startRangeR;
            int originalRangeG = endRangeG - startRangeG;
            int originalRangeB = endRangeB - startRangeB;
            int originalRangeI = endRangeI - startRangeI;

            // Get all stretch coefficients of every Histogram in RGB
            int stretchCoefR = desiredRange / originalRangeR;
            int stretchCoefG = desiredRange / originalRangeG;
            int stretchCoefB = desiredRange / originalRangeB;
            int stretchCoefI = desiredRange / originalRangeI;

            // For each pixel in the Image
            for (int x = 0; x < img.GetLength(0); x++)
            {
                for (int y = 0; y < img.GetLength(1); y++)
                {
                    // Change each Pixel RGB color for the new one with new intensity. Formula is I(new) = k * (I(old) - D(begin)).
                    img[x, y].R = (byte)(stretchCoefR * (img[x, y].R - endRangeR));
                    img[x, y].G = (byte)(stretchCoefG * (img[x, y].G - endRangeG));
                    img[x, y].B = (byte)(stretchCoefB * (img[x, y].B - endRangeB));
                    img[x, y].I = (byte)(stretchCoefI * (img[x, y].I - endRangeI));
                }
            }

            // Clear existing Histogram data.
            ClearHistogramRGB();

            // For each pixel in the Image
            for (int x = 0; x < img.GetLength(0); x++)
            {
                for (int y = 0; y < img.GetLength(1); y++)
                {
                    // Get corresponding Histogram bars.
                    hR[img[x, y].R]++;
                    hG[img[x, y].G]++;
                    hB[img[x, y].B]++;
                    hI[img[x, y].I]++;
                }
            }

            // Clear the series and draw a new Histogram.
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.ChartAreas.Add("ChartArea");
            DrawHistogramRGB(chart);
        }
    }
}
