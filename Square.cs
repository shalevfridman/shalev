using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    public class Square
    {
        private int side;
        public Square(int side)
        {
            this.side = side;
        }
        public void SetSide(int side)
        {
            if (side > 0)
            {
                this.side = side;
            }
            else { Console.WriteLine("Must be positive"); }

        }
        public int GetSide()
        {
            return this.side;
        } 
        public int Parimeter()
        {
            return side * 4;
        }
        public int Area()
        {
            return side * side;
        }

        public override string ToString()
        {
            return $"the side of the square is {this.side}";
        }

    }
}
