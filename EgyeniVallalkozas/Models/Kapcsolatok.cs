using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyeniVallalkozas.Models
{
    internal class Kapcsolatok
    {
        private int id;
        private string nev;
        private string cim;
        private string email;
        private string telefon;

        public Kapcsolatok(int id, string nev, string cim, string email, string telefon)
        {
            this.id = id;
            this.nev = nev;
            this.cim = cim;
            this.email = email;
            this.telefon = telefon;
        }

        public Kapcsolatok() { }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Email { get => email; set => email = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public override string ToString()
        {
            return $"Azonosító: {id}, Név: {nev}, Cím: {cim} Email: {email}, Telefon: {telefon}";
        }
    }
}
