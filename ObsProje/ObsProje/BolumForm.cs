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
    public partial class BolumForm : Form
    {
        public BolumForm()
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
            List<EBolumler> BolumListele= BLBolumler.Listele();
            dataGridView1.DataSource = BolumListele;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EBolumler ekleme = new EBolumler();
            ekleme.BolumAdi = textBox1.Text;
            ekleme.OgrenciSayisi = Convert.ToInt32(textBox2.Text);
            if (BLBolumler.Ekleme(ekleme) > 0) 
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
            EBolumler k = new EBolumler();
            k.BolumAdi = textBox1.Text;
            k.Bolum_Id = (int)textBox1.Tag;
            k.OgrenciSayisi = Convert.ToInt32(textBox2.Text);
            if (FBolumler.Guncelle(k))
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
            EBolumler k = new EBolumler();
            k.Bolum_Id = (int)dataGridView1.CurrentRow.Cells["Bolum_Id"].Value;
            if (!FBolumler.Sil(k)) 
                MessageBox.Show("Silinemedi");
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Text = row.Cells["BolumAdi"].Value.ToString();
            textBox1.Tag = row.Cells["Bolum_Id"].Value;
            textBox2.Text = row.Cells["OgrenciSayisi"].Value.ToString();
        }
    }
}
