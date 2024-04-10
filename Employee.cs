using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    internal class Employee
    {
        private string name;
        private int salary;
        private int years;
        private bool isManager;
        public Employee(string name, int salary, bool isManager)
        {
            this.name = name;
            this.salary = salary;
            this.isManager = isManager;
        }
        //פעולה בונה מעתיקה
        public Employee (Employee other)
        {
            this.name = other.name;
            this.salary = other.salary;
            this.years = other.years;
            this.isManager = other.isManager;
        }
        public void SetYears(int years)
        {
            this.years = years;
        }
        public int GetSalary()
        {
            return this.salary;
        }
        public string GetName()
        {
            return name;
        }
       
        public void SetSalary(int salary)
        {
            this.salary= salary;

        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public bool IsHighSalary()
        {
            return this.salary > 20000;
        }
        public override string ToString()
        {
            return $"{name} is employed {years} years. Salary = {salary}. Manager? {isManager}";
        }
        public int Bonus()
        {
            int Bonus = 0;
            if (years >= 10)
            {
                Bonus = (years - 9) * 1000;
            }
            if (isManager)
            {
                Bonus += 500;
            }
            return Bonus;
        }
        public string HigherName(Employee e)
        {
            if (e.salary > this.salary)
            {
                return e.name;
            }
            else
            {
                return this.name;
            }
        }
    }
}
