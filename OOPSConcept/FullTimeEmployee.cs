using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class FullTimeEmployee:Employee
    {
        public int monthlysalary { get; set; }

        public FullTimeEmployee(int id, string name, string dept, int monthlysal) : base (id, name, dept, monthlysal)
        {
            this.monthlysalary = monthlysal;

        }
        public void GetBenifit()
        {
            
        }
    }
}
