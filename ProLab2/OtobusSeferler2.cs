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
    public partial class OtobusSeferler2 : Form
    {
        public OtobusSeferler2()
        {
            InitializeComponent();
        }

        Dictionary<string, Dictionary<string, int>> fiyatlar = new Dictionary<string, Dictionary<string, int>>
{
    { "Istanbul", new Dictionary<string, int> { { "Kocaeli", 50 }, { "Ankara", 300 }, { "Eskisehir", 150 }, { "Konya", 300 } } },
    { "Kocaeli", new Dictionary<string, int> { { "Istanbul", 50 }, { "Ankara", 400 }, { "Eskisehir", 100 }, { "Konya", 250 } } },
    { "Eskisehir", new Dictionary<string, int> { { "Istanbul", 150 }, { "Kocaeli", 100 }, { "Konya", 150 } } },
    { "Konya", new Dictionary<string, int> { { "Istanbul", 300 }, { "Kocaeli", 250 }, { "Eskisehir", 150 } } }
};
        private void OtobusSeferler2_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms["OtobusYolu2"] is OtobusYolu2 otobusYolu2)
            {
                string selectedComboBoxItem1 = otobusYolu2.GetSelectedComboBoxItem();
                string selectedComboBoxItem2 = otobusYolu2.GetSelectedComboBox2Item();
                C5.Text = selectedComboBoxItem1;
                C6.Text = selectedComboBoxItem2;
            }


            string baslangicSehri = C5.Text;

            string varisSehri = C6.Text;

            if (fiyatlar.ContainsKey(baslangicSehri) && fiyatlar[baslangicSehri].ContainsKey(varisSehri))
            {
                int ucret = fiyatlar[baslangicSehri][varisSehri];
                c7.Text = ucret.ToString();
            }
            else
            {
                Console.WriteLine("Geçersiz şehir girişi!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BOtobus2 fr = new BOtobus2();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COtobus1 fr = new COtobus1();
            fr.Show();
        }
    }
}
