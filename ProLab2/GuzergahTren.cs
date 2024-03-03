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
    public partial class GuzergahTren : Form
    {
        public GuzergahTren()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DemirYolu1 fr = new DemirYolu1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DemirYolu2 fr = new DemirYolu2();
            fr.Show();
        }

        private void GuzergahTren_Load(object sender, EventArgs e)
        {

        }
    }
}
