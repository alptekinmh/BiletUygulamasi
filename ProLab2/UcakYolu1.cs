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
    public partial class UcakYolu1 : Form
    {
        public UcakYolu1()
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcakSeferler1 fr = new UcakSeferler1();
            fr.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void UcakYolu1_Load(object sender, EventArgs e)
        {

        }
    }
}
