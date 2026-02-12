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
            Console.Clear();
            Console.WriteLine("=== Kapcsolat hozzáadása");
        }

        static void KapcsMod()
        {
            Console.Clear();
            Console.WriteLine("");
        }

        static void KapcsTorl()
        {
            Console.Clear();
            Console.WriteLine("");
        }

        static void KapcsKiir()
        {
            Console.Clear();
            Console.WriteLine("");
        }
    }
}
