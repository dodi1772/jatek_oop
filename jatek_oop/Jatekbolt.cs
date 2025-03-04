using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatek_oop
{
	internal class Jatekbolt
	{
		List<Jatek> jatekok;
		List<Felhasznalo> felhasznalok;
		public Jatekbolt()
		{
			jatekok= new List<Jatek>();
			felhasznalok=new List<Felhasznalo>();
		}
		public void JatekHozzaadas(Jatek jatek)
		{
			jatekok.Add(jatek);
            Console.WriteLine($"Játék sikeresen hozzáadva ({jatek.Cim}).");
        }
		public void FelhasznaloHozzaadas(Felhasznalo felhasznalo)
		{
			felhasznalok.Add(felhasznalo);
            Console.WriteLine($"Felhasznaló sikeresen hozzáadva ({felhasznalo.Nev}).");
        }
		public Jatek KeresJatek(string cim)
		{
            foreach (var jatek in jatekok)
            {
                if (jatek.Cim==cim)
                {
                    Console.WriteLine("A keresett játék létezik.");
                    return jatek;
                }
            }
            Console.WriteLine("A keresett játék nem található.");
            return null;
        }
		public Felhasznalo KeresFelhasznalo(string nev)
		{
			foreach (var felhasznalo in felhasznalok)
			{
				if (felhasznalo.Nev == nev)
				{
                    Console.WriteLine("A keresett felhasználó létezik.");
                    return felhasznalo;
				}
			}
            Console.WriteLine("A keresett felhasználó nem található.");
            return null;
		}
	}
}
