﻿using System;
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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGiris fr = new AdminGiris();
            fr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirmaGiris fr = new FirmaGiris();
            fr.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AracSecenek fr = new AracSecenek();
            fr.Show();

        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
