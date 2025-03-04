using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatek_oop
{
	internal class Jatek
	{
		public string Cim {  get; private set; }
		public string Kategoria { get; private set; }
		public int Ar {  get; private set; }

		public Jatek(string Cim, string Kategoria, int Ar)
		{
			this.Cim = Cim;
			this.Kategoria = Kategoria;
			this.Ar = Ar;
		}


	}
}
