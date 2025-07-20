using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int value = random.Next(0, 101);

            int knightHealth = 1000;
            int dwarfHealth = 1000;
            int witchHealth = 1000;

            int knightDamage, dwarfDamage, witchDamage;

            int count = 0;

            while (knightHealth > 0 && dwarfHealth > 0 && witchHealth > 0)
            {
                count++;
                Console.WriteLine($"--- Поединок №{count}");

                knightDamage = random.Next(1, 11);
                dwarfDamage = random.Next(1, 11);
                witchDamage = random.Next(1, 11);

                knightHealth -= dwarfDamage + witchDamage;
                dwarfHealth -= knightDamage + witchDamage;
                witchHealth -= knightDamage + dwarfDamage;

                Console.WriteLine($"Здоровье рыцаря: {knightHealth}");
                Console.WriteLine($"Здоровье гнома: {dwarfHealth}");
                Console.WriteLine($"Здоровье ведьмы: {witchHealth}");
            }

            if (knightHealth <= 0)
            {
                Console.WriteLine("Рыцарь погиб!");
            }
            else if (dwarfHealth <= 0)
            {
                Console.WriteLine("Гном погиб!");
            }
            else if (witchHealth <= 0)
            {
                Console.WriteLine("Ведьма погибла!");
            }
        }
    }
}
