using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGKonsoleGame
{
    class Program
    {
        private static string nazwaPostaci;
        private static int PozostaleZycie;
        private static int MaksymalneZycie;
        static void Main(string[] args)
        {
            {

                 nazwaPostaci = "Błyszczący Andrzej";
                int liczba = DajWieksza(5, 7);
                ObsługaMenu();
                

            }
           
            
            //static 
                void ObsługaMenu()
            {
                Console.WriteLine("Dokonaj wyboru...");

                
                Console.WriteLine("\n1. Nowa Gra");
                Console.WriteLine("2. Wczytaj Grę");
                Console.WriteLine("3. Koniec");

                string opcja = Console.ReadLine();
                Console.WriteLine("Wybrano opcję: " + opcja);

                if (opcja == "1")
                {
                    StworzPostac();
                    
                    
                }

                else if (opcja == "2")
                {

                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Dzięki za grę");
                    return;
                }
                
                while (opcja != "5")
                {
                    MenuGry();

                    opcja = Console.ReadLine();
                    if (opcja == "0")
                    {
                        PokazPostac();
                    }

                    if (opcja == "1")
                    {
                        IdzNaWyprawe();
                    }
                    else if(opcja == "2")
                    {
                        Odpocznij();
                    }
                    else if(opcja == "3")
                    {
                        Console.WriteLine("Opcja chwilowo niedostępna");
                    }
                    else if (opcja == "4")
                    {
                        Console.WriteLine("Opcja chwilowo niedostępna");
                    }

                    Console.WriteLine("Naciśnij enter, aby kontynuować");
                    Console.ReadLine();

                }

            }


            //static
            void MenuGry()
            {
                Console.Clear();
                Console.WriteLine("0. Zobacz postać");
                Console.WriteLine("1. Idź na wyprawę");
                Console.WriteLine("2. Odpocznij");
                Console.WriteLine("3. Ekwipunek");
                Console.WriteLine("4. Sklep");
                Console.WriteLine("5. Koniec");

            }

            //static 
                int DajWieksza(int liczba1, int liczba2)
            {
                if (liczba1 < liczba2)
                    return liczba2;
                return liczba1;
            }

            //static
            void PokazPostac()
            {

            }

            //static 
                void StworzPostac()
            {
                Console.Clear();
                Console.Write("Podaj imię postaci: ");
                nazwaPostaci = Console.ReadLine();
            }

            //static 
                void IdzNaWyprawe()

            {
                Console.Clear();
                Console.WriteLine("Wyruszyłeś na wyprawę");
               bool WynikWalki = Walka();

                if(WynikWalki)
                {
                    BonusyZaZwyciestwo();

                }
                else
                {
                    Przegrana();
                }

            }
            //static
            void BonusyZaZwyciestwo()
            {

            }

            //static 
            void Przegrana()
            {
                PozostaleZycie = 1;
            }
            //static 
                bool Walka()
            {
                
                Random losuj = new Random();
                int ZyciePrzeciwnika = losuj.Next(8,12);



                while (PozostaleZycie > 0)
            
                {
                     int obrazeniaZadane - losuj.Next(2, 3);
                    ZyciePrzeciwnika = obrazeniaZadane;
                    if (ZyciePrzeciwnika <= 0)
                        return true;

                    int obrazeniaOtrzymane = losuj.Next(0, 4);
                    PozostaleZycie = obrazeniaOtrzymane;


                }
                return true;
            }
            //static 
                void Odpocznij()
            {
                Console.WriteLine("Rozbiłeś szałas. Chyba nic Cię nie zje, więc ucinasz sobie drzemkę");

                PozostaleZycie++;
                if(MaksymalneZycie < PozostaleZycie)
                {
                    PozostaleZycie = MaksymalneZycie;
                }
            }
        }
    }
}
