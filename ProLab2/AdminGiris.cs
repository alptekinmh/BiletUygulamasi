using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab2
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text == "1234" && TxtSifre.Text == "1234")
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!!");
            }
        }

        private void AdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
