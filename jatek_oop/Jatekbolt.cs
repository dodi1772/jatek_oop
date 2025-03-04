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
		}
		public void FelhasznaloHozzaadas(Felhasznalo felhasznalo)
		{
			felhasznalok.Add(felhasznalo);
		}
		public Jatek KeresJatek(string cim)
		{
            foreach (var jatek in jatekok)
            {
                if (jatek.Cim==cim)
                {
                    return jatek;
                }
            }
			return null;
        }
		public Felhasznalo KeresFelhasznalo(string nev)
		{
			foreach (var felhasznalo in felhasznalok)
			{
				if (felhasznalo.Nev == nev)
				{
					return felhasznalo;
				}
			}
			return null;
		}
	}
}
