using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double E = 0.001;
            double S = 0;
            int n = 0;
            double x = Convert.ToDouble(Console.ReadLine());
            double A = x;
            do
            {
                S = S + A;
                n++;
                A = A * (n + 1) / ((n + 2) * n);
            }
            while (A >= E);
            Console.WriteLine($"Сумма ряда S={S,8:f4} , Число итераций n={n}");
        }
    }
}
