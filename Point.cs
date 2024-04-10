using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    public class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point other)
        {
            this.x = other.x;
            this.y = other.y;
        }
        public bool IsEqual(Point other) 
        {
            if(this.x == other.x && this.y == other.y) 
            {
                return true;
            }
            return false;
        }
        public double GetX() 
        {
            return x; 
        }
        public double GetY() 
        { 
            return y; 
        }

        public void SetY(double y)
        {
            this.y = y;
        }
        public void SetX(double x)
        {
            this.x = x;
        }

        public double Distance(Point other)
        {
            return Math.Sqrt(Math.Pow(this.x - other.x, 2) + Math.Pow(this.y - other.y, 2));
        }
        
        public Point MidPoint(Point other)
        {
            double newX = (this.x + other.x) / 2;
            double newY = (this.y + other.y) / 2;
            Point pointToReturn = new Point(newX, newY);
            return pointToReturn;
        }
       
        public override string ToString()
        {
            return $"X:{x}, Y:{y}";
        }
    }
}
