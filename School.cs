using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    public class School
    {
        public School(int sid, string sname, string tname, string sub)
        {
            this.ID = sid;
            this.Name = sname;
            this.Teacher = tname;
            this.Subject = sub;
            //ITTeam = new ITTeam();            
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
        public string Subject { get; set; }

       
        public void GetStudentDetails()
        {            
            Console.WriteLine(this.ID +"    "+ this.Name + "    " + this.Teacher+"  "+ this.Subject);           
        }
    }
}
