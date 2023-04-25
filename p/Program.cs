
using System;using System.Linq;using System.Collections.Generic;using System.Threading;

namespace mzdy
{
	class Program
	{
		public static void Main(string[] args)
		{
			#region Zadani
			Console.CursorVisible=false;Console.Title="Bankovní aplikace";Random nahoda=new Random();int nah;int chyba=0;
			Console.SetCursorPosition(22,7);string nazev="APLIKACE NA STANOVENÍ BANKOVEK A MINCÍ";
			
				string nazev2="pro výplatu sady finančních částek v hotovosti";
			foreach(char c in nazev){Console.Write(c+" ");Thread.Sleep(150);};Thread.Sleep(190);Console.ForegroundColor=ConsoleColor.Green;
						Console.SetCursorPosition(35,11);foreach(char c in nazev2){Console.Write(c+"");Thread.Sleep(90);};
						Console.ForegroundColor=ConsoleColor.DarkGray;Console.SetCursorPosition(10,25);Thread.Sleep(2000);
						Console.WriteLine("Program vytvořil: Marek Loníček");Console.SetCursorPosition(10,26);Thread.Sleep(4000);
						Console.WriteLine("e-mail: mark.lonicek@seznam.cz");Console.SetCursorPosition(10,27);Thread.Sleep(4000);
						Console.WriteLine("Vytvořeno dne: 27.6.2022");
						
						Thread.Sleep(4000);Console.Clear();Console.ForegroundColor=ConsoleColor.White;
			
			Console.ForegroundColor=ConsoleColor.White;Console.CursorVisible=false;Thread.Sleep(2000);
			string heslo="";Console.CursorVisible=true;
			
			while(heslo!="i"){Console.SetCursorPosition(35,10);Console.WriteLine("Zadejte heslo pro přístup do aplikace:");Console.SetCursorPosition(35,12);
				heslo=Console.ReadLine();Console.SetCursorPosition(35,14);if(heslo=="i"){Console.Clear();break;}Console.WriteLine("NESPRÁVNÉ heslo.");Console.SetCursorPosition(35,14);Console.BackgroundColor=ConsoleColor.DarkRed;Thread.Sleep(1500);Console.Clear();
			}
			Console.CursorVisible=false;Console.BackgroundColor=ConsoleColor.Black;Console.Clear();Thread.Sleep(2000);Console.SetCursorPosition(15,10);
			Console.WriteLine("Připojuji se k autorizovanému serveru, odesílám šifrovaná data a ověřuji požadavek klienta...");
			for(int iii=0;iii<107;iii++){Console.SetCursorPosition(8+iii,14);int cas=nahoda.Next(1,200);Console.WriteLine(".");Thread.Sleep(cas);
				if(iii%20==0){Thread.Sleep(nahoda.Next(900,2000));}
			}Console.BackgroundColor=ConsoleColor.Black;Console.Clear();
			Thread.Sleep(2000);
			Console.BackgroundColor=ConsoleColor.DarkGray;Console.Clear();Thread.Sleep(2000);Console.ForegroundColor=ConsoleColor.Gray;int z=600;int zz=z+300;
			Console.SetCursorPosition(30,1);Console.WriteLine("Welcome to the exciting world of financial freedom!");Thread.Sleep(2000);
			Console.SetCursorPosition(30,3);Console.WriteLine("...Investment");Thread.Sleep(z);
			Console.SetCursorPosition(30,4);Console.WriteLine("...E-money");Thread.Sleep(z);
			Console.SetCursorPosition(30,5);Console.WriteLine("...Securities and Crypto");Thread.Sleep(z);
			Console.SetCursorPosition(30,6);Console.WriteLine("...Internet Banking");Thread.Sleep(z);
			Console.SetCursorPosition(30,7);Console.WriteLine("...Global economics trends");Thread.Sleep(z);
			Console.SetCursorPosition(30,8);Console.WriteLine("...Developing smart applications ");Thread.Sleep(1000);
			Console.SetCursorPosition(30,14);Console.WriteLine("Explore.");Thread.Sleep(zz);
			Console.SetCursorPosition(35,16);Console.WriteLine("Enjoy.");Thread.Sleep(zz);
			Console.SetCursorPosition(40,18);Console.WriteLine("Dream.");Thread.Sleep(zz);
			Console.SetCursorPosition(45,20);Console.WriteLine("Change the World.");Thread.Sleep(z);
			
			Thread.Sleep(2000);
			Console.BackgroundColor=ConsoleColor.DarkGreen;Console.Clear();
			Console.SetCursorPosition(50,12);Console.WriteLine("Heslo OK.");Console.SetCursorPosition(50,14);
			Console.WriteLine("Přístup POVOLEN.");Thread.Sleep(3000);
			Console.BackgroundColor=ConsoleColor.Black;Console.Clear();Console.ForegroundColor=ConsoleColor.White;Thread.Sleep(1000);
			Console.SetCursorPosition(25,22);Console.WriteLine("Extrahují se soubory, počkejte prosím...");Console.ForegroundColor=ConsoleColor.Blue;
			Thread.Sleep(2000);
			int i;int j;for(i=9;i<105;i++) {Console.SetCursorPosition(i,26);nah=nahoda.Next(1,350);
				if(i%20==0){Thread.Sleep(nahoda.Next(500,3000));}
				Console.WriteLine("█");Thread.Sleep(nah);}Thread.Sleep(300);
				Console.SetCursorPosition(106,26);Console.WriteLine("100 %");
			
			Thread.Sleep(900);Console.Clear();Console.ForegroundColor=ConsoleColor.White;
			Console.SetCursorPosition(25,22);Console.WriteLine("Data načtena.");Thread.Sleep(600);Console.Clear();
			
			string odpoved="a";
			while(odpoved=="a"){
			Console.ForegroundColor=ConsoleColor.Blue;
			Console.SetCursorPosition(79,5);Thread.Sleep(1000);Console.WriteLine("Připojuji se k bankovním serverům ...");Thread.Sleep(2000);int castka;
			string[] banky={"ČSOB","Komerční banka","Money Bank","ČNB","Moneta","UniCredit Bank","Reiffeissen Bank","Fio banka"};
			Console.ForegroundColor=ConsoleColor.Green;
			for(i=0;i<8;i++){Console.SetCursorPosition(80,9+2*i);Console.WriteLine("| "+banky[i]);Thread.Sleep(1000);}
			Console.SetCursorPosition(0,2);
			Console.ForegroundColor=ConsoleColor.White;Thread.Sleep(1900);Console.CursorVisible = true;Console.ForegroundColor=ConsoleColor.DarkYellow;
			Console.WriteLine("Zadejte POČET zvolených nominálních hodnot bankovek/mincí:\n...můžete zadat max. až 12 pro komplet:\n5000 Kč,2000,1000,500,200,100,50,20,10,5,2,1 Kč.");
			Console.ForegroundColor=ConsoleColor.White;
			int pocet;
			do {
				while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out pocet)){ Console.WriteLine("Nevhodné zadání. Zadejte počet variant hodnot platidel číslem 1 až 12...");}
				} while (pocet < 1 || pocet > 12);
			Console.WriteLine("\nZadali jste: "+pocet);
			int[] platidla=new int[pocet];int[] pole=new int[pocet];
			int[] rozdeleni=new int[pocet];Console.ForegroundColor=ConsoleColor.White;
			
			for(i=0;i<pocet;i++){Console.ForegroundColor=ConsoleColor.DarkYellow;Console.WriteLine("\nZadej {0}. bankovku/minci:\n...vyberte si z bankovních hodnot ČR: 5000,2000,1000,500,200,100,50,20,10,5,2,1.",i+1);
			Console.ForegroundColor=ConsoleColor.White;Console.CursorVisible=false;
			int bankovka;Console.ForegroundColor=ConsoleColor.White;
			
			while (!int.TryParse(Console.ReadLine(), out bankovka)){ Console.WriteLine("Nevhodné zadání. Zadejte pouze číselnou nominální hodnotu platidla.");}
				
			platidla[i]=bankovka;}
			
			foreach(int radek in platidla) Console.Write("Zadáno: {0} Kč, ",radek);
			int[] frekvence=new int[pocet];
			for(i=0;i<frekvence.Length;i++) frekvence[i]=0;// Nastaveni pole frekvence vsech zadanych platidel na pocatecni nuly
			#endregion
			#region Zpracovani
			Console.ForegroundColor=ConsoleColor.DarkYellow;
			Console.WriteLine("\n\nZadejte castky v Kč oddelene carkou a bez mezer:\n...libovolný počet hotovostí/mezd, např. 8570,12320,15213,5620,375,50000");Console.ForegroundColor=ConsoleColor.White;
			string text=Console.ReadLine().Trim();string[] textPole=text.Split(',');int[] vstupy=new int[textPole.Length];
			for(int c=0;c<textPole.Length;c++) {vstupy[c]=int.Parse(textPole[c]);}
			
			foreach(int radek in vstupy){Console.Write("Zadáno: "+radek+" Kč, ");};Console.WriteLine("\nCelkem: "+vstupy.Sum()+" Kč.");
			Thread.Sleep(900);
			
			
			for(j=0;j<vstupy.Length;j++){
			
			do{
					Console.WriteLine("\n");Console.BackgroundColor=ConsoleColor.DarkBlue;
					Console.WriteLine(j+1+". CASTKA: ");Console.BackgroundColor=ConsoleColor.Black;
					for(i=0;i<frekvence.Length;i++) frekvence[i]=0;// Vynulovani aktualni frekvence
					castka=vstupy[j];
				for(i=0;i<pocet;i++)
					while(castka>=platidla[i]) {castka-=platidla[i];frekvence[i]++;}
				chyba++;if(chyba>500){Thread.Sleep(200);Console.WriteLine("\n\nNastala CHYBA zpracování vstupních dat.\nZřejmě byla zadána nevhodná sada vstupních dat.\n" +
				                                                           "Patrně byla zadána sada hotovostí NEDĚLITELNÝCH zcela zadanými hodnotami bankovek/mincí.\n" +
				                                                           "Můžete se obrátit s dotazy na autora tohoto programu, e-mail: mark.lonicek@seznam.cz.\n\nProgram bude za 60 sek UKONČEN.\n");
				                                                           Thread.Sleep(1000);
				                                                           for(int ii=0;ii<60;ii+=5){Console.ForegroundColor=ConsoleColor.DarkRed;Console.Write(" █"+ii+"s");Thread.Sleep(5000);}
				                                                           return;}
				}while(castka>0);
				
			
			Console.WriteLine("");Thread.Sleep(900);
			for(i=0;i<pocet;i++) {
				pole[i]=platidla[i]*frekvence[i];rozdeleni[i]+=frekvence[i];
				Console.WriteLine(i+1+". platidlo: {0} Kč, jeho frekvence: {1}x krát,\t{0} * {1} = {2} Kč.",platidla[i],frekvence[i],platidla[i]*frekvence[i]);
			}
			Console.WriteLine("");Thread.Sleep(900);
			for(i=0;i<pole.Length-1;i++){Console.Write(pole[i]+" Kč + ");}
			Console.Write(pole[pole.Length-1]+" Kč = "+pole.Sum()+" Kč.");
			
			}
			Console.BackgroundColor=ConsoleColor.DarkBlue;Console.WriteLine("\n\n");Thread.Sleep(900);
			Console.Write("Celkem vyplatit na mzdách: ");Console.BackgroundColor=ConsoleColor.Black;
			Console.Write(" "+vstupy.Sum()+" Kč.");
			Thread.Sleep(900);
			Console.BackgroundColor=ConsoleColor.DarkGreen;
			Console.WriteLine("\n\n\nJít do banky pro tento počet těchto bankovech: ");Console.BackgroundColor=ConsoleColor.Black;
			Console.ForegroundColor=ConsoleColor.DarkGreen;			
			for(int d=0;d<rozdeleni.Length;d++)
			{Console.WriteLine("\t\t\t\t\t\t"+rozdeleni[d]+" krát "+platidla[d]+" Kč (..."+rozdeleni[d]*platidla[d]+" Kč)");}
			Thread.Sleep(900);Console.ForegroundColor=ConsoleColor.White;
			Console.WriteLine("\nBude to tedy celkem: ");
			for(int d=0;d<rozdeleni.Length-1;d++)
			{Console.Write(rozdeleni[d]*platidla[d]+" Kč + ");}
			Console.WriteLine(rozdeleni[rozdeleni.Length-1]*platidla[rozdeleni.Length-1]+" Kč = "+vstupy.Sum()+" Kč.");
			
			
			
			Console.BackgroundColor=ConsoleColor.DarkCyan;
			Thread.Sleep(4000);Console.WriteLine("\n\nOpakovat ještě program? Zadejte [a/n] a potvrďte Enterem ...");
			Console.ForegroundColor=ConsoleColor.White;Console.BackgroundColor=ConsoleColor.Black;
			odpoved=Console.ReadLine().Trim().ToLower();
			Thread.Sleep(500);
			if(odpoved=="a"){Console.WriteLine("Nyni probehne program znovu.");Thread.Sleep(900);
				Console.Clear();}
			}
			Thread.Sleep(300);
			Console.WriteLine("\nProgram bude nyni ukončen. Pro ukonceni stisknete libovolnou klavesu ...");
			Console.ReadKey(true);
			#endregion
		}
	}
}