using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace практика1_11
{
    public class _практ1
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.Write("Введите предложение: ");
            userInput = Console.ReadLine();
            char a, b, c, d;
            a = 'а';
            b = 'А';
            c = ' ';
            d = '0';
            int n = 0;

            for (int i = 0; i < userInput.Length; i++)
            {

                if (userInput[i] != d)
                {
                    int counter = userInput.Count(f => (f == a) || (f == b));
                    n = counter;
                    

                }
                else
                {
                    Console.WriteLine(i);
                    break;


                }
            }

            Console.WriteLine("Букв А в предложении : " + n);
            Console.WriteLine("Всего букв в предложении: " + userInput.Length);
        }
    }
}
