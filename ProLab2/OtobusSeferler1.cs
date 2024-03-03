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
    public partial class OtobusSeferler1 : Form
    {
        public OtobusSeferler1()
        {
            InitializeComponent();
        }

        Dictionary<string, Dictionary<string, int>> fiyatlar = new Dictionary<string, Dictionary<string, int>>
{
    { "Istanbul", new Dictionary<string, int> { { "Kocaeli", 50 }, { "Ankara", 300 }, { "Eskisehir", 150 }, { "Konya", 300 } } },
    { "Kocaeli", new Dictionary<string, int> { { "Istanbul", 50 }, { "Ankara", 400 }, { "Eskisehir", 100 }, { "Konya", 250 } } },
    { "Ankara", new Dictionary<string, int> { { "Istanbul", 300 }, { "Kocaeli", 400 } } },
    };

        private void OtobusSeferler1_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms["OtobusYolu1"] is OtobusYolu1 otobusYolu1)
            {
                string selectedComboBoxItem1 = otobusYolu1.GetSelectedComboBoxItem();
                string selectedComboBoxItem2 = otobusYolu1.GetSelectedComboBox2Item();
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
        public string getucret()
        { return c7.Text; }

        private void button1_Click(object sender, EventArgs e)
        {
            AOtobus1 fr = new AOtobus1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AOtobus2 fr = new AOtobus2();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BOtobus1 fr = new BOtobus1();
            fr.Show();
        }
    }
}
