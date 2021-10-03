using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Students.Domain;

namespace University.Students.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var oStudent = new Teacher();
            oStudent.FirstName = "Sebastian";
            oStudent.LastName = "Cardona";

            var fullName = oStudent.ShowFullName();

            System.Console.WriteLine(fullName);
            System.Console.ReadLine();


        }
    }
}
