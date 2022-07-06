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
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
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
            List<EOgrenciler> OgrenciListele = BLOgrenciler.Listele();
            dataGridView1.DataSource = OgrenciListele;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EOgrenciler k = new EOgrenciler();
            k.OgrenciAdi = textBox1.Text;
            k.OgrenciNo = (int)textBox1.Tag;
            k.OgrenciSoyadi = textBox2.Text;
            k.Bolum_Id= Convert.ToInt32( textBox3.Text);

            if (FOgrenciler.Guncelle(k))
            {
                MessageBox.Show("Güncellendi");

            }
            else
            {
                MessageBox.Show("Güncellenemedi");
            }
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EOgrenciler ekleme = new EOgrenciler();
            ekleme.OgrenciAdi = textBox1.Text;
            ekleme.OgrenciSoyadi = textBox2.Text;
            ekleme.Bolum_Id = Convert.ToInt32(textBox3.Text);
            if (BLOgrenciler.Ekleme(ekleme) > 0)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            Liste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            EOgrenciler k = new EOgrenciler();
            k.OgrenciNo = (int)dataGridView1.CurrentRow.Cells["OgrenciNo"].Value;
            if (!FOgrenciler.Sil(k))
                MessageBox.Show("Silinemedi");
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Text = row.Cells["OgrenciAdi"].Value.ToString();
            textBox1.Tag = row.Cells["OgrenciNo"].Value;
            textBox2.Text = row.Cells["OgrenciSoyadi"].Value.ToString();
            textBox3.Text = row.Cells["Bolum_Id"].Value.ToString();

        }
    }
}
