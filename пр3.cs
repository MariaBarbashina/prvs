using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика1_11
{
    internal class пр3
    {
        static void Main(string[] args)
        {
            string password = "123qwe";
            string userInput;

            Console.Write("Введите пароль: ");

            userInput = Console.ReadLine();

            if (userInput == password)
            {
                Console.WriteLine("Пароль принятю Доступ к базе данных разрешен");
            }
            else
            {
                Console.WriteLine("Неверный пароль. Доступ закрыт");
            }
        }
    }
}
