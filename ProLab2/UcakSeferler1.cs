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
    public partial class UcakSeferler1 : Form
    {
        public UcakSeferler1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CUcak1 fr = new CUcak1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CUcak2 fr = new CUcak2();
            fr.Show();
        }



        Dictionary<string, Dictionary<string, int>> fiyatlar = new Dictionary<string, Dictionary<string, int>>
            {
                { "Istanbul", new Dictionary<string, int> {{ "Konya", 1200 } } },
                { "Konya", new Dictionary<string, int> {{ "Istanbul", 1200 } } },
            };



        private void UcakSeferler1_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms["UcakYolu1"] is UcakYolu1 ucakYolu1)
            {
                string selectedComboBoxItem1 = ucakYolu1.GetSelectedComboBoxItem();
                string selectedComboBoxItem2 = ucakYolu1.GetSelectedComboBox2Item();
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

        private void C5_Click(object sender, EventArgs e)
        {

        }
    }
}
