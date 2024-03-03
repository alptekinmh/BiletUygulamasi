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
    public partial class OtobusYolu2 : Form
    {
        public OtobusYolu2()
        {
            InitializeComponent();
        }
        public string GetSelectedComboBoxItem()
        {
            return comboBox1.SelectedItem?.ToString();
        }
        public string GetSelectedComboBox2Item()
        {
            return comboBox2.SelectedItem?.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OtobusSeferler2 fr = new OtobusSeferler2();
            fr.Show();
        }

        private void OtobusYolu2_Load(object sender, EventArgs e)
        {

        }
    }
}
