using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class PartTimeEmployee : Employee
    {
        public int hourlysalary { get; set; }

        public PartTimeEmployee(int id, string name, string dept, int hourlysal) : base(id, name, dept, hourlysal)
        {
            this.hourlysalary = hourlysal;            
        }
        public void GetBenifit()
        {
            throw new NotImplementedException();
        }

    }
}
