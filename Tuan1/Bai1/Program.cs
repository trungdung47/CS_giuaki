using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ho ten: ");
            string name = Console.ReadLine();
            Console.Write("Nhap truong hoc: ");
            string school = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            int birthYear = int.Parse(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            Console.WriteLine("{0} - {1} - {2}", name, school, age);
        }
    }
}
