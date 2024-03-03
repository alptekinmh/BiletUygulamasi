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
    public partial class UcakSeferler2 : Form
    {
        public UcakSeferler2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FUcak1 fr = new FUcak1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FUcak2 fr = new FUcak2();
            fr.Show();
        }

        Dictionary<string, Dictionary<string, int>> fiyatlar = new Dictionary<string, Dictionary<string, int>>
            {
                { "Istanbul", new Dictionary<string, int> {{ "Ankara", 1000 } } },
                { "Ankara", new Dictionary<string, int> {{ "Istanbul", 1000 } } },
            };

        private void UcakSeferler2_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms["UcakYolu2"] is UcakYolu2 ucakYolu2)
            {
                string selectedComboBoxItem1 = ucakYolu2.GetSelectedComboBoxItem();
                string selectedComboBoxItem2 = ucakYolu2.GetSelectedComboBox2Item();
                C5.Text = selectedComboBoxItem1;
                C6.Text = selectedComboBoxItem2;
            }


            string baslangicSehri = C5.Text;

            string varisSehri = C6.Text;

            if (fiyatlar.ContainsKey(baslangicSehri) && fiyatlar[baslangicSehri].ContainsKey(varisSehri))
            {
                int ucret = fiyatlar[baslangicSehri][varisSehri];
                C7.Text = ucret.ToString();
            }
            else
            {
                Console.WriteLine("Geçersiz şehir girişi!");
            }
        }
    }
}
