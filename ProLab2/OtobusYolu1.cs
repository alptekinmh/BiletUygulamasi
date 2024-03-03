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
    public partial class OtobusYolu1 : Form
    {
        public OtobusYolu1()
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
            OtobusSeferler1 fr = new OtobusSeferler1();
            fr.Show();
        }
    }
}
