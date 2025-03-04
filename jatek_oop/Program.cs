namespace jatek_oop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Jatekbolt jatekbolt = new Jatekbolt();
			Jatek Witcher = new Jatek("The Witcher 3", "RPG", 12000);
			Jatek Fifa = new Jatek("FIFA 23", "Sport", 18000);
			Jatek Cyberpunk = new Jatek("Cyberpunk 2077", "RPG", 15000);
			jatekbolt.JatekHozzaadas(Witcher);
			jatekbolt.JatekHozzaadas(Fifa);
			jatekbolt.JatekHozzaadas(Cyberpunk);
			Felhasznalo adam = new Felhasznalo("Ádám", 20000);
			jatekbolt.FelhasznaloHozzaadas(adam);
			Jatek witcher = jatekbolt.KeresJatek("The Witcher 3");
			adam.Vasarlas(witcher);
			adam.Feltoltes(10000);
			Jatek cyberpunk = jatekbolt.KeresJatek("Cyberpunk 2077");
			adam.Vasarlas(cyberpunk);
			adam.KonyvtarMegtekintes();
		}
	}
}
