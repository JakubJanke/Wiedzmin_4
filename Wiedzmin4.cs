using System;

namespace Gierka
{
class Wiedzmin4
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("                            ------------");
            Console.WriteLine("                            |WIEDZMIN 4|");
            Console.WriteLine("                            ------------");
            Console.Write("\nPodaj nazwe bohatera: ");
            string name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("                            ------------");
            Console.WriteLine("                            |WIEDZMIN 4|");
            Console.WriteLine("                            ------------");
            Console.Write("\nWybierz cech do ktorego chcesz przynalezec: ");
            Console.WriteLine("\n[1]Szkola Cechu Wilka"+"\n[2]Szkola Cechu Kota"+"\n[3]Szkola Cechu Niedzwiedzia");
            System.ConsoleKey klasa = Console.ReadKey().Key;
            string kl="";
            switch(klasa)
            {
                case ConsoleKey.D1: 
                    kl="Szkola Cechu Wilka"; 
                    break;
                case ConsoleKey.D2:
                    kl="Szkola Cechu Kota"; 
                    break;
                case ConsoleKey.D3:
                    kl="Szkola Cechu Niedzwiedzia"; 
                    break;
            }

            Hero hero = new Hero(name, kl);
            Console.Clear();
            Console.WriteLine("                            ------------");
            Console.WriteLine("                            |WIEDZMIN 4|");
            Console.WriteLine("                            ------------");
            Console.WriteLine("\n| IMIE BOHATERA | "+hero.Name
                            +"\n| SZKOLA        | "+hero.MyClass
                            +"\n| ZDROWIE       | {0}/{1}"
                            +"\n| MOC ZNAKOW    | {2}"
                            +"\n| OBRAZENIA     | {3}",
                            hero.GetHealth(), hero.GetCurrentHealth(), hero.GetSigns(), hero.GetDamage());
            
            Enemy Wolf = new Enemy("Wilk", 350, 350, 50);
            Enemy Kuroliszek = new Enemy("Kuroliszek", 3000, 3000, 100);

            Story.Begining();
            Battle.Fight(hero, Wolf);
            Story.Pogorzeliska();
            Battle.Fight(hero, Kuroliszek);
            Story.ZakonczenieZlecenia();
            Story.DalszaPodroz();
        }
    }
}