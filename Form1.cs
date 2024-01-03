using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IAA_Kursa_darbs
{
    public partial class Form1 : Form
    {
        public ImageClass imageClass = new ImageClass(); // Variable for the ImageClass.

        // Values for the metrics (set as 0).
        private float histogramContrast = 0;
        private float noiseLevel = 0.0f;
        private float vignetteSize = 0.0f;
        private float laplacianFilterValue = 0.0f;

        public Form1()
        {
            InitializeComponent();
            pictureBoxHintMsg.Parent = pictureBox1;
        }

        // Method for toolstrip "Open Image" element click event.
        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseImage();
        }

        // Method for picture box element click event.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                ChooseImage();
        }

        // Method that chooses a picture.
        private void ChooseImage()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) // If user has selected an image and pressed OK
            {
                if (pictureBoxHintMsg != null) // If hint message isn't deleted
                    pictureBox1.Controls.Remove(pictureBoxHintMsg); // Delete it

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName); // Assign image to the first PictureBox
                Bitmap bmp = (Bitmap)pictureBox1.Image.Clone(); // Get the Bitmap of that image
                imageClass.ReadImage(bmp); // Use created Bitmap to get the image information
                imageClass.histogram_original.DrawHistogram(chart1); // Draw a histogram

                histogramContrast = (float)imageClass.GetHistogramContrast();
                //Console.WriteLine(histogramContrast);
                noiseLevel = imageClass.CalculateNoiseLevel();
                //Console.WriteLine(noiseLevel);
                vignetteSize = imageClass.GetVignetteSize();
                //Console.WriteLine(vignetteSize);
                laplacianFilterValue = imageClass.GetLaplacianFilterValue();
                //Console.WriteLine(laplacianFilterValue);

                UpdateImageTrackBars();
                UpdateDetailedInfo();
            }
        }

        // Method to update trackbars for the metrics.
        private void UpdateImageTrackBars()
        {
            // Slider Min Position X: 417
            // Slider Max Position Y: 737
            // Slider Overall Length: 120

            // Contrast
            // Position Y: 58
            int contrastSliderXPos = 58;
            contrastSlider.Location = new Point((417 + (int)(histogramContrast * 1.2f)), contrastSliderXPos);

            // Focus
            // Position Y: 134
            int focusSliderXPos = 134;
            if (laplacianFilterValue < 100)
            {
                focusSlider.Location = new Point(417 + (int)(laplacianFilterValue / 4 * 3), focusSliderXPos);
            }
            else if (laplacianFilterValue > 200)
            {
                focusSlider.Location = new Point(737, focusSliderXPos);
            }
            else
            {
                focusSlider.Location = new Point(417 + (int)(laplacianFilterValue / 4 * 3), focusSliderXPos);
            }

            // Noise
            // Position Y: 211
            int noiseSliderXPos = 211;
            if (noiseLevel <= 30)
            {
                noiseSlider.Location = new Point(417 + (int)(noiseLevel / 4 * 3), noiseSliderXPos);
            }
            else if (noiseLevel > 30 && noiseLevel < 130)
            {
                noiseSlider.Location = new Point(417 + (int)(noiseLevel / 4 * 3), noiseSliderXPos);
            }
            else
            {
                if (noiseLevel > 200)
                    noiseSlider.Location = new Point(737, noiseSliderXPos);
                else
                    noiseSlider.Location = new Point(417 + (int)(noiseLevel / 4 * 3), noiseSliderXPos);
            }

            // Vignette
            // Position Y: 288
            int vignetteSliderXPos = 288;
            vignetteSlider.Location = new Point((417 + (int)(vignetteSize * 3)), vignetteSliderXPos);
        }

        // Method to update detailed info in the textbox.
        private void UpdateDetailedInfo()
        {
            detailedInfoTextBox.Text = String.Format("Detailed information: \r\n\r\nContrast: \t\t{0} %\r\nFocus: \t\t{1}\r\nNoise: \t\t{2}\r\nVignette: \t\t{3} %", (float)histogramContrast * 100 / 256, laplacianFilterValue, noiseLevel, vignetteSize);
        }
    }
}
