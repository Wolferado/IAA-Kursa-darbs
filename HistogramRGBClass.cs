using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace IAA_Kursa_darbs
{
    public class HistogramRGBClass
    {
        // Variables for RGB Histogram.
        public int[] hR;
        public int[] hG;
        public int[] hB;
        public int[] hI;

        private int maximumHeight = 0;

        // HistogramClass consturctor (all values are 0).
        public HistogramRGBClass()
        {
            hR = new int[256];
            hG = new int[256];
            hB = new int[256];
            hI = new int[256];
        }

        // Clearing existing Histogram data.
        public void ClearHistogram()
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
        public void ReadHistogram(PixelRGB[,] img)
        {
            ClearHistogram(); // Clear existing data to prevent overlapping.

            for (int x = 0; x < img.GetLength(0); x++) // For each row
            {
                for (int y = 0; y < img.GetLength(1); y++) // For each column
                {
                    // Get RGB Pixel data for Histogram bars.
                    hR[img[x, y].R]++;
                    hG[img[x, y].G]++;
                    hB[img[x, y].B]++;
                    hI[img[x, y].I]++;

                    if (hI[img[x, y].I] > maximumHeight)
                        maximumHeight = hI[img[x, y].I];
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

        // Method to get Histogram start and end points for I channel.
        public int[] GetHistogramStartEndPoints()
        {
            int startRange = -1;
            int endRange = -1;

            for (int i = 0; i < 256; i++)
            {
                if (hI[i] > maximumHeight / 50 && startRange == -1)
                    startRange = i;
            }

            for (int i = 255; i >= 0; i--)
            {
                if (hI[i] > maximumHeight / 50 && endRange == -1)
                    endRange = i;
            }

            return new int[2] { startRange, endRange };
        }
    }
}
