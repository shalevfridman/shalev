using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    internal class Card
    {
        private int value;
        private char suit;
        
        public Card(int value, char suit)
        {
            if(value<0 || value > 13)
            {
                Console.WriteLine("error");
            }
            else
            {
                this.value = value;
                this.suit = suit;
            }
            
        }
        public Card(Card other)
        {
            this.value = other.value;
            this.suit = other.suit;
        }
        public int GetValue()
        {
            return value;

        }
        public char GetSuit()
        {
            return suit;
        }
        public void SetSuit(char suit)
        {
            this.suit = suit;
        }
        public void SetValue(int value)
        {
            if ( value>0 && value<14)
            {
                this.value = value;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        public override string ToString()
        {
            return $"value : {value} \n suit : {suit}";
        }

    }
}
