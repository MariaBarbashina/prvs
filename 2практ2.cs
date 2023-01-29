using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace практика1_11
{
    public class _практ2
    {
        static void Main(string[] args)
        {
            float pi = 3.14f;
            Console.WriteLine("Введите радиус: ");
            int R, sq;
            float S;
            R = Convert.ToInt32(Console.ReadLine());
            sq = Convert.ToInt32(Math.Pow(R, 2));
            S = pi * sq;
            Console.WriteLine("Площадь круга равна: " + S);
        }
    }
}
