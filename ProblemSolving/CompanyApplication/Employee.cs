using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApplication
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Wage { get; set; }
        public double LoggedHours { get; set; }

        public Employee()
        {
            
        }

        public Employee(string Fname , string Lname , double Wage , double LoggedHours)
        {
            this.FirstName = Fname;
            this.LastName = Lname;
            this.Wage = Wage;
            this.LoggedHours = LoggedHours;
        }

         public void CalculateNetSalary()
        {
            var NetSalary = Wage * LoggedHours - (Wage * LoggedHours * 0.03);
            Console.WriteLine($"The Net Salary of {FirstName} {LastName} is {NetSalary}");
        }

    }

}
