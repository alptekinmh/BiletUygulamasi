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
    public partial class AracSecenek : Form
    {
        public AracSecenek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuzergahTren fr = new GuzergahTren();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuzergahUcak fr = new GuzergahUcak();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GuzergahOtobus fr = new GuzergahOtobus();
            fr.Show();
        }

        private void AracSecenek_Load(object sender, EventArgs e)
        {

        }
    }
}
