using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatek_oop
{
	internal class Felhasznalo
	{
		public string Nev {  get; private set; }
		public int Egyenleg { get; private set; }
		List<Jatek> Konyvtar = new List<Jatek>();

		public Felhasznalo(string nev, int egyenleg)
		{
			Nev = nev;
			Egyenleg = egyenleg;
		}
		public bool Vasarlas(Jatek jatek)
		{
            foreach (var item in Konyvtar)
            {
                if (item.Cim==jatek.Cim || Egyenleg<jatek.Ar)
                {
                    Console.WriteLine("A vásárlás sikertelen, mivel nem áll rendelkezésre elég egyenleg, vagy már megvan ez a játék.");
					return false;
                }
            }
            Console.WriteLine($"A(z) {jatek.Cim} sikeresen megvásárolva!");
            Konyvtar.Add(jatek);
			return true;
        }
		public void KonyvtarMegtekintes()
		{
            Console.WriteLine("Megvásárolt játékok: ");
            foreach (var konyv in Konyvtar)
            {
                Console.WriteLine($"- {konyv.Cim}");
            }
        }
		public void Feltoltes(int osszeg)
		{
            Console.WriteLine($"Egyenleg feltöltve: +{osszeg} Ft");
        }
	}
}
