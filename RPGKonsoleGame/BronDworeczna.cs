using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGKonsoleGame
{
    public class BronDworeczna : IBron
    {
        public string Nazwa { get ; set ; }
        public int Cena { get ; set; }
        public int ModyfikatorObrazen { get ; set ; }
        public bool MozliwoscNoszeniaTarczy 
        { get

            {
                return false;
            }
        }
        public BronDworeczna(string nazwa, int cena, int modyfikatorObrazen)
        {
            Nazwa = nazwa;
            Cena = cena;
            ModyfikatorObrazen = modyfikatorObrazen;
        }

        public int ObliczObrazenia()
        {
            return ModyfikatorObrazen * 3;
        }
    }
}
