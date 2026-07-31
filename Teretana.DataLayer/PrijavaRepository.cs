using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Teretana.DataLayer
{
    public class PrijavaRepository
    {
        // Prijava člana na trening
        public void DodajPrijavu(Prijava prijava)
        {
            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = @"INSERT INTO Prijava (IdClana, IdTreninga, DatumPrijave, Status)
                                  VALUES (@IdClana, @IdTreninga, @DatumPrijave, @Status)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdClana", prijava.IdClana);
                cmd.Parameters.AddWithValue("@IdTreninga", prijava.IdTreninga);
                cmd.Parameters.AddWithValue("@DatumPrijave", DateTime.Now);
                cmd.Parameters.AddWithValue("@Status", "prijavljen");

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Otkazivanje prijave (menja status, ne briše red - čuva istoriju)
        public void OtkaziPrijavu(int idPrijave)
        {
            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = "UPDATE Prijava SET Status = 'otkazano' WHERE IdPrijave = @IdPrijave";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdPrijave", idPrijave);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Provera da li je član već prijavljen na taj trening
        public bool VecPrijavljen(int idClana, int idTreninga)
        {
            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = @"SELECT COUNT(*) FROM Prijava
                                  WHERE IdClana = @IdClana AND IdTreninga = @IdTreninga AND Status = 'prijavljen'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdClana", idClana);
                cmd.Parameters.AddWithValue("@IdTreninga", idTreninga);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // Sve prijave jednog člana (za "Moji treninzi" ekran) - sa podacima o treningu
        public List<PrijavaSaTreningom> VratiPrijaveClana(int idClana)
        {
            List<PrijavaSaTreningom> lista = new List<PrijavaSaTreningom>();

            using (SqlConnection conn = ConnectionHelper.GetConnection())
            {
                string query = @"SELECT p.IdPrijave, p.DatumPrijave, p.Status,
                                         t.IdTreninga, t.Naziv, t.Trener, t.TipTreninga, t.DatumTermina
                                  FROM Prijava p
                                  JOIN Trening t ON p.IdTreninga = t.IdTreninga
                                  WHERE p.IdClana = @IdClana
                                  ORDER BY t.DatumTermina";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdClana", idClana);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new PrijavaSaTreningom
                    {
                        IdPrijave = (int)reader["IdPrijave"],
                        DatumPrijave = (DateTime)reader["DatumPrijave"],
                        Status = reader["Status"].ToString(),
                        IdTreninga = (int)reader["IdTreninga"],
                        NazivTreninga = reader["Naziv"].ToString(),
                        Trener = reader["Trener"].ToString(),
                        TipTreninga = reader["TipTreninga"].ToString(),
                        DatumTermina = (DateTime)reader["DatumTermina"]
                    });
                }
            }
            return lista;
        }
    }

    // Pomoćna klasa - spaja podatke o prijavi i treningu za prikaz u tabeli/listi
    public class PrijavaSaTreningom
    {
        public int IdPrijave { get; set; }
        public DateTime DatumPrijave { get; set; }
        public string Status { get; set; }
        public int IdTreninga { get; set; }
        public string NazivTreninga { get; set; }
        public string Trener { get; set; }
        public string TipTreninga { get; set; }
        public DateTime DatumTermina { get; set; }
    }
}
