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
    public partial class UcakYolu2 : Form
    {
        public UcakYolu2()
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
            UcakSeferler2 fr = new UcakSeferler2();
            fr.Show();
        }

        private void UcakYolu2_Load(object sender, EventArgs e)
        {

        }
    }
}
