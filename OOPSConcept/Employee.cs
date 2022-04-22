using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class Employee
    {
        /*public Employee(int id, string name, string dept, int sal)
        {
            ID = id;
            Name = name;
            Department = dept;
            salary = sal;
        }*/

        //public ITTeam ITTeam { get; set; }
        //public IFinanceTeam FinanceTeam { get; set; }
        //public FinanceTeam obj;

        public Employee(int id, string name, string dept, int sal)
        {
            this.ID = id;
            this.Name = name;
            this.Department = dept; 
            this.salary = sal;
            //ITTeam = new ITTeam();
        }
        public int ID { get; set; }

        public string Name { get; set; }
        public string Department { get; set; }

        public int salary { get; set; }
   

        public void DoWork()
        {
            //ITTeam.SolveProblem();
        }

        public void GetSalary()
        {
            Console.WriteLine(this.ID+" "+this.Name+" "+this.Department);
            Console.WriteLine("Salary credited "+this.salary);
        }
    }
}
