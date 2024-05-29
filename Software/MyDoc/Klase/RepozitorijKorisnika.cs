using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace MyDoc.Klase
{
    internal class RepozitorijKorisnika
    {
        public static List<Korisnik> IspisKorisnika()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            string sql = "SELECT * FROM Korisnik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Korisnik korisnik = CreateObject(reader);
                korisnici.Add(korisnik);
            }
            reader.Close();
            DB.CloseConnection();
            return korisnici;
        }
        private static Korisnik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["idKorisnika"].ToString());
            string imeIPrezime = reader["imeIPrezime"].ToString();
            string eMail = reader["E-mail"].ToString();
            string statusStudenta = reader["statusStudenta"].ToString();
            float saldo = float.Parse(reader["saldo"].ToString());

            var korisnik = new Korisnik
            {
                idKorisnika = id,
                imePrezime = imeIPrezime,
                eMail = eMail,
                statusStudenta = statusStudenta,
                saldo = saldo
            };
            return korisnik;
        }
    }
}
