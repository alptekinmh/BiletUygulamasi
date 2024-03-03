using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab2
{
    public partial class FirmaPanel : Form
    {
        public FirmaPanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8PEQEU7\\SQLEXPRESS03;Initial Catalog=prolab2;Integrated Security=True");

        private void Goster()
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Araclar", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AracNo"].ToString();
                ekle.SubItems.Add(oku["KoltukSayisi"].ToString());
                ekle.SubItems.Add(oku["SeferNo"].ToString());
                ekle.SubItems.Add(oku["FirmaAdi"].ToString());
                ekle.SubItems.Add(oku["UlasimSekli"].ToString());
                ekle.SubItems.Add(oku["id"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void AracEkle(string aracNo, int koltukSayisi, int seferNo, string firmaAdi, string ulasimSekli, int id)
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Araclar                                                                                                                                                     (AracNo, KoltukSayisi, SeferNo, FirmaAdi, UlasimSekli,id) VALUES (@AracNo, @KoltukSayisi, @SeferNo, @FirmaAdi, @UlasimSekli,@id)", baglanti);
            cmd.Parameters.AddWithValue("@AracNo", aracNo);
            cmd.Parameters.AddWithValue("@KoltukSayisi", koltukSayisi);
            cmd.Parameters.AddWithValue("@SeferNo", seferNo);
            cmd.Parameters.AddWithValue("@FirmaAdi", firmaAdi);
            cmd.Parameters.AddWithValue("@UlasimSekli", ulasimSekli);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            baglanti.Close();
        }



        private void FirmaPanel_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Goster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aracNo = textBox2.Text;
            int koltukSayisi = 0;
            int seferNo = 0;
            string firmaAdi = textBox5.Text;
            string ulasimSekli = textBox6.Text;
            int id = 0;

            int.TryParse(textBox3.Text, out koltukSayisi);
            int.TryParse(textBox4.Text, out seferNo);
            int.TryParse(textBox7.Text, out id);

            AracEkle(aracNo, koltukSayisi, seferNo, firmaAdi, ulasimSekli, id);
            Goster();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                string seciliID = textBox1.Text;

                string baglantiyolu = "Data Source=DESKTOP-8PEQEU7\\SQLEXPRESS03;Initial Catalog=prolab2;Integrated Security=True";

                using (SqlConnection baglanti = new SqlConnection(baglantiyolu))
                {
                    baglanti.Open();
                    string komut = "DELETE FROM Araclar WHERE id = @id";
                    SqlCommand command = new SqlCommand(komut, baglanti);
                    command.Parameters.AddWithValue("@id", seciliID);

                    int etkilenenSatirSayisi = command.ExecuteNonQuery();

                    if (etkilenenSatirSayisi > 0)
                    {
                        Console.WriteLine("Satır başarıyla silindi.");
                    }
                    else
                    {
                        Console.WriteLine("Silinecek satır bulunamadı veya silinemedi.");
                    }
                }

                Goster();
            }
            else
            {
                Console.WriteLine("Id giriniz!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
