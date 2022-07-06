using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Facade;
using BusinessLayer;

namespace ObsProje
{
    public partial class OgretmenForm : Form
    {
        public OgretmenForm()
        {
            InitializeComponent();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa git = new Anasayfa();
            git.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Liste()
        {
            List<EOgretmenler> OgretmenListele = BLOgretmenler.Listele();
            dataGridView1.DataSource = OgretmenListele;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            EOgretmenler k = new EOgretmenler();
            k.OgretmenAdi = textBox1.Text;
            k.Ogretmen_Id = (int)textBox1.Tag;
            k.OgretmenSoyadi = textBox2.Text;
            k.OgretmenBrans = textBox3.Text;

            if (FOgretmenler.Guncelle(k))
            {
                MessageBox.Show("Güncellendi");

            }
            else
            {
                MessageBox.Show("Güncellenemedi");
            }
            Liste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            EOgretmenler k = new EOgretmenler();
            k.Ogretmen_Id = (int)dataGridView1.CurrentRow.Cells["Ogretmen_Id"].Value;
            if (!FOgretmenler.Sil(k))
                MessageBox.Show("Silinemedi");
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Text = row.Cells["OgretmenAdi"].Value.ToString();
            textBox1.Tag = row.Cells["Ogretmen_Id"].Value;
            textBox2.Text = row.Cells["OgretmenSoyadi"].Value.ToString();
            textBox3.Text = row.Cells["OgretmenBrans"].Value.ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EOgretmenler ekleme = new EOgretmenler();
            ekleme.OgretmenAdi = textBox1.Text;
            ekleme.OgretmenSoyadi = textBox2.Text;
            ekleme.OgretmenBrans = textBox3.Text;
            if (BLOgretmenler.Ekleme(ekleme) > 0)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            Liste();
        }
    }
}
