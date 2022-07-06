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
    public class FOgretmenler
    {
        public static int Ekleme(EOgretmenler veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("OgretmenEkle", Baglanti.con);
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("OgretmenAdi", veri.OgretmenAdi);
                komut.Parameters.AddWithValue("OgretmenSoyadi", veri.OgretmenSoyadi);
                komut.Parameters.AddWithValue("OgretmenBrans", veri.OgretmenBrans);
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }
        public static List<EOgretmenler> Listele()
        {
            List<EOgretmenler> itemlist = null;
            SqlCommand con = new SqlCommand("OgretmenListele", Baglanti.con);
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
                    itemlist = new List<EOgretmenler>();
                    while (rdr.Read())
                    {
                        EOgretmenler item = new EOgretmenler();
                        item.Ogretmen_Id = Convert.ToInt32(rdr["Ogretmen_Id"]);
                        item.OgretmenAdi = rdr["OgretmenAdi"].ToString();
                        item.OgretmenSoyadi = rdr["OgretmenSoyadi"].ToString();
                        item.OgretmenBrans = rdr["OgretmenBrans"].ToString();
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
        public static bool Guncelle(EOgretmenler islem)
        {
            SqlCommand komut = new SqlCommand("OgretmenGuncelle", DigerBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@Ogretmen_Id", islem.Ogretmen_Id);
            komut.Parameters.AddWithValue("@OgretmenAdi", islem.OgretmenAdi);
            komut.Parameters.AddWithValue("@OgretmenSoyadi", islem.OgretmenSoyadi);
            komut.Parameters.AddWithValue("@OgretmenBrans", islem.OgretmenBrans);
            return DigerBaglanti.ExecuteNonQuery(komut);
        }
        public static bool Sil(EOgretmenler islem)
        {
            SqlCommand komut = new SqlCommand("OgretmenSil", DigerBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Ogretmen_Id", islem.Ogretmen_Id);
            return DigerBaglanti.ExecuteNonQuery(komut);
        }
    }


    } 


    

