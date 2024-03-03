namespace ProLab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button3 = new Button();
            HizmetBedeliGoster = new Button();
            listView1 = new ListView();
            id = new ColumnHeader();
            firmaisim = new ColumnHeader();
            aracsayisi = new ColumnHeader();
            ulasimyolu = new ColumnHeader();
            hizmetbedeli = new ColumnHeader();
            textBox3 = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(117, 43);
            button1.TabIndex = 0;
            button1.Text = "Firmaları Görüntüle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 357);
            button3.Name = "button3";
            button3.Size = new Size(117, 43);
            button3.TabIndex = 2;
            button3.Text = "Firma Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // HizmetBedeliGoster
            // 
            HizmetBedeliGoster.Location = new Point(161, 12);
            HizmetBedeliGoster.Name = "HizmetBedeliGoster";
            HizmetBedeliGoster.Size = new Size(117, 44);
            HizmetBedeliGoster.TabIndex = 7;
            HizmetBedeliGoster.Text = "Mevcut Hizmet Bedelini Göster";
            HizmetBedeliGoster.UseVisualStyleBackColor = true;
            HizmetBedeliGoster.Click += HizmetBedeliGoster_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, firmaisim, aracsayisi, ulasimyolu, hizmetbedeli });
            listView1.Location = new Point(376, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(412, 248);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // id
            // 
            id.Text = "Firma id";
            id.Width = 75;
            // 
            // firmaisim
            // 
            firmaisim.Text = "Firma isim";
            firmaisim.Width = 75;
            // 
            // aracsayisi
            // 
            aracsayisi.Text = "Arac Sayisi";
            aracsayisi.Width = 75;
            // 
            // ulasimyolu
            // 
            ulasimyolu.Text = "Ulasim Yolu";
            ulasimyolu.Width = 75;
            // 
            // hizmetbedeli
            // 
            hizmetbedeli.Text = "Hizmet bedeli";
            hizmetbedeli.Width = 85;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(148, 368);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(73, 23);
            textBox3.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(247, 371);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 12;
            label1.Text = "ID SECİMİ YAPINIZ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(136, 187);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 35;
            label8.Text = "Firma isim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 245);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 32;
            label5.Text = "Ulasim yolu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 216);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 31;
            label4.Text = "Arac Sayisi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 192);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 155);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 29;
            label2.Text = "Firma id";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 242);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(97, 23);
            textBox5.TabIndex = 26;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 213);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(97, 23);
            textBox4.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 23);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 23);
            textBox2.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(12, 107);
            button2.Name = "button2";
            button2.Size = new Size(97, 42);
            button2.TabIndex = 22;
            button2.Text = "Firma Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(listView1);
            Controls.Add(HizmetBedeliGoster);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Admin Paneli";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button HizmetBedeliGoster;
        private ListView listView1;
        private ColumnHeader id;
        private ColumnHeader firmaisim;
        private ColumnHeader aracsayisi;
        private ColumnHeader ulasimyolu;
        private ColumnHeader hizmetbedeli;
        private TextBox textBox3;
        private Label label1;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
    }
}