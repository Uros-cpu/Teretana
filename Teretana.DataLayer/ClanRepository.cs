using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Teretana.DataLayer
{
    public class ClanRepository
    {
        // Registracija novog člana
        public void DodajClana(Clan clan)
        {
            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = @"INSERT INTO Clan (Ime, Prezime, Email, Telefon, KorisnickoIme, Lozinka, TipClanarine)
                                  VALUES (@Ime, @Prezime, @Email, @Telefon, @KorisnickoIme, @Lozinka, @TipClanarine)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ime", clan.Ime);
                cmd.Parameters.AddWithValue("@Prezime", clan.Prezime);
                cmd.Parameters.AddWithValue("@Email", clan.Email);
                cmd.Parameters.AddWithValue("@Telefon", (object)clan.Telefon ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@KorisnickoIme", clan.KorisnickoIme);
                cmd.Parameters.AddWithValue("@Lozinka", clan.Lozinka);
                cmd.Parameters.AddWithValue("@TipClanarine", clan.TipClanarine);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Login - provera korisničkog imena i lozinke
        public Clan Login(string korisnickoIme, string lozinka)
        {
            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = @"SELECT * FROM Clan WHERE KorisnickoIme = @KorisnickoIme AND Lozinka = @Lozinka";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KorisnickoIme", korisnickoIme);
                cmd.Parameters.AddWithValue("@Lozinka", lozinka);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return MapClan(reader);
                }
                return null; // nije pronađen - pogrešan login
            }
        }

        // Provera da li korisničko ime već postoji (za registraciju)
        public bool KorisnickoImePostoji(string korisnickoIme)
        {
            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = @"SELECT COUNT(*) FROM Clan WHERE KorisnickoIme = @KorisnickoIme";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KorisnickoIme", korisnickoIme);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // Vraća sve članove (npr. za admin pregled)
        public List<Clan> VratiSveClanove()
        {
            List<Clan> clanovi = new List<Clan>();

            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = "SELECT * FROM Clan";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    clanovi.Add(MapClan(reader));
                }
            }
            return clanovi;
        }

        // Pomoćna metoda - pretvara red iz baze u Clan objekat
        private Clan MapClan(SqlDataReader reader)
        {
            return new Clan
            {
                IdClana = (int)reader["IdClana"],
                Ime = reader["Ime"].ToString(),
                Prezime = reader["Prezime"].ToString(),
                Email = reader["Email"].ToString(),
                Telefon = reader["Telefon"] == DBNull.Value ? null : reader["Telefon"].ToString(),
                KorisnickoIme = reader["KorisnickoIme"].ToString(),
                Lozinka = reader["Lozinka"].ToString(),
                TipClanarine = reader["TipClanarine"].ToString()
            };
        }
    }
}