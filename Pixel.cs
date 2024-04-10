using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Pixel
    {
        public int Red;
        public int Green;
        public int Blue;
            public Pixel(int red, int green, int blue)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }
        public int GetRed()
        {
            return Red;
        }

        public int GetGreen()
        {
            return Green;
        }

        public int GetBlue()
        {
            return Blue;
        }

        public void SetRed(int value)
        {
            if (value >= 0 && value <= 255)
            {
                Red = value;
            }
        }

        public void SetGreen(int value)
        {
            if (value >= 0 && value <= 255)
            {
                Green = value;
            }
        }

        public void SetBlue(int value)
        {
            if (value >= 0 && value <= 255)
            {
                Blue = value;
            }
        }


        public bool IsValidColor()
            {
                return (Red >= 0 && Red <= 255) &&
                       (Green >= 0 && Green <= 255) &&
                       (Blue >= 0 && Blue <= 255);
            }

            public override string ToString()
            {
                return $"#{Red:X2}{Green:X2}{Blue:X2}";
            }

        }

    }

