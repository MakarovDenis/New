using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            Double R = 0, h = 0;
            Console.WriteLine("Введите Радиус");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту");
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Объем Цилиндра = "+PI*R*R*h);
            Console.WriteLine("     Площадь Цилиндра ="+2*PI*R*(R+h));
            Console.ReadKey();
        }
    }
}
