using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Facade
{
   public class FDersler
    {
        public static int Ekleme(EDersler veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("DersEkle", Baglanti.con); 
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("DersAdi", veri.DersAdi);
                komut.Parameters.AddWithValue("Ogretmen_Id", veri.Ogretmen_Id);
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }
        public static List<EDersler> Listele()
        {
            List<EDersler> itemlist = null;
            SqlCommand con = new SqlCommand("DersListele", Baglanti.con);
            try
            {

                con.CommandType = CommandType.StoredProcedure;
                if (con.Connection.State != ConnectionState.Open)
                {
                    con.Connection.Open();
                }
                SqlDataReader rdr = con.ExecuteReader();

                
                if (rdr.HasRows)
                {
                    itemlist = new List<EDersler>();
                    while (rdr.Read())
                    {
                        EDersler item = new EDersler();
                        item.Ders_Id = Convert.ToInt32(rdr["Ders_Id"]);
                        item.DersAdi = rdr["DersAdi"].ToString();
                        item.Ogretmen_Id = Convert.ToInt32(rdr["Ogretmen_Id"]);
                        itemlist.Add(item);
                    }
                }
            }
            catch
            {

                itemlist = null;
            }
            finally
            {
                con.Connection.Close();
            }
            return itemlist;
        }
        public static bool Guncelle(EDersler islem)
        {
            SqlCommand komut = new SqlCommand("DersGuncelle", DigerBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@Ders_Id", islem.Ders_Id);
            komut.Parameters.AddWithValue("@DersAdi", islem.DersAdi);
            komut.Parameters.AddWithValue("@Ogretmen_Id", islem.Ogretmen_Id);
            return DigerBaglanti.ExecuteNonQuery(komut);
        }
        public static bool Sil(EDersler islem)
        {
            SqlCommand komut = new SqlCommand("DersSil", DigerBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Ders_Id", islem.Ders_Id);
            return DigerBaglanti.ExecuteNonQuery(komut);
        }
    }
}
