using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyeniVallalkozas.Models;
using MySql.Data.MySqlClient;

namespace EgyeniVallalkozas.Controllers
{
    internal class KapcsController
    {
        public List<Kapcsolatok> KapcsolatList()
        {
            MySqlConnection conn = new MySqlConnection();
            string connstring = "SERVER = localhost;DATABASE=egyenivallalkozas;UID=root;PASSWORD=;";
            conn.ConnectionString = connstring;
            conn.Open();
            string sql = "SELECT * FROM kapcsolatok";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            List<Kapcsolatok> eredmeny = new List<Kapcsolatok>();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                eredmeny.Add(new Kapcsolatok()
                {
                    Id = reader.GetInt32("Azon"),
                    Nev = reader.GetString("Nev"),
                    Cim = reader.GetString("Cim"),
                    Email = reader.GetString("Email"),
                    Telefon = reader.GetString("Telefon")
                });
            }
            conn.Close();
            return eredmeny;
        }

        public string KapcsolatHozz(string nev, string cim, string email, string telefon)
        {
            MySqlConnection conn = new MySqlConnection();
            string connstring = "SERVER = localhost;DATABASE=egyenivallalkozas;UID=root;PASSWORD=;";
            conn.ConnectionString = connstring;
            try
            {
                conn.Open();
                string sql = "INSERT INTO `kapcsolatok`(`Azon`, `Nev`, `Cim`, `Email`, `Telefon`) VALUES (null,'@nev','@cim','@email','@telefon')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nev", nev);
                cmd.Parameters.AddWithValue("@cim", cim);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefon", telefon);
                int sorokSzama = cmd.ExecuteNonQuery();
                conn.Close();
                string valasz = "";
                if (sorokSzama > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    valasz = "Sikeres rögzítés!";
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    valasz = "Sikertelen rögzítés";
                    Console.ForegroundColor = ConsoleColor.White;
                }
                return valasz;
            }
            catch (Exception ex)
            {
                string hibauz = "Hiba a kapcsolat létrehozásakor: " + ex.Message;
                return hibauz;
            }
        }

        public string KapcsolatMod(int modid, string nev, string cim, string email, string telefon)
        {
            MySqlConnection conn = new MySqlConnection();
            string connstring = "SERVER = localhost;DATABASE=egyenivallalkozas;UID=root;PASSWORD=;";
            conn.ConnectionString = connstring;
            try
            {
                conn.Open();
                string sql = "UPDATE `kapcsolatok` SET `Nev`='@nev',`Cim`='@cim',`Email`='@email',`Telefon`='@telefon' WHERE Azon = @modid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@modid", modid);
                cmd.Parameters.AddWithValue("@nev", nev);
                cmd.Parameters.AddWithValue("@cim", cim);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefon", telefon);
                int sorokSzama = cmd.ExecuteNonQuery();
                conn.Close();
                string valasz = "";
                if (sorokSzama > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    valasz = "Sikeres rögzítés!";
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    valasz = "Sikertelen rögzítés";
                    Console.ForegroundColor = ConsoleColor.White;
                }
                return valasz;
            }
            catch (Exception ex)
            {
                string hibauz = "Hiba a kapcsolat létrehozásakor: " + ex.Message;
                return hibauz;
            }
        }

        public string KapcsolatTorl(int torlid)
        {
            MySqlConnection conn = new MySqlConnection();
            string connstring = "SERVER = localhost;DATABASE=egyenivallalkozas;UID=root;PASSWORD=;";
            conn.ConnectionString = connstring;
            try
            {
                conn.Open();
                string sql = "DELETE FROM `kapcsolatok` WHERE Azon = @torlid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@torlid", torlid);
                int sorokSzama = cmd.ExecuteNonQuery();
                conn.Close();
                string valasz = "";
                if (sorokSzama > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    valasz = "Sikeres rögzítés!";
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    valasz = "Sikertelen rögzítés";
                    Console.ForegroundColor = ConsoleColor.White;
                }
                return valasz;
            }
            catch (Exception ex)
            {
                string hibauz = "Hiba a kapcsolat létrehozásakor: " + ex.Message;
                return hibauz;
            }
        }
    }
}
