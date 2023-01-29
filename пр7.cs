using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика1_11
{
    internal class пр7
    {
        static void Main(string[] args)
        {
            int playerHealth = 100;
            int playerDamage = 10;
            int enemyHealth = 50;
            int enemyDamage = 10;

            while (playerHealth > 0 && enemyHealth > 0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine(playerHealth + " игрок.");
                Console.WriteLine(enemyHealth + " враг.");
            }

            if (playerHealth <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("Ничья ");

            }
            else if(enemyHealth <= 0)
            {
                Console.WriteLine("Победа игрока");
            }
            else if(playerHealth <= 0)
            {
                Console.WriteLine("Победа врага");
            }
        }
    }
}
