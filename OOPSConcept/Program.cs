using System;

namespace OOPSConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee(11, "Bala","IT");
            PartTimeEmployee emp1 = new PartTimeEmployee(29, "Kishore", "IT", 5600);
            FullTimeEmployee emp2 = new FullTimeEmployee(8729, "Bala", "IT", 560000);
            emp1.GetSalary();
            emp2.GetSalary();

            Console.WriteLine("Hello, World!");
        }
    }
}

