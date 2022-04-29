using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class FinanceTeam:IFinanceTeam
    {
        public FinanceTeam()
        {
            Console.WriteLine("Finance Team");
        }
        public void CalculateSalary()
        {
            Console.WriteLine("Calculate Salary");
        }
        public void SendSalary()
        {
            Console.WriteLine("Send Salary");
        }
        public void TakeRequestFromEmployee()
        {
            Console.WriteLine("Request from Employee on Salary");
        }
    }
}
