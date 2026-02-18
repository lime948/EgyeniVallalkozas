using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyeniVallalkozas.Models;

namespace EgyeniVallalkozas.Views
{
    internal class KapcsView
    {
        public KapcsView() { }

        public void KapcsolatokKiir(List<Kapcsolatok> kapcsolatok)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔══════╦═══════════════════════╦════════════════════════════════════════╦═════════════════════════════╦═══════════════╗");
            Console.WriteLine("║  ID  ║ Név                   ║ Levelezési cím                         ║ Email                       ║ Telefon       ║ ");
            foreach (var kapcs in kapcsolatok)
            {
                Console.WriteLine("╠══════╬═══════════════════════╬════════════════════════════════════════╬═════════════════════════════╬═══════════════╣");
                Console.WriteLine(ToRow(kapcs));
            }
            Console.WriteLine("╚══════╩═══════════════════════╩════════════════════════════════════════╩═════════════════════════════╩═══════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
        private static string ToRow(Kapcsolatok kapcs)
        {
            return $"║ {kapcs.Id,-4} ║ {kapcs.Nev,-21} ║ {kapcs.Cim,-38} ║ {kapcs.Email,-27} ║ {kapcs.Telefon,-13} ║";
        }
    }
}
