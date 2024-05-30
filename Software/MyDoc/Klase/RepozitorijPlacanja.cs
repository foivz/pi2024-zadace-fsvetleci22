using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoc.Klase
{
    internal class RepozitorijPlacanja
    {
        public static List<Placanje> IspisPlacanja()
        {
            List<Placanje> placanja = new List<Placanje>();
            string sql = "SELECT p.idPlaćanja, k.imeIPrezime AS nazivKorisnika, u.nazivUsluge, p.cijena, p.datumPlaćanja, p.opisPlaćanja FROM Placanja p JOIN Korisnik k ON p.nazivKorisnika = k.idKorisnika JOIN Usluga u ON p.nazivUsluge = u.idUsluge;";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Placanje placanje = CreateObject(reader);
                placanja.Add(placanje);
            }
            reader.Close();
            DB.CloseConnection();
            return placanja;
        }
        private static Placanje CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["idPlaćanja"].ToString());
            string korisnik = reader["nazivKorisnika"].ToString();
            string usluga = reader["nazivUsluge"].ToString();
            float cijenaUsluge = float.Parse(reader["cijena"].ToString());
            string datum = reader["datumPlaćanja"].ToString();
            string opis = reader["opisPlaćanja"].ToString();

            var placanje = new Placanje
            {
                idPlacanja = id,
                nazivKorisnika = korisnik,
                nazivUsluge = usluga,
                cijena = cijenaUsluge,
                datumPlacanja = datum,
                opisPlacanja = opis
            };
            return placanje;
        }
    }
}
