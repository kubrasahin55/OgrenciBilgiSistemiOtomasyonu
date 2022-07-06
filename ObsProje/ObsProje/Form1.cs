using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ObsProje
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server =.;Database=ObsSistemi;Integrated Security=true");
       
        
        private void button2_Click(object sender, EventArgs e)
        { 

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "KullaniciGiris";
            komut.Parameters.AddWithValue("KullaniciAdi", textBox1.Text);
            komut.Parameters.AddWithValue("Sifre", textBox2.Text);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Başarılı Giriş");
                Anasayfa git = new Anasayfa();
                git.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                textBox1.Clear();
                textBox2.Clear();
            }
            baglanti.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" && textBox3.Text == "" && textBox6.Text == "" && maskedTextBox1.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız");
            }
            else
            {
                MessageBox.Show("Üyeliğiniz oluşturuldu.Giriş yapınız.");
                groupBox2.Visible = false;
            }
            // veri ekleme komutu

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "KullaniciEkle";//prosedürün adı her defasında bak doğru mu
            baglanti.Open();
            komut.Parameters.AddWithValue("KullaniciAdi", textBox4.Text);// addwithvalue:değeriyle beraber ekle  demek
            komut.Parameters.AddWithValue("Sifre", textBox3.Text); //yas,maas,adres bunlar sql tablomdaki kolonlarla aynı adda olmalı
            komut.Parameters.AddWithValue("Mail", textBox6.Text); //prosedürdeki alanlar ""
            komut.Parameters.AddWithValue("Telefon", maskedTextBox1.Text);
            komut.ExecuteNonQuery();//kaydet
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
    }
    }

