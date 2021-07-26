using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RPGKonsoleGame
{
   public class Dane
    {
        public List<IBroń> WczytajBronie()
        {
            var bronie = new List<IBroń>();
            using (StreamWriter reader = new StreamWriter("bronie.txt"))
            {
                string linia;
                while ((linia = reader.ReadLine()) != null)
                {
                    var odczyt = linia.Split(';');
                    bronie.Add(new Broń(odczyt[0], int.Parse(odczyt[1], int.Parse(odczyt[2])));
                }
            }
            
            using (StreamWriter reader = new StreamWriter("BronDworeczna.txt"))
            {
                string linia = reader.ReadLine();
                while(linia != null)
                {
                    string[] odczyt = linia.Split(';');
                    string nazwa = odczyt[0];
                    int cena = int.Parse(odczyt[1]);
                    int obrazenia = int.Parse(odczyt[2]);
                    bronie.Add(new BronDworeczna(nazwa, cena, obrazenia));

                    linia = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter("napiersniki.txt"))
            {

            }

            using (StreamWriter writer = new StreamWriter("tarcze.txt"))
            {

            }

            return bronie;

        }
    }
}
