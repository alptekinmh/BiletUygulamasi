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
    public partial class DemirYolu2 : Form
    {
        public DemirYolu2()
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
            TrenSeferler2 fr = new TrenSeferler2();
            fr.Show();
        }

        private void DemirYolu2_Load(object sender, EventArgs e)
        {

        }
    }
}
