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
  public class FBolumler
    {
        public static int Ekleme(EBolumler veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("BolumEkle", Baglanti.con); //diğer bağlantı yazsaydık aşağıdaki kodlaı yazmamıza gerek yoktu.
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("BolumAdi", veri.BolumAdi);
                komut.Parameters.AddWithValue("OgrenciSayisi", veri.OgrenciSayisi);
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }
        public static List<EBolumler> Listele()
        {
            List<EBolumler> itemlist = null;
            SqlCommand con = new SqlCommand("BolumListele", Baglanti.con);
            try
            {

                con.CommandType = CommandType.StoredProcedure;
                if (con.Connection.State != ConnectionState.Open)
                {
                    con.Connection.Open();
                }
                SqlDataReader rdr = con.ExecuteReader();

                //Datatablereader ve SqlDataReader Nesnelerinin HasRows propertiesinin data olması durumunda true bir değer. eğer data yoksa false değer döndürmeisidir.
                //işlem yaparken if ile dönen değeri kontrol ettiririz.True ise veriyi tabloya basabiliriz.False ise veri olmadığı için tabloya data yollayamayiz.

                if (rdr.HasRows)
                {
                    itemlist = new List<EBolumler>();
                    while (rdr.Read())
                    {
                        EBolumler item = new EBolumler();
                        item.Bolum_Id = Convert.ToInt32(rdr["Bolum_Id"]);
                        item.BolumAdi = rdr["BolumAdi"].ToString();
                        item.OgrenciSayisi = Convert.ToInt32(rdr["OgrenciSayisi"]);
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
        public static bool Guncelle(EBolumler islem)
        {
            SqlCommand komut = new SqlCommand("BolumGuncelle", DigerBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@BolumAdi", islem.BolumAdi);
            komut.Parameters.AddWithValue("@Bolum_Id", islem.Bolum_Id);
            komut.Parameters.AddWithValue("@OgrenciSayisi", islem.OgrenciSayisi);
            return DigerBaglanti.ExecuteNonQuery(komut);
        }
        public static bool Sil(EBolumler islem)
        {
            SqlCommand komut = new SqlCommand("BolumSil", DigerBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Bolum_Id", islem.Bolum_Id);
            return DigerBaglanti.ExecuteNonQuery(komut);
        }
    }
}
