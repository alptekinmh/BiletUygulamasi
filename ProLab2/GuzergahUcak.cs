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
    public partial class GuzergahUcak : Form
    {
        public GuzergahUcak()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcakYolu1 fr = new UcakYolu1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UcakYolu2 fr = new UcakYolu2();
            fr.Show();
        }
    }
}
