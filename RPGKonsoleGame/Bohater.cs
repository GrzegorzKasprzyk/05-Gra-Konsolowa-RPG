﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGKonsoleGame
{
    public class Bohater
    {
        public string Imie { get; set; }
        public int MaksymalneZycie { get; set; }
        public int PosiadaneZycie { get; set; }
        public int Obrazenia { get; set; }
        public int Level { get; set; }
        public int PunktyDoswiadczenia { get; set; }

        public Bohater(string imie)
        {
            Imie = imie;
            MaksymalneZycie = 10;
            PosiadaneZycie = 10;
            Level = 1;
            PunktyDoswiadczenia = 0;
        }

        //static 
        public void Przegrana()
        {
            if (PosiadaneZycie <= 0)
            {
                PosiadaneZycie = 1;
                Console.WriteLine("Loser...Dostałeś po dupie. Na pocieszenie zostało Ci 1 HP...");
            }

            //static 
            public void Odpocznij()
            {
                Console.WriteLine("Rozbiłeś szałas. Chyba nic Cię nie zje, więc ucinasz sobie drzemkę");

                PosiadaneZycie++;
                if (MaksymalneZycie < PosiadaneZycie)
                    PosiadaneZycie = MaksymalneZycie;

            }
            //static
            public void PokazPostac()
            {
                Console.WriteLine(Imie + " Lvl:" + Level);
                Console.WriteLine("Życie: " + PosiadaneZycie + "/" + MaksymalneZycie);
            }

        }
    }
}