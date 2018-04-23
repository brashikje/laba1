using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student objStudent = new Student();
            Console.WriteLine(objStudent);
            Student oobjStudent = new Student("Masha", 3, true);
            Console.WriteLine(oobjStudent);
            Console.ReadKey();
        }
    } 
}
