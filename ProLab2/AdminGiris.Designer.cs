namespace ProLab2
{
    partial class AdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGiris));
            TxtKullaniciAdi = new TextBox();
            labelkullanici = new Label();
            labelsifre = new Label();
            TxtSifre = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // TxtKullaniciAdi
            // 
            TxtKullaniciAdi.BackColor = SystemColors.ScrollBar;
            TxtKullaniciAdi.Location = new Point(320, 164);
            TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            TxtKullaniciAdi.Size = new Size(100, 23);
            TxtKullaniciAdi.TabIndex = 0;
            // 
            // labelkullanici
            // 
            labelkullanici.AutoSize = true;
            labelkullanici.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelkullanici.Location = new Point(174, 162);
            labelkullanici.Name = "labelkullanici";
            labelkullanici.Size = new Size(96, 21);
            labelkullanici.TabIndex = 1;
            labelkullanici.Text = "Kullanıcı adı:";
            // 
            // labelsifre
            // 
            labelsifre.AutoSize = true;
            labelsifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelsifre.Location = new Point(215, 212);
            labelsifre.Name = "labelsifre";
            labelsifre.Size = new Size(45, 21);
            labelsifre.TabIndex = 2;
            labelsifre.Text = "Şifre:";
            // 
            // TxtSifre
            // 
            TxtSifre.BackColor = SystemColors.ScrollBar;
            TxtSifre.Location = new Point(320, 214);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(100, 23);
            TxtSifre.TabIndex = 3;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(320, 275);
            button1.Name = "button1";
            button1.Size = new Size(100, 31);
            button1.TabIndex = 4;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(136, 92);
            label1.Name = "label1";
            label1.Size = new Size(491, 25);
            label1.TabIndex = 5;
            label1.Text = "Hoşgeldiniz Lütfen Kullanıcı Bilgilerini Eksiksiz Giriniz";
            // 
            // AdminGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(TxtSifre);
            Controls.Add(labelsifre);
            Controls.Add(labelkullanici);
            Controls.Add(TxtKullaniciAdi);
            Name = "AdminGiris";
            Text = "AdminGiris";
            Load += AdminGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtKullaniciAdi;
        private Label labelkullanici;
        private Label labelsifre;
        private TextBox TxtSifre;
        private Button button1;
        private Label label1;
    }
}