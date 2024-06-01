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
            string sql = "SELECT * FROM Placanja";
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

        public static List <Placanje> Pretrazivanje(string tekst)
        {
            List <Placanje> placanja = new List<Placanje>();
            string sql = $"SELECT * FROM Placanja WHERE nazivKorisnika = '{tekst}'";
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


        public static void DodajUBazu(Placanje placanje)
        {
            string sql = $"INSERT INTO Placanja (nazivKorisnika, nazivUsluge, cijena, datumPlaćanja, opisPlaćanja) VALUES ('{placanje.nazivKorisnika}', '{placanje.nazivUsluge}', {placanje.cijena},'{placanje.datumPlacanja}','{placanje.opisPlacanja}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void IzbrisiIzBaze(Placanje placanje)
        {
            string sql = $"DELETE FROM Placanja WHERE idPlaćanja = {placanje.idPlacanja}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void AzurirajPodatkeUBazi(Placanje placanje)
        {
            string sql = $"UPDATE Placanja SET nazivKorisnika = '{placanje.nazivKorisnika}', nazivUsluge = '{placanje.nazivUsluge}', cijena = {placanje.cijena}, datumPlaćanja = '{placanje.datumPlacanja}', opisPlaćanja = '{placanje.opisPlacanja}' WHERE idPlaćanja = {placanje.idPlacanja}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        

    }
}


