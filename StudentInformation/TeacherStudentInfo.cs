using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    class TeacherStudentInfo:School
    {
        public TeacherStudentInfo(int id, string sname, string steacher, string subject) : base(id, sname, steacher, subject)
        {
            
        }
    }
}
