using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProLab2
{
    public partial class FirmaGiris : Form
    {


        public FirmaGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8PEQEU7\\SQLEXPRESS03;Initial Catalog=prolab2;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string girilenKullaniciAdi = textBox1.Text;
            string girilenSifre = textBox2.Text;
            baglanti.Open();
            string adres = "SELECT FirmaAdi, Sifre FROM FirmaGiris WHERE FirmaAdi=@FirmaAdi AND Sifre=@Sifre";
            SqlCommand komut = new SqlCommand(adres, baglanti);
            komut.Parameters.AddWithValue("@FirmaAdi", girilenKullaniciAdi);
            komut.Parameters.AddWithValue("@Sifre", girilenSifre);

            SqlDataReader okuyucu = komut.ExecuteReader();

            if (okuyucu.Read())
            {
                string dogruad = okuyucu["FirmaAdi"].ToString();
                string dogrusifre = okuyucu["Sifre"].ToString();

                FirmaPanel fr = new FirmaPanel();
                fr.Show();
                this.Hide();
            }
            else
            {
                Console.WriteLine("Hatalı Giriş!!");
            }

            baglanti.Close();

        }

        private void FirmaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}



