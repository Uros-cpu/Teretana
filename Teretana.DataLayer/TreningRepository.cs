using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Teretana.DataLayer
{
    public class TreningRepository
    {
        // Vraća sve treninge
        public List<Trening> VratiSveTreninge()
        {
            List<Trening> treninzi = new List<Trening>();

            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = "SELECT * FROM Trening ORDER BY IdTreninga";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    treninzi.Add(MapTrening(reader));
                }
            }
            return treninzi;
        }

        // Vraća jedan trening po Id-u
        public Trening VratiTreningPoId(int idTreninga)
        {
            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = "SELECT * FROM Trening WHERE IdTreninga = @IdTreninga";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdTreninga", idTreninga);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return MapTrening(reader);
                }
                return null;
            }
        }

        // Dodaje novi trening (admin/trener funkcionalnost)
        public void DodajTrening(Trening trening)
        {
            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = @"INSERT INTO Trening (Naziv, Trener, TipTreninga, Trajanje, MaxBrojUcesnika, DatumTermina)
                                  VALUES (@Naziv, @Trener, @TipTreninga, @Trajanje, @MaxBrojUcesnika, @DatumTermina)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Naziv", trening.Naziv);
                cmd.Parameters.AddWithValue("@Trener", trening.Trener);
                cmd.Parameters.AddWithValue("@TipTreninga", trening.TipTreninga);
                cmd.Parameters.AddWithValue("@Trajanje", trening.Trajanje);
                cmd.Parameters.AddWithValue("@MaxBrojUcesnika", trening.MaxBrojUcesnika);
                cmd.Parameters.AddWithValue("@DatumTermina", trening.DatumTermina);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Izmena postojećeg treninga
        public void IzmeniTrening(Trening trening)
        {
            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = @"UPDATE Trening SET Naziv = @Naziv, Trener = @Trener, TipTreninga = @TipTreninga,
                                  Trajanje = @Trajanje, MaxBrojUcesnika = @MaxBrojUcesnika, DatumTermina = @DatumTermina
                                  WHERE IdTreninga = @IdTreninga";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Naziv", trening.Naziv);
                cmd.Parameters.AddWithValue("@Trener", trening.Trener);
                cmd.Parameters.AddWithValue("@TipTreninga", trening.TipTreninga);
                cmd.Parameters.AddWithValue("@Trajanje", trening.Trajanje);
                cmd.Parameters.AddWithValue("@MaxBrojUcesnika", trening.MaxBrojUcesnika);
                cmd.Parameters.AddWithValue("@DatumTermina", trening.DatumTermina);
                cmd.Parameters.AddWithValue("@IdTreninga", trening.IdTreninga);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Brisanje treninga
        public void ObrisiTrening(int idTreninga)
        {
            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = "DELETE FROM Trening WHERE IdTreninga = @IdTreninga";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdTreninga", idTreninga);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Broj trenutno prijavljenih na trening (za proveru popunjenosti)
        public int BrojPrijavljenih(int idTreninga)
        {
            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = @"SELECT COUNT(*) FROM Prijava
                                  WHERE IdTreninga = @IdTreninga AND Status = 'prijavljen'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdTreninga", idTreninga);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private Trening MapTrening(SqlDataReader reader)
        {
            return new Trening
            {
                IdTreninga = (int)reader["IdTreninga"],
                Naziv = reader["Naziv"].ToString(),
                Trener = reader["Trener"].ToString(),
                TipTreninga = reader["TipTreninga"].ToString(),
                Trajanje = (int)reader["Trajanje"],
                MaxBrojUcesnika = (int)reader["MaxBrojUcesnika"],
                DatumTermina = (DateTime)reader["DatumTermina"]
            };
        }
    }
}
