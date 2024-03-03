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
    public partial class CUcak1 : Form
    {
        public CUcak1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8PEQEU7\\SQLEXPRESS03;Initial Catalog=prolab2;Integrated Security=True");

        Dictionary<string, Dictionary<string, int>> fiyatlar = new Dictionary<string, Dictionary<string, int>>
{
    { "Istanbul", new Dictionary<string, int> { { "Konya", 1200 }, } },
    { "Konya", new Dictionary<string, int> { { "Istanbul", 1200 } } },
    };




        private void CUcak1_Load(object sender, EventArgs e)
        {
            string a = "", b = "";
            if (Application.OpenForms["UcakYolu1"] is UcakYolu1 ucakYolu1)
            {
                string selectedComboBoxItem1 = ucakYolu1.GetSelectedComboBoxItem();
                string selectedComboBoxItem2 = ucakYolu1.GetSelectedComboBox2Item();
                a = selectedComboBoxItem1;
                b = selectedComboBoxItem2;
            }


            string baslangicSehri = a;

            string varisSehri = b;

            if (fiyatlar.ContainsKey(baslangicSehri) && fiyatlar[baslangicSehri].ContainsKey(varisSehri))
            {
                int ucret = fiyatlar[baslangicSehri][varisSehri];
                CmbxUcret.Text = ucret.ToString();
            }
            else
            {
                Console.WriteLine("Geçersiz şehir girişi!");
            }

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                if (oku1["KoltukNo"].ToString() == "1")
                    button1.Text = oku1["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button1.Text != "1")
            {
                button1.BackColor = Color.Red;
                button1.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                if (oku2["KoltukNo"].ToString() == "2")
                    button2.Text = oku2["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button2.Text != "2")
            {
                button2.BackColor = Color.Red;
                button2.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                if (oku3["KoltukNo"].ToString() == "3")
                    button3.Text = oku3["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button3.Text != "3")
            {
                button3.BackColor = Color.Red;
                button3.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                if (oku4["KoltukNo"].ToString() == "4")
                    button4.Text = oku4["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button4.Text != "4")
            {
                button4.BackColor = Color.Red;
                button4.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                if (oku5["KoltukNo"].ToString() == "5")
                    button5.Text = oku5["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button5.Text != "5")
            {
                button5.BackColor = Color.Red;
                button5.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                if (oku6["KoltukNo"].ToString() == "6")
                    button6.Text = oku6["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button6.Text != "6")
            {
                button6.BackColor = Color.Red;
                button6.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                if (oku7["KoltukNo"].ToString() == "7")
                    button7.Text = oku7["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button7.Text != "7")
            {
                button7.BackColor = Color.Red;
                button7.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                if (oku8["KoltukNo"].ToString() == "8")
                    button8.Text = oku8["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button8.Text != "8")
            {
                button8.BackColor = Color.Red;
                button8.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                if (oku9["KoltukNo"].ToString() == "9")
                    button9.Text = oku9["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button9.Text != "9")
            {
                button9.BackColor = Color.Red;
                button9.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut10 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku10 = komut10.ExecuteReader();
            while (oku10.Read())
            {
                if (oku10["KoltukNo"].ToString() == "10")
                    button10.Text = oku10["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button10.Text != "10")
            {
                button10.BackColor = Color.Red;
                button10.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut11 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku11 = komut11.ExecuteReader();
            while (oku11.Read())
            {
                if (oku11["KoltukNo"].ToString() == "11")
                    button11.Text = oku11["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button11.Text != "11")
            {
                button11.BackColor = Color.Red;
                button11.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut12 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku12 = komut12.ExecuteReader();
            while (oku12.Read())
            {
                if (oku12["KoltukNo"].ToString() == "12")
                    button12.Text = oku12["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button12.Text != "12")
            {
                button12.BackColor = Color.Red;
                button12.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut13 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku13 = komut13.ExecuteReader();
            while (oku13.Read())
            {
                if (oku13["KoltukNo"].ToString() == "13")
                    button13.Text = oku13["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button13.Text != "13")
            {
                button13.BackColor = Color.Red;
                button13.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut14 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku14 = komut14.ExecuteReader();
            while (oku14.Read())
            {
                if (oku14["KoltukNo"].ToString() == "14")
                    button14.Text = oku14["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button14.Text != "14")
            {
                button14.BackColor = Color.Red;
                button14.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut15 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku15 = komut15.ExecuteReader();
            while (oku15.Read())
            {
                if (oku15["KoltukNo"].ToString() == "15")
                    button15.Text = oku15["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button15.Text != "15")
            {
                button15.BackColor = Color.Red;
                button15.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut16 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku16 = komut16.ExecuteReader();
            while (oku16.Read())
            {
                if (oku16["KoltukNo"].ToString() == "16")
                    button16.Text = oku16["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button16.Text != "16")
            {
                button16.BackColor = Color.Red;
                button16.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut17 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku17 = komut17.ExecuteReader();
            while (oku17.Read())
            {
                if (oku17["KoltukNo"].ToString() == "17")
                    button17.Text = oku17["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button17.Text != "17")
            {
                button17.BackColor = Color.Red;
                button17.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut18 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku18 = komut18.ExecuteReader();
            while (oku18.Read())
            {
                if (oku18["KoltukNo"].ToString() == "18")
                    button18.Text = oku18["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button18.Text != "18")
            {
                button18.BackColor = Color.Red;
                button18.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut19 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku19 = komut19.ExecuteReader();
            while (oku19.Read())
            {
                if (oku19["KoltukNo"].ToString() == "19")
                    button19.Text = oku19["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button19.Text != "19")
            {
                button19.BackColor = Color.Red;
                button19.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut20 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku20 = komut20.ExecuteReader();
            while (oku20.Read())
            {
                if (oku20["KoltukNo"].ToString() == "20")
                    button20.Text = oku20["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button20.Text != "20")
            {
                button20.BackColor = Color.Red;
                button20.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut21 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku21 = komut21.ExecuteReader();
            while (oku21.Read())
            {
                if (oku21["KoltukNo"].ToString() == "21")
                    button21.Text = oku21["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button21.Text != "21")
            {
                button21.BackColor = Color.Red;
                button21.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut22 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku22 = komut22.ExecuteReader();
            while (oku22.Read())
            {
                if (oku22["KoltukNo"].ToString() == "22")
                    button22.Text = oku22["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button22.Text != "22")
            {
                button22.BackColor = Color.Red;
                button22.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut23 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku23 = komut23.ExecuteReader();
            while (oku23.Read())
            {
                if (oku23["KoltukNo"].ToString() == "23")
                    button23.Text = oku23["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button23.Text != "23")
            {
                button23.BackColor = Color.Red;
                button23.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut24 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku24 = komut24.ExecuteReader();
            while (oku24.Read())
            {
                if (oku24["KoltukNo"].ToString() == "24")
                    button24.Text = oku24["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button24.Text != "24")
            {
                button24.BackColor = Color.Red;
                button24.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut25 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku25 = komut25.ExecuteReader();
            while (oku25.Read())
            {
                if (oku25["KoltukNo"].ToString() == "25")
                    button25.Text = oku25["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button25.Text != "25")
            {
                button25.BackColor = Color.Red;
                button25.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut27 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku27 = komut27.ExecuteReader();
            while (oku27.Read())
            {
                if (oku27["KoltukNo"].ToString() == "27")
                    button27.Text = oku27["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button27.Text != "27")
            {
                button27.BackColor = Color.Red;
                button27.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut28 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku28 = komut28.ExecuteReader();
            while (oku28.Read())
            {
                if (oku28["KoltukNo"].ToString() == "28")
                    button28.Text = oku28["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button28.Text != "28")
            {
                button28.BackColor = Color.Red;
                button28.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut29 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku29 = komut29.ExecuteReader();
            while (oku29.Read())
            {
                if (oku29["KoltukNo"].ToString() == "29")
                    button29.Text = oku29["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button29.Text != "29")
            {
                button29.BackColor = Color.Red;
                button29.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut30 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku30 = komut30.ExecuteReader();
            while (oku30.Read())
            {
                if (oku30["KoltukNo"].ToString() == "30")
                    button30.Text = oku30["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button30.Text != "30")
            {
                button30.BackColor = Color.Red;
                button30.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut31 = new SqlCommand("select * from CUcak1", baglanti);
            SqlDataReader oku31 = komut31.ExecuteReader();
            while (oku31.Read())
            {
                if (oku31["KoltukNo"].ToString() == "31")
                    button31.Text = oku31["KoltukNo"].ToString() + "(dolu)";

            }
            baglanti.Close();
            if (button31.Text != "26")
            {
                button31.BackColor = Color.Red;
                button31.Enabled = false;
            }

        }

        private void button26_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8PEQEU7\\SQLEXPRESS03;Initial Catalog=prolab2;Integrated Security=True";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();

                string ekle = "INSERT INTO CUcak1 (Ad, Soyad, Cinsiyet, Tc, Mail, DogumTarih, KoltukNo, Ucret) VALUES (@Ad, @Soyad, @Cinsiyet, @Tc, @Mail, @DogumTarih, @KoltukNo, @Ucret)";

                SqlCommand cmd = new SqlCommand(ekle, baglanti);

                cmd.Parameters.AddWithValue("@Ad", Adtxt.Text);
                cmd.Parameters.AddWithValue("@Soyad", SoyadTxt.Text);
                cmd.Parameters.AddWithValue("@Cinsiyet", Cinsiyetcmb.Text);
                cmd.Parameters.AddWithValue("@Tc", Tctxt.Text);
                cmd.Parameters.AddWithValue("@Mail", Emailtxt.Text);
                cmd.Parameters.AddWithValue("@DogumTarih", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@KoltukNo", TxtKoltukNo.Text);


                string ucretMetin = CmbxUcret.Text.Replace("Ucret:", "").Trim();
                int ucret;

                if (int.TryParse(ucretMetin, out ucret))
                {
                    cmd.Parameters.AddWithValue("@Ucret", ucret);
                }
                else
                {
                    MessageBox.Show("Ucret alanı geçerli bir sayı içermelidir.");
                    return;
                }


                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "10";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "11";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "12";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "13";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "14";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "15";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "16";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "17";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "18";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "19";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "20";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "21";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "22";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "23";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "24";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "25";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "26";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "27";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "28";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "29";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "30";
        }
    }
}

