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
    public partial class NotForm : Form
    {
        public NotForm()
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
            List<ENotlar> NotListele = BLNotlar.Listele();
            dataGridView1.DataSource = NotListele;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ENotlar ekleme = new ENotlar();
            ekleme.Ders_Id = Convert.ToInt32(textBox1.Text);
            ekleme.OgrenciNo = Convert.ToInt32(textBox2.Text);
            ekleme.Vize = Convert.ToInt32(textBox3.Text);
            ekleme.Final = Convert.ToInt32(textBox4.Text);
            ekleme.Ortalama = Convert.ToInt32(textBox5.Text);
            ekleme.Durum = textBox6.Text;
            if (BLNotlar.Ekleme(ekleme) > 0)
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
            ENotlar k = new ENotlar();
            k.Ders_Id = Convert.ToInt32(textBox1.Text);
            k.Not_Id = (int)textBox1.Tag;
            k.OgrenciNo = Convert.ToInt32(textBox2.Text);
            k.Vize = Convert.ToInt32(textBox3.Text);
            k.Final = Convert.ToInt32(textBox4.Text);
            k.Ortalama = Convert.ToInt32(textBox5.Text);
            k.Durum = textBox6.Text;
            if (FNotlar.Guncelle(k))
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
            ENotlar k = new ENotlar();
            k.Not_Id = (int)dataGridView1.CurrentRow.Cells["Not_Id"].Value;
            if (!FNotlar.Sil(k))
                MessageBox.Show("Silinemedi");
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Text = row.Cells["Ders_Id"].Value.ToString();
            textBox1.Tag = row.Cells["Not_Id"].Value;
            textBox2.Text = row.Cells["OgrenciNo"].Value.ToString();
            textBox3.Text = row.Cells["Vize"].Value.ToString();
            textBox4.Text = row.Cells["Final"].Value.ToString();
            textBox5.Text = row.Cells["Ortalama"].Value.ToString();
            textBox6.Text = row.Cells["Durum"].Value.ToString();
        }
    }
}
