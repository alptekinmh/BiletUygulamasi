namespace ProLab2
{
    partial class FirmaPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button3 = new Button();
            listView1 = new ListView();
            AracNo = new ColumnHeader();
            KoltukSayisi = new ColumnHeader();
            SeferNo = new ColumnHeader();
            FirmaAdi = new ColumnHeader();
            UlasimSekli = new ColumnHeader();
            id = new ColumnHeader();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(2, 72);
            button1.Name = "button1";
            button1.Size = new Size(97, 42);
            button1.TabIndex = 0;
            button1.Text = "Araç-Sefer Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(424, 310);
            button3.Name = "button3";
            button3.Size = new Size(130, 42);
            button3.TabIndex = 2;
            button3.Text = "Muhasebe(Kar-Zarar)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { AracNo, KoltukSayisi, SeferNo, FirmaAdi, UlasimSekli, id });
            listView1.Location = new Point(304, 1);
            listView1.Name = "listView1";
            listView1.Size = new Size(461, 264);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // AracNo
            // 
            AracNo.Text = "AracNo";
            AracNo.Width = 80;
            // 
            // KoltukSayisi
            // 
            KoltukSayisi.Text = "KoltukSayisi";
            KoltukSayisi.Width = 80;
            // 
            // SeferNo
            // 
            SeferNo.Text = "SeferNo";
            SeferNo.Width = 80;
            // 
            // FirmaAdi
            // 
            FirmaAdi.Text = "FirmaAdi";
            FirmaAdi.Width = 85;
            // 
            // UlasimSekli
            // 
            UlasimSekli.Text = "UlasimSekli";
            UlasimSekli.Width = 85;
            // 
            // id
            // 
            id.Text = "id";
            // 
            // button4
            // 
            button4.Location = new Point(2, 1);
            button4.Name = "button4";
            button4.Size = new Size(97, 39);
            button4.TabIndex = 4;
            button4.Text = "Göster";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(2, 310);
            button5.Name = "button5";
            button5.Size = new Size(97, 42);
            button5.TabIndex = 5;
            button5.Text = "Araç-Sefer Çıkar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-1, 358);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(126, 361);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 7;
            label1.Text = "ID Giriniz";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(2, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(2, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(2, 178);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(97, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(2, 207);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(97, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(2, 236);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(97, 23);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(-1, 265);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 120);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 14;
            label2.Text = "Araç No giriniz";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 157);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 181);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 16;
            label4.Text = "Sefer No giriniz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 210);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 17;
            label5.Text = "Firma Adi giriniz";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 239);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(126, 268);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 19;
            label7.Text = "id giriniz";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(126, 152);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 20;
            label8.Text = "Koltuk Sayisi giriniz";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(126, 239);
            label9.Name = "label9";
            label9.Size = new Size(115, 15);
            label9.TabIndex = 21;
            label9.Text = "Ulasim Seklini giriniz";
            // 
            // FirmaPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(764, 420);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "FirmaPanel";
            Text = "FirmaPanel";
            Load += FirmaPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private ListView listView1;
        private ColumnHeader AracNo;
        private ColumnHeader KoltukSayisi;
        private ColumnHeader SeferNo;
        private ColumnHeader FirmaAdi;
        private ColumnHeader UlasimSekli;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private ColumnHeader id;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}