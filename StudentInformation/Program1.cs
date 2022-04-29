using System;
namespace StudentInformation
{
    class Program1
    {
        static void Main(string[] args)
        {
            TeacherStudentInfo tsi1 = new TeacherStudentInfo(11, "Tiwari", "Bala","OA3");
            TeacherStudentInfo tsi2 = new TeacherStudentInfo(12, "Kishore", "Bala", "IMOD");
            TeacherStudentInfo tsi3 = new TeacherStudentInfo(13, "Bharath", "Bala", "DT");
            TeacherStudentInfo tsi4 = new TeacherStudentInfo(14, "Radhika", "Bala", "Federal");
            Console.WriteLine("Student ID Student Name Student Teacher Student Subject");
            tsi1.GetStudentDetails();
            tsi2.GetStudentDetails();
            tsi3.GetStudentDetails();
            tsi4.GetStudentDetails();
            Console.WriteLine("Hello, World!");
        }
    }
}

