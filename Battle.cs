using System;
using System.Threading;

namespace Gierka
{
    public class Battle
    {
        public static void Fight(Hero hero, Enemy enemy)
        {
            Random rnd = new Random();
            System.ConsoleKey k;
            Console.WriteLine("\nRozpoczyna sie walka z {0}", enemy.GetName());
            Console.WriteLine("Zdrowie przeciwnika wynosi {0}/{1}", enemy.GetCurrentHealth(), enemy.GetHealth());

            while (hero.GetCurrentHealth() > 0 && enemy.GetCurrentHealth() > 0)
            {
                Console.WriteLine("\nWybierz typ ataku: ");
                Console.WriteLine("[1] Szybki atak");
                Console.WriteLine("[2] Silny atak");
                Console.WriteLine("[3] Użycie znaku");
                k = Console.ReadKey().Key;
                Console.WriteLine("");

                switch(k)
                {
                    case ConsoleKey.D1: 
                        enemy.SetCurrentHealth(hero.QuickAttack());
                        Console.Clear();
                        Console.WriteLine("                            ------------");
                        Console.WriteLine("                            |WIEDZMIN 4|");
                        Console.WriteLine("                            ------------");
                        Console.WriteLine("\n------------------------------------");
                        Console.WriteLine("Wykonujesz szybki atak!");
                        Console.WriteLine("Uderzasz przeciwnika za {0} obrażeń!", hero.QuickAttack());
                        break;
                    case ConsoleKey.D2:
                        enemy.SetCurrentHealth(hero.StrongAttack());
                        Console.Clear();
                        Console.WriteLine("                            ------------");
                        Console.WriteLine("                            |WIEDZMIN 4|");
                        Console.WriteLine("                            ------------");
                        Console.WriteLine("\n------------------------------------");
                        Console.WriteLine("Wykonujesz silny atak!");
                        Console.WriteLine("Uderzasz przeciwnika za {0} obrażeń!", hero.StrongAttack());
                        break;
                    case ConsoleKey.D3:
                        hero.ChooseSigns();
                        k = Console.ReadKey().Key;
                        if (k == ConsoleKey.D1)
                        {
                            enemy.SetCurrentHealth(hero.Igni());
                            Console.Clear();
                            Console.WriteLine("                            ------------");
                            Console.WriteLine("                            |WIEDZMIN 4|");
                            Console.WriteLine("                            ------------");
                            Console.WriteLine("\n----------------------------------");
                            Console.WriteLine("Rzucasz znak Igni!");
                            Console.WriteLine("Zadajesz przeciwnikowi {0} obrazen!", hero.Igni());
                        }
                        else if (k == ConsoleKey.D2)
                        {
                            hero.SetCurrentHealth(hero.Quen());
                            Console.Clear();
                            Console.WriteLine("                            ------------");
                            Console.WriteLine("                            |WIEDZMIN 4|");
                            Console.WriteLine("                            ------------");
                            Console.WriteLine("\n-----------------------------------");
                            Console.WriteLine("Rzucasz znak Quen!");
                            Console.WriteLine("Otrzymujesz tarcze za {0} punktow zdrowia!", hero.Quen());
                        }
                        break;
                    default: break;
                }

                if(enemy.GetCurrentHealth() > 0)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("{0} wykonuje atak!", enemy.Name);
                    int applied_dmg = enemy.GetAttack();
                    hero.ApplyDamage(applied_dmg);
                    Console.WriteLine("{0} zadaje Tobie {1} obrazen!", enemy.Name, applied_dmg);
                }

                if(enemy.GetCurrentHealth() <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("                            ------------");
                    Console.WriteLine("                            |WIEDZMIN 4|");
                    Console.WriteLine("                            ------------");
                    Console.WriteLine("\n-----------------------------------");
                    Console.WriteLine("Udalo ci sie pokonac {0}", enemy.Name);
                    //Console.WriteLine("\nCzy chcesz medytowac aby odnowic brakujace zdrowie?"+"\n[1]TAK   [2]NIE");
                }

                if (hero.GetCurrentHealth() <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("                            ------------");
                    Console.WriteLine("                            |WIEDZMIN 4|");
                    Console.WriteLine("                            ------------");
                    Console.WriteLine("\nZostales pokonany! :(");
                    Environment.Exit(0);
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Poziom zdrowia bohatera {0}/{1}", hero.GetCurrentHealth(), hero.GetHealth());
                Console.WriteLine("Poziom zdrowia przeciwnika {0}/{1}", enemy.GetCurrentHealth(), enemy.GetHealth());
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
