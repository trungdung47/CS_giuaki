using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a: "); ;
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine());
            double bt1 = Math.Pow(a, 2) - 2 * b + a * b / c;
            bt1 = Math.Round(bt1, 3);
            double bt2 = (Math.Pow(b, 2) - 4 * a * c) / (2 * a);
            bt2 = Math.Round(bt2, 3);
            double bt3 = 3 * a - Math.Pow(b, 3) - 2 * Math.Sqrt(c);
            bt3 = Math.Round(bt3, 3);
            double bt4 = Math.Sqrt(Math.Pow(a, 2) / b - (4 * a) / (b * c) +1);
            bt4 = Math.Round(bt4, 3);
            double bt5 = Math.Pow(277, (double)1/3);
            Console.Write("{0}, {1}, {2}, {3}, {4}", bt1, bt2, bt3, bt4, bt5);   
        }
    }
}
