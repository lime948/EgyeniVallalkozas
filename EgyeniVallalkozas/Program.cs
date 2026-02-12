using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyeniVallalkozas.Models;
using EgyeniVallalkozas.Views;
using EgyeniVallalkozas.Controllers;

namespace EgyeniVallalkozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                Console.Clear();
                Console.WriteLine("1. Kapcsolat felvitele");
                Console.WriteLine("2. Kapcsolat módosítása");
                Console.WriteLine("3. Kapcsolat törlése");
                Console.WriteLine("4. Kapcsolatok megtekintése");
                Console.WriteLine("5. Kilépés");
                Console.WriteLine("");
                Console.Write("Válasszon egy menüpontot: ");
                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "1":
                        KapcsHozz();
                        break;
                    case "2":
                        KapcsMod();
                        break;
                    case "3":
                        KapcsTorl();
                        break;
                    case "4":
                        KapcsKiir();
                        break;
                    case "5":
                        Console.WriteLine("Kilépés...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nincs ilyen menüpont");
                        break;
                }
            }
        }

        static void KapcsHozz()
        {
            bool b = true;
            while (b)
            {
                Console.Clear();
                Console.WriteLine("=== Kapcsolat hozzáadása ===");
                Console.Write("Adja meg a kapcsolat nevét: ");
                string nev = Console.ReadLine();
                Console.Write("Adja meg a kapcsolat levelezési címét: ");
                string cim = Console.ReadLine();
                Console.Write("Adja meg a kapcsolat email-jét: ");
                string email = Console.ReadLine();
                Console.Write("Adja meg a kapcsolat telefonszámát: ");
                string telefon = Console.ReadLine();
                if (nev != "" &&  cim != "" && email != "" && telefon != "")
                {
                    KapcsController kapcsController = new KapcsController();
                    string hozzaad = kapcsController.KapcsolatHozz(nev, cim, email, telefon);
                    Console.WriteLine(hozzaad);
                    b = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Minden mező kitöltése kötelező!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ReadLine();
            }
        }

        static void KapcsMod()
        {
            bool b = true;
            while (b)
            {
                Console.Clear();
                Console.WriteLine("=== Kapcsolat módosítása ===");
                List<Kapcsolatok> kapcslist = new KapcsController().KapcsolatList();
                KapcsView kapcsview = new KapcsView();
                kapcsview.KapcsolatokKiir(kapcslist);
                Console.Write("Adja meg a módosítandó kapcsolat azonosítóját: ");
                string modid = Console.ReadLine();
                Console.Write("Adja meg a kapcsolat nevét: ");
                string nev = Console.ReadLine();
                Console.Write("Adja meg a kapcsolat levelezési címét: ");
                string cim = Console.ReadLine();
                Console.Write("Adja meg a kapcsolat email-jét: ");
                string email = Console.ReadLine();
                Console.Write("Adja meg a kapcsolat telefonszámát: ");
                string telefon = Console.ReadLine();
                if (nev != "" && cim != "" && email != "" && telefon != "")
                {
                    KapcsController kapcsController = new KapcsController();
                    string hozzaad = kapcsController.KapcsolatMod(modid, nev, cim, email, telefon);
                    Console.WriteLine(hozzaad);
                    b = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Minden mező kitöltése kötelező!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ReadLine();
            }
        }

        static void KapcsTorl()
        {
            bool b = true;
            while (b)
            {
                Console.Clear();
                Console.WriteLine("=== Kapcsolat törlése ===");
                List<Kapcsolatok> kapcslist = new KapcsController().KapcsolatList();
                KapcsView kapcsview = new KapcsView();
                kapcsview.KapcsolatokKiir(kapcslist);
                Console.Write("Adja meg a törlendő kapcsolat azonosítóját: ");
                string torlid = Console.ReadLine();
                if (torlid != "")
                {
                    KapcsController kapcsController = new KapcsController();
                    string hozzaad = kapcsController.KapcsolatTorl(torlid);
                    Console.WriteLine(hozzaad);
                    b = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Minden mező kitöltése kötelező!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ReadLine();
            }
        }

        static void KapcsKiir()
        {
            Console.Clear();
            List<Kapcsolatok> kapcslist = new KapcsController().KapcsolatList();
            KapcsView kapcsview = new KapcsView();
            kapcsview.KapcsolatokKiir(kapcslist);
        }
    }
}
