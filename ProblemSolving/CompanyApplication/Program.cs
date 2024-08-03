namespace CompanyApplication
{
    class Program
    {
        static void Main(String[] args)
        {
            string Fname;
            string Lname;
            double wage;
            double LogHours;
            double TAX;

            bool isDone = true;

            while (isDone) 
            {
                //Input of First and Last Name and Tax
                Console.Write("First Name: ");
                Fname = Console.ReadLine();
                Console.Write("Last Name: ");
                Lname = Console.ReadLine();
                Console.Write("Enter TAX: ");
                TAX = Convert.ToDouble( Console.ReadLine());
                TAX = TAX/100;

                //Input Salary wage and logged hours
                Console.Write($"Enter {Fname} {Lname} Wage: ");
                wage = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Enter {Fname} {Lname} Logged Hours: ");
                LogHours = Convert.ToDouble(Console.ReadLine());

                Employee X = new Employee(Fname, Lname, wage, LogHours, TAX);
                X.CalculateNetSalary();
                Console.WriteLine("Press Enter for Continue and exit for Stop");

                var E = Console.ReadKey();
                if (E.Key != ConsoleKey.Enter)
                {
                    break;
                }
                Console.WriteLine("-------------------------------------------------");
            }


            ////Calculation of Net Salary with 3% Tax
            //var NetSalary = wage * LogHours - (wage * LogHours * TAX);
            //Console.WriteLine($"The net salary of {Fname} {Lname} is {NetSalary}");

            Console.ReadLine();

            
        }

        
    }
}