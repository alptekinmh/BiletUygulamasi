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
    public partial class DemirYolu1 : Form
    {
        public DemirYolu1()
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrenSeferler1 fr = new TrenSeferler1();
            fr.Show();
        }

        private void DemirYolu1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

