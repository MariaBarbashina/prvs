using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace практика1_11
{
    public class _практ3
    {
        static void Main(string[] args)
        {
            int a, b, S;
            Console.WriteLine("Введите длину прямоугольника: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника: ");
            b = Convert.ToInt32(Console.ReadLine());

            int Sdan = 64;
            S = a * b;
            if(S > Sdan)
            {
                Console.WriteLine("Найденная площадь больше заданной.\nЗаданная площадь: " + Sdan + "\nНайденная площадь: " + S + "\nРазница площадей: " + (S - Sdan));

            }
            else if (S == Sdan)
            {
                Console.WriteLine("Площади равны, S = Sdan = " + S );
            }
            else
            {
                Console.WriteLine("Заданная площадь больше найденной.\nЗаданная площадь:" + Sdan + "\nНайденная площадь: " + S + "\nРазница площадей: " + (Sdan - S));
            }
        }
        
    }
}
