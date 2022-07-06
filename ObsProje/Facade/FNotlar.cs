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
   public class FNotlar
    {
        public static int Ekleme(ENotlar veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("NotEkle", Baglanti.con);
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("Ders_Id", veri.Ders_Id);
                komut.Parameters.AddWithValue("OgrenciNo", veri.OgrenciNo);
                komut.Parameters.AddWithValue("Vize", veri.Vize);
                komut.Parameters.AddWithValue("Final", veri.Final);
                komut.Parameters.AddWithValue("Ortalama", veri.Ortalama);
                komut.Parameters.AddWithValue("Durum", veri.Durum);

                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }
        public static List<ENotlar> Listele()
        {
            List<ENotlar> itemlist = null;
            SqlCommand con = new SqlCommand("NotListele", Baglanti.con);
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
                    itemlist = new List<ENotlar>();
                    while (rdr.Read())
                    {
                        ENotlar item = new ENotlar();
                        item.Not_Id = Convert.ToInt32(rdr["Not_Id"]);
                        item.Ders_Id = Convert.ToInt32(rdr["Ders_Id"]);
                        item.OgrenciNo = Convert.ToInt32(rdr["OgrenciNo"]);
                        item.Vize= Convert.ToInt32(rdr["Vize"]);
                        item.Final = Convert.ToInt32(rdr["Final"]);
                        item.Ortalama = Convert.ToInt32(rdr["Ortalama"]);
                        item.Durum = rdr["Durum"].ToString();
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
        public static bool Guncelle(ENotlar islem)
        {
            SqlCommand komut = new SqlCommand("NotGuncelle", DigerBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@Not_Id", islem.Not_Id);
            komut.Parameters.AddWithValue("@Ders_Id", islem.Ders_Id);
            komut.Parameters.AddWithValue("@OgrenciNo", islem.OgrenciNo);
            komut.Parameters.AddWithValue("@Vize", islem.Vize);
            komut.Parameters.AddWithValue("@Final", islem.Final);
            komut.Parameters.AddWithValue("@Ortalama", islem.Ortalama);
            komut.Parameters.AddWithValue("@Durum", islem.Durum);
            return DigerBaglanti.ExecuteNonQuery(komut);
        }
        public static bool Sil(ENotlar islem)
        {
            SqlCommand komut = new SqlCommand("NotSil", DigerBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Not_Id", islem.Not_Id);
            return DigerBaglanti.ExecuteNonQuery(komut);
        }
    }
}
