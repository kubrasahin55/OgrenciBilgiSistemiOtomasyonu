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
 public class FOgrenciler
    {
        public static int Ekleme(EOgrenciler veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("OgrenciEkle", Baglanti.con);
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("OgrenciAdi", veri.OgrenciAdi);
                komut.Parameters.AddWithValue("OgrenciSoyadi", veri.OgrenciSoyadi);
                komut.Parameters.AddWithValue("Bolum_Id", veri.Bolum_Id);
                islem = komut.ExecuteNonQuery();

                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }
        public static List<EOgrenciler> Listele()
        {
            List<EOgrenciler> itemlist = null;
            SqlCommand con = new SqlCommand("OgrenciListele", Baglanti.con);
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
                    itemlist = new List<EOgrenciler>();
                    while (rdr.Read())
                    {
                        EOgrenciler item = new EOgrenciler();
                        item.OgrenciNo = Convert.ToInt32(rdr["OgrenciNo"]);
                        item.OgrenciAdi = rdr["OgrenciAdi"].ToString();
                        item.OgrenciSoyadi = rdr["OgrenciSoyadi"].ToString();
                        item.Bolum_Id = Convert.ToInt32(rdr["Bolum_Id"]);
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
        public static bool Guncelle(EOgrenciler islem)
        {
            SqlCommand komut = new SqlCommand("OgrenciGuncelle", DigerBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@OgrenciNo", islem.OgrenciNo);
            komut.Parameters.AddWithValue("@OgrenciAdi", islem.OgrenciAdi);
            komut.Parameters.AddWithValue("@OgrenciSoyadi", islem.OgrenciSoyadi);
            komut.Parameters.AddWithValue("@Bolum_Id", islem.Bolum_Id);
            return DigerBaglanti.ExecuteNonQuery(komut);
        }
        public static bool Sil(EOgrenciler islem)
        {
            SqlCommand komut = new SqlCommand("OgrenciSil", DigerBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@OgrenciNo", islem.OgrenciNo);
            return DigerBaglanti.ExecuteNonQuery(komut);
        }


    }
}
