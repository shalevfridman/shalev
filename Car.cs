using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private int km;
        private int direction;
        private bool isOn;

        public Car()
        {

        }

        public Car(string make)
        {
            this.make = make;
            this.model = "";
            this.year = 2024;
            this.km = 0;
            this.direction = 0;
            this.isOn = false;
        }
        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.km = 0;
            this.direction = 0;
            this.isOn = false;
        }

        public Car(Car other)
        {
            this.year = other.year;
            this.make = other.make;
            this.km = 0;
            this.model = other.model;
            this.direction = other.direction;
            this.isOn = other.isOn;
        }

        public void TurnOn()
        {
            if (isOn)
            {
                Console.WriteLine("error");
            }
            else
            {
                isOn = true;
            }
        }

        public void TurnOff()
        {
            if (!isOn)
            {
                Console.WriteLine("error");
            }
            else
            {
                isOn = false;
                direction = 0;
            }
        }

        public void SetDirection(int direction)
        {
            if (isOn)
            {
                this.direction = direction;

            }
            else
            {
                Console.WriteLine("error");
            }
        }

        public void Drive(int km)
        {
            if (isOn)
            {
                this.km += km;
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        public override string ToString()
        {
            return $"make:{make} is on: {isOn} km: {km}";
        }
    }
}
