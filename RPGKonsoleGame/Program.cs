using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGKonsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string liczba1 = Console.ReadLine();
            string liczba2 = Console.ReadLine();

            int odczytanaLiczba1 = int.Parse(liczba1);
            int odczytanaLiczba2 = int.Parse(liczba2);

            if (odczytanaLiczba1 < odczytanaLiczba2)
            {
                Console.WriteLine("Druga liczba jest większa");
            }
            else
            {
                Console.WriteLine("Pierwsza liczba jest większa");
            }

            Console.ReadKey();
            /*
            Console.WriteLine("Dokonaj wyboru...");

            string nazwaPostaci;
            Console.WriteLine("\n1. Nowa Gra");
            Console.WriteLine("2. Wczytaj Grę");
            Console.WriteLine("3. Koniec");

            string opcja = Console.ReadLine();
            Console.WriteLine("Wybrano opcję: " + opcja);

            if (opcja == "1")
            {
                Console.Clear();
                Console.Write("Podaj imię postaci: ");
                nazwaPostaci = Console.ReadLine();
            }

            else if (opcja == "2")
            {

            }

            else
            {
                Console.Clear();
                Console.WriteLine("Dzięki za grę");
            }
            Console.ReadLine();
            */
        }
    }
}
