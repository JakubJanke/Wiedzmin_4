using System;
using System.Threading;

public class Story
{
    public static void Begining()
    {
        Console.WriteLine("\n----------------------------------------------------------------------");
        Console.WriteLine("Skonczyla sie zima a Ty wyjechales w glab Kontynentu w celu zarobku.");
        Console.WriteLine("Po kilku dniach drogi trafiasz do Wsi Rudnik.");
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("\n[1]Podejdz do tablicy ogloszen."+"\n[2]Idz do karczmy.");
        System.ConsoleKey response = Console.ReadKey().Key;
        if (response == ConsoleKey.D1)
        {
            Story.TablicaOgloszen();
        }

        if (response == ConsoleKey.D2)
        {
            Story.Karczma();
        }
    }
    public static void TablicaOgloszen()
    {
        Console.Clear();
        Console.WriteLine("                            ------------");
        Console.WriteLine("                            |WIEDZMIN 4|");
        Console.WriteLine("                            ------------");
        Console.WriteLine("\n--------------------------------------------------------------------------------------------");
        Console.WriteLine("Na tablicy ogloszen znajdujesz zlecenie na Kuroliszka wystawione przez tutejszego barona.");
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("\n[1]Przyjmij zlecenie."+"\n[2]Odrzuc zlecenie.");
        System.ConsoleKey response = Console.ReadKey().Key;
        if (response == ConsoleKey.D1)
        {
            Story.PrzyjecieZlecenia();
        }

        if (response == ConsoleKey.D2)
        {
            Story.OdrzucenieTablica();
        }
    }
    public static void Karczma()
    {
        Console.Clear();
        Console.WriteLine("                            ------------");
        Console.WriteLine("                            |WIEDZMIN 4|");
        Console.WriteLine("                            ------------");
        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Wchodzisz do karczmy w ktorej spotykasz sie tylko ze zlowrogimi spojzeniami miejscowych.");
        Console.WriteLine("Zamawiasz Redanski Lager i zajmujesz miejsce przy stole.");
        Console.WriteLine("Po chwili zwabiony twoim wygladem i wyposarzeniem podchodzi do ciebie czlowiek barona z pytaniem czy nie byl bys w stanie zabic grasujacego we wsi Kuroliszka.");
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("\n[1]Przyjmij zlecenie"+"\n[2]Zbyj czlowieka barona mowiac ze nie masz czasu i zatrzymales sie tutaj tylko na chwile aby zregenerowac sily po dlugiej podrozy.");
        System.ConsoleKey response = Console.ReadKey().Key;
        if (response == ConsoleKey.D1)
        {
            Story.PrzyjecieZlecenia();
        }

        if (response == ConsoleKey.D2)
        {
            Story.OdrzucenieKarczma();
        }
    }
    public static void OdrzucenieTablica()
    {
        Console.Clear();
        Console.WriteLine("                            ------------");
        Console.WriteLine("                            |WIEDZMIN 4|");
        Console.WriteLine("                            ------------");
        Console.WriteLine("\n--------------------------");
        Console.WriteLine("Niedlugo zajdzie slonce.");
        Console.WriteLine("--------------------------");
        Console.WriteLine("\n[1]Wejdz do karczmy aby chwile odpoczac i uzupelnic zapasy."+"\n[2]Nie ma co marnowac czasu, wyruszaj w dalsza droge.");
        System.ConsoleKey response = Console.ReadKey().Key;
        if (response == ConsoleKey.D1)
        {
            Story.Karczma();
        }

        if (response == ConsoleKey.D2)
        {
            Story.DalszaPodroz();
            Environment.Exit(0);
        }
    }
    public static void OdrzucenieKarczma()
    {
        Console.Clear();
        Console.WriteLine("                            ------------");
        Console.WriteLine("                            |WIEDZMIN 4|");
        Console.WriteLine("                            ------------");
        Console.WriteLine("\n--------------------------------");
        Console.WriteLine("Uzupelniles zapasy i wypoczales.");
        Console.WriteLine("Wyruszasz w dalsza droge.");
        Story.DalszaPodroz();
        Environment.Exit(0);
    }
    public static void PrzyjecieZlecenia()
    {
        Console.Clear();
        Console.WriteLine("                            ------------");
        Console.WriteLine("                            |WIEDZMIN 4|");
        Console.WriteLine("                            ------------");
        Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Przyjales zlecenie i udajesz sie do Kasztelu aby porozmawiac z baronem w celu uzyskania dodatkowych informacji na temat potwora.");
        Console.WriteLine("Baron informuje sie ze bestia mieszkala na Pogorzeliskach ale ostatnio zaczela przylatywac do tutejszej wsi terroryzujac mieszkancow.");
        Console.WriteLine("Prosi ciebie o szybkie zabicie besti i obiecuje duza nagrode za jej glowe.");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Udajesz sie na Pogorzeliska.");
        Console.WriteLine("W drodze przez las zaatakowal ciebie wilk.");
        Console.WriteLine("---------------------------------------------");
    }
    public static void Pogorzeliska()
    {
        /*Console.Clear();
        Console.WriteLine("                            ------------");
        Console.WriteLine("                            |WIEDZMIN 4|");
        Console.WriteLine("                            ------------");*/
        Console.WriteLine("\n-------------------------------------------------------------------------------------------");
        Console.WriteLine("Dotarles na Pogorzeliska.");
        Console.WriteLine("Na miejscu widzisz zniszczone gniazdo Kuroliszka co moglo byc powodem jego atakow na wies.");
        Console.WriteLine("Nagle w oddali slyszysz glosni skrzek.");
        Console.WriteLine("Nadlatuje Kuroliszek i zaczyna sie walka.");
        Console.WriteLine("-------------------------------------------------------------------------------------------");
    }
    public static void ZakonczenieZlecenia()
    {
        /*Console.Clear();
        Console.WriteLine("                            ------------");
        Console.WriteLine("                            |WIEDZMIN 4|");
        Console.WriteLine("                            ------------");*/
        Console.WriteLine("\n-----------------------------------------------------------------");
        Console.WriteLine("Udalo ci sie zabic potwora.");
        Console.WriteLine("Wracasz do brona w celu odebrania nagrody.");
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("Baron wielce ucieszyl sie na twoj widok i wreczyl tobie nagrode ktora wynosila 500 koron.");
        Console.WriteLine("Dal tobie takze glejt. Lepiej go zachowac bo nie wiadomo kiedy moze byc przydatny.");
    }
    public static void DalszaPodroz()
    {
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("Opuszczasz Wies Rudnik.");
        Console.WriteLine("Twoim nastepnym celem podrozy jest jeszcze Wolne Miasto Novigrad.");
        Console.WriteLine("Zlozysz tam wizyte swojemu dawnemu przyjacielowi.");
        Console.WriteLine("cdn...");
        Console.WriteLine("-----------------------------------------------------------------");
    }
}