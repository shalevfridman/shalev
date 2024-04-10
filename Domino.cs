using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Domino
    {
            private int left;
            private int right;

            public Domino(double x, double y)
            {
                this.left = left;
                this.right = right;
            }

            public Domino(Domino other)
            {
                this.left = other.left;
                this.right = other.right;
            }
            public bool IsEqual(Domino other)
            {
                if (this.left == other.left && this.right == other.right)
                {
                    return true;
                }
                return false;
            }
            public double Getleft()
            {
                return left;
            }
            public double Getright()
            {
                return right;
            }

            public void Setright(double right)
            {
                this.right = (int)right;
            }
            public void Setleft(double left)
            {
                this.left = (int)left;
            }
            public override string ToString()
            {
                return $"left:{left}, right:{right}";
            }

        }
}
