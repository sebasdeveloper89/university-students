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
            var objCourse = new Course();
            var nombreCurso = objCourse.ShowCourseName();

            System.Console.WriteLine(nombreCurso);
            System.Console.ReadLine();


        }
    }
}
