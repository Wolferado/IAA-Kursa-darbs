using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

                ClearTrackBarsLabels();
                UpdateImageTrackBars();
                UpdateDetailedInfo();
            }
        }

        // Method that removes every formatting of each metrics label.
        private void ClearTrackBarsLabels()
        {
            lowContrastLabel.Font = new Font(lowContrastLabel.Font, FontStyle.Regular);
            mediumContrastLabel.Font = new Font(mediumContrastLabel.Font, FontStyle.Regular);
            highContrastLabel.Font = new Font(highContrastLabel.Font, FontStyle.Regular);

            blurryFocusLabel.Font = new Font(blurryFocusLabel.Font, FontStyle.Regular);
            focusedFocusLabel.Font = new Font(focusedFocusLabel.Font, FontStyle.Regular);

            noiselessNoiseLabel.Font = new Font(noiselessNoiseLabel.Font, FontStyle.Regular);
            noisyNoiseLabel.Font = new Font(noisyNoiseLabel.Font, FontStyle.Regular);
            veryNoisyNoiseLabel.Font = new Font(veryNoisyNoiseLabel.Font, FontStyle.Regular);

            noneVignetteLabel.Font = new Font(noneVignetteLabel.Font, FontStyle.Regular);
            existsVignetteLabel.Font = new Font(existsVignetteLabel.Font, FontStyle.Regular);
        }

        // Method to update trackbars for the metrics.
        private void UpdateImageTrackBars()
        {
            // Contrast
            if (histogramContrast < 86)
                lowContrastLabel.Font = new Font(lowContrastLabel.Font, FontStyle.Bold);
            else if (histogramContrast >= 86 && histogramContrast < 172)
                mediumContrastLabel.Font = new Font(mediumContrastLabel.Font, FontStyle.Bold);
            else
                highContrastLabel.Font = new Font(highContrastLabel.Font, FontStyle.Bold);
            contrastTrackBar.Value = (int)histogramContrast * contrastTrackBar.Maximum / 256;


            // Focus
            if (laplacianFilterValue < 100)
            {
                focusTrackBar.Value = (int)laplacianFilterValue / 4;
                blurryFocusLabel.Font = new Font(blurryFocusLabel.Font, FontStyle.Bold);
            }
            else if (laplacianFilterValue > 200)
            {
                focusTrackBar.Value = focusTrackBar.Maximum;
                focusedFocusLabel.Font = new Font(blurryFocusLabel.Font, FontStyle.Bold);
            }
            else
            {
                focusTrackBar.Value = (int)laplacianFilterValue / 4;
                focusedFocusLabel.Font = new Font(blurryFocusLabel.Font, FontStyle.Bold);
            }

            // Noise
            if (noiseLevel <= 30)
            {
                noiseTrackBar.Value = (int)noiseLevel / 4;
                noiselessNoiseLabel.Font = new Font(noiselessNoiseLabel.Font, FontStyle.Bold);
            }
            else if (noiseLevel > 30 && noiseLevel < 130)
            {
                noiseTrackBar.Value = (int)noiseLevel / 4;
                noisyNoiseLabel.Font = new Font(noisyNoiseLabel.Font, FontStyle.Bold);
            }
            else
            {
                if (noiseLevel > 200)
                    noiseTrackBar.Value = noiseTrackBar.Maximum;
                else
                    noiseTrackBar.Value = (int)noiseLevel / 4;

                veryNoisyNoiseLabel.Font = new Font(veryNoisyNoiseLabel.Font, FontStyle.Bold);
            }

            // Vignette
            vignetteTrackBar.Value = (int)vignetteSize / 2;
            if (vignetteSize == 0)
                noneVignetteLabel.Font = new Font(noneVignetteLabel.Font, FontStyle.Bold);
            else
                existsVignetteLabel.Font = new Font(existsVignetteLabel.Font, FontStyle.Bold);
        }

        // Method to update detailed info in the textbox.
        private void UpdateDetailedInfo()
        {
            detailedInfoTextBox.Text = String.Format("Detailed information: \r\n\r\nContrast: \t\t{0} %\r\nFocus: \t\t{1}\r\nNoise: \t\t{2}\r\nVignette: \t\t{3} %", (float)histogramContrast * 100 / 256, laplacianFilterValue, noiseLevel, vignetteSize);
        }
    }
}
