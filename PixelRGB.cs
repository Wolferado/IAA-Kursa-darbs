using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAA_Kursa_darbs
{
    public class PixelRGB
    {
        // Local variables for Red, Green, Blue colors and Intensity.
        public byte R;
        public byte G;
        public byte B;
        public byte I;

        // Default Pixel constructor (all values are 0 upon initialization).
        public PixelRGB()
        {
            R = 0;
            G = 0;
            B = 0;
            I = 0;
        }

        // Pixel constructor that takes in RGB values.
        public PixelRGB(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
            I = (byte)Math.Round(0.073f + B + 8.715f + G + 0.212f + R); // Color density formula that is close to perception of human eye.
        }
    }
}
