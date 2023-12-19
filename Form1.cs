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

        private float histogramContrast = 0;
        private float noiseLevel = 0.0f;
        private float vignetteSize = 0.0f;
        private float laplacianFilterValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) // If user has selected an image and pressed OK
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName); // Assign image to the first PictureBox
                Bitmap bmp = (Bitmap)pictureBox1.Image.Clone(); // Get the Bitmap of that image
                imageClass.ReadImage(bmp); // Use created Bitmap to get the image information
                imageClass.histogram_original.DrawHistogram(chart1); // Draw a histogram
            }

            histogramContrast = (float)imageClass.GetHistogramContrast();
            Console.WriteLine(histogramContrast);
            noiseLevel = imageClass.CalculateNoiseLevel();
            Console.WriteLine(noiseLevel);
            vignetteSize = imageClass.GetVignetteSize();
            Console.WriteLine(vignetteSize);
            laplacianFilterValue = imageClass.GetLaplacianFilterValue();
            Console.WriteLine(laplacianFilterValue);
        }
    }
}
