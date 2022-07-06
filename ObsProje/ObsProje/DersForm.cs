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
    public partial class DersForm : Form
    {
        public DersForm()
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
            List<EDersler> DersListele = BLDersler.Listele();
            dataGridView1.DataSource = DersListele;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EDersler ekleme = new EDersler();
            ekleme.DersAdi = textBox1.Text;
            ekleme.Ogretmen_Id = Convert.ToInt32(textBox2.Text);
            if (BLDersler.Ekleme(ekleme) > 0)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EDersler k = new EDersler();
            k.DersAdi = textBox1.Text;
            k.Ders_Id = (int)textBox1.Tag;
            k.Ogretmen_Id = Convert.ToInt32(textBox2.Text);
            if (FDersler.Guncelle(k))
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
            EDersler k = new EDersler();
            k.Ders_Id = (int)dataGridView1.CurrentRow.Cells["Ders_Id"].Value;
            if (!FDersler.Sil(k))
                MessageBox.Show("Silinemedi");
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Text = row.Cells["DersAdi"].Value.ToString();
            textBox1.Tag = row.Cells["Ders_Id"].Value;
            textBox2.Text = row.Cells["Ogretmen_Id"].Value.ToString();
        }
    }
}
