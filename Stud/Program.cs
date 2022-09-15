using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stud.Student;

namespace Stud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {

                Student s = new Student();
                s.Rollno = 1;
                s.Name = "Rahul";
                s.Percentage = 89.00;
                Console.WriteLine($"Rollno {s.Rollno} {s.Name}{s.Percentage}");

            }
        }
    }
}
