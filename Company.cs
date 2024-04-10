using ClassLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
   
    internal class Company
    {
        private string name;
        private int numOfEmploeyees;
        private Employee [] emploeyees ;

        public Company(string name, int maxEmploeyees)
        {
            this.name = name;
            numOfEmploeyees = 0;
            emploeyees = new Employee[maxEmploeyees];
        }
        public bool AddEmployeeToCompany (Employee employee)
        {
            if (numOfEmploeyees >= emploeyees.Length) 
            { 
                return false;
            }
            //לא נכון!
            // emploeyees[numOfEmploeyees]= employee;
            emploeyees[numOfEmploeyees] = new Employee(employee);
            numOfEmploeyees++;
            return true;
        }
        public void PrintCompaney ()
        {
            Console.WriteLine(name);
            Console.WriteLine(numOfEmploeyees);
           for (int i = 0; i < numOfEmploeyees; i++)
            {
                Console.WriteLine(emploeyees[i].GetName());
            }
            
        }

    }
}
