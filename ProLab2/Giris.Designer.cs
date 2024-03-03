namespace ProLab2
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(314, 188);
            button1.Name = "button1";
            button1.Size = new Size(118, 50);
            button1.TabIndex = 0;
            button1.Text = "Admin Giris";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(569, 188);
            button2.Name = "button2";
            button2.Size = new Size(118, 50);
            button2.TabIndex = 1;
            button2.Text = "Firmalar Giris";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(135, 77);
            label1.Name = "label1";
            label1.Size = new Size(459, 21);
            label1.TabIndex = 2;
            label1.Text = "Hosgeldiniz Bilet İşemleri için Lütfen Bilet Ara'ya Tıklayınız ";
            // 
            // button3
            // 
            button3.Location = new Point(39, 188);
            button3.Name = "button3";
            button3.Size = new Size(118, 50);
            button3.TabIndex = 3;
            button3.Text = "Bilet Ara";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Giris";
            Text = "Giris ";
            Load += Giris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
    }
}