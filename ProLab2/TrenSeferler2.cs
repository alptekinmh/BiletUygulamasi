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
    public partial class TrenSeferler2 : Form
    {
        public TrenSeferler2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tren2 fr = new Tren2();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tren3 fr = new Tren3();
            fr.Show();
        }

        private void TrenSeferler2_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms["DemirYolu2"] is DemirYolu2 demirYolu2)
            {
                string selectedComboBoxItem1 = demirYolu2.GetSelectedComboBoxItem();
                string selectedComboBoxItem2 = demirYolu2.GetSelectedComboBox2Item();
                C8.Text = selectedComboBoxItem1;
                C9.Text = selectedComboBoxItem2;
            }


            Dictionary<string, Dictionary<string, int>> fiyatlar = new Dictionary<string, Dictionary<string, int>>
            {
                { "Istanbul", new Dictionary<string, int> { { "Kocaeli", 50 }, { "Bilecik", 150 }, { "Eskisehir", 200 }, { "Konya", 300 } } },
                { "Kocaeli", new Dictionary<string, int> { { "Istanbul", 50 }, { "Bilecik", 50 },{ "Eskisehir", 100 }, { "Konya", 250 } } },
                { "Bilecik", new Dictionary<string, int> { { "Istanbul", 150 }, { "Kocaeli", 50 },{ "Eskisehir", 50 }, { "Konya", 200 } } },
                { "Eskisehir", new Dictionary<string, int> { { "Istanbul", 200 }, { "Kocaeli", 100 }, { "Bilecik", 50 },{ "Konya", 150 } } },
                { "Konya", new Dictionary<string, int> { { "Istanbul", 300 }, { "Kocaeli", 250 }, { "Bilecik", 200 }, { "Eskisehir", 150 } } }
            };


            string baslangicSehri = C8.Text;

            string varisSehri = C9.Text;
            if (fiyatlar.ContainsKey(baslangicSehri) && fiyatlar[baslangicSehri].ContainsKey(varisSehri))
            {
                int ucret = fiyatlar[baslangicSehri][varisSehri];
                C10.Text = ucret.ToString();
            }
            else
            {
                Console.WriteLine("Geçersiz şehir girişi!");
            }

        }


    }
}

