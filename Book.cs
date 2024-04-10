using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    public class Book
    {
        private string title;
        private string author;
        private int year;
        private string publisher;
        private double cost;

        public Book(string title, string author, int year, string publisher,double cost)
        {
            this.title = title;
            this.author = author;
            this.year= year;
            this.cost = cost;
            this.author = author;
        }
        public double GetCost()
        {
            return cost;
        }
        public string GetTitle()
        {
            return title;
        }   
        public void SetCost(double cost)
        {
            this.cost = cost;
        }

        public override string ToString()
        {
            return "Title: " + title + "\nAuthor: " + author + "\nYear: " + year + "\nPublisher: " + publisher + "\nCost: " + cost;

     
        }
     
    }
}
