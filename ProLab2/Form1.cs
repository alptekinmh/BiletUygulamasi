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
using System.Security.AccessControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProLab2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8PEQEU7\\SQLEXPRESS03;Initial Catalog=prolab2;Integrated Security=True");

        private void FirmaGoster()
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from FirmaBilgileri", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Firmaid"].ToString();
                ekle.SubItems.Add(oku["Firmaisim"].ToString());
                ekle.SubItems.Add(oku["AracSayisi"].ToString());
                ekle.SubItems.Add(oku["UlasimYolu"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void FirmaEkle(int Firmaid, string Firmaisim, int AracSayisi, string UlasimYolu)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO FirmaBilgileri (Firmaid, Firmaisim, AracSayisi, UlasimYolu) VALUES (@Firmaid, @Firmaisim, @AracSayisi, @UlasimYolu)", baglanti);
            cmd.Parameters.AddWithValue("@Firmaid", Firmaid);
            cmd.Parameters.AddWithValue("@Firmaisim", Firmaisim);
            cmd.Parameters.AddWithValue("@AracSayisi", AracSayisi);
            cmd.Parameters.AddWithValue("@UlasimYolu", UlasimYolu);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            FirmaGoster();
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {



        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                string seciliID = textBox3.Text;

                string baglantiyolu = "Data Source=DESKTOP-8PEQEU7\\SQLEXPRESS03;Initial Catalog=prolab2;Integrated Security=True";

                using (SqlConnection baglanti = new SqlConnection(baglantiyolu))
                {
                    baglanti.Open();
                    string komut = "DELETE FROM FirmaBilgileri WHERE Firmaid = @id";
                    SqlCommand command = new SqlCommand(komut, baglanti);
                    command.Parameters.AddWithValue("@id", seciliID);

                    int etkilenenSatirSayisi = command.ExecuteNonQuery();

                    if (etkilenenSatirSayisi > 0)
                    {
                        Console.WriteLine("Satýr baþarýyla silindi.");
                    }
                    else
                    {
                        Console.WriteLine("Silinecek satýr bulunamadý veya silinemedi.");
                    }
                }

                FirmaGoster();
            }
            else
            {
                Console.WriteLine("Id giriniz!!");
            }
        }
        private void HizmetBedeliGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand goster = new SqlCommand("select * from KarZarar ", baglanti);
            SqlDataReader reader = goster.ExecuteReader();
            while (reader.Read())
            {

                ListViewItem item = new ListViewItem();
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add(reader["Gunlukucret"].ToString());
                listView1.Items.Add(item);
            }
            baglanti.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int Firmaid = 0;
            string Firmaisim = textBox1.Text;
            int AracSayisi = 0;
            string UlasimYolu = textBox5.Text;

            int.TryParse(textBox2.Text, out Firmaid);
            int.TryParse(textBox4.Text, out AracSayisi);

            FirmaEkle(Firmaid, Firmaisim, AracSayisi, UlasimYolu);
            FirmaGoster();
        }
    }
}