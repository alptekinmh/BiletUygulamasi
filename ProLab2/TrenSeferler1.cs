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
    public partial class TrenSeferler1 : Form
    {
        public TrenSeferler1()
        {
            InitializeComponent();
        }


        Dictionary<string, Dictionary<string, int>> fiyatlar = new Dictionary<string, Dictionary<string, int>>
            {
                { "Istanbul", new Dictionary<string, int> { { "Kocaeli", 50 }, { "Bilecik", 150 }, { "Ankara", 250 }, { "Eskisehir", 200 } } },
                { "Kocaeli", new Dictionary<string, int> { { "Istanbul", 50 }, { "Bilecik", 50 }, { "Ankara", 200 }, { "Eskisehir", 100 } } },
                { "Bilecik", new Dictionary<string, int> { { "Istanbul", 150 }, { "Kocaeli", 50 }, { "Ankara", 150 }, { "Eskisehir", 50 } } },
                { "Ankara", new Dictionary<string, int> { { "Istanbul", 250 }, { "Kocaeli", 200 }, { "Bilecik", 150 }, { "Eskisehir", 100 } } },
                { "Eskisehir", new Dictionary<string, int> { { "Istanbul", 200 }, { "Kocaeli", 100 }, { "Bilecik", 50 }, { "Ankara", 100 } } },

            };

        private void TrenSeferler1_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms["DemirYolu1"] is DemirYolu1 demirYolu1)
            {
                string selectedComboBoxItem1 = demirYolu1.GetSelectedComboBoxItem();
                string selectedComboBoxItem2 = demirYolu1.GetSelectedComboBox2Item();
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
            Tren1 fr = new Tren1();
            fr.Show();
        }

        private void c7_Click(object sender, EventArgs e)
        {

        }
    }


}

