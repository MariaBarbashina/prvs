﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace практика1_11
{
    internal class пр2
    {
        static void m(string[] args)
        {
            int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPay;


            Console.WriteLine("Добро пожаловать в пекарню! Сегодня еда по " + foodUnitPrice + " монет" );
            Console.Write("Сколько у вас золота?");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько еды вам нужно? ");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= food * foodUnitPrice;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food * foodUnitPrice;
            Console.WriteLine($"У вас в сумке {food} единиц еды и {money} монет");
        }
    }
}
