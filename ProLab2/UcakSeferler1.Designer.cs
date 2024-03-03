namespace ProLab2
{
    partial class UcakSeferler1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcakSeferler1));
            C7 = new Label();
            C6 = new Label();
            label5 = new Label();
            C5 = new Label();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // C7
            // 
            C7.AutoSize = true;
            C7.Location = new Point(476, 72);
            C7.Name = "C7";
            C7.Size = new Size(38, 15);
            C7.TabIndex = 18;
            C7.Text = "label7";
            // 
            // C6
            // 
            C6.AutoSize = true;
            C6.Location = new Point(504, 29);
            C6.Name = "C6";
            C6.Size = new Size(38, 15);
            C6.TabIndex = 17;
            C6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 29);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 16;
            label5.Text = "-";
            // 
            // C5
            // 
            C5.AutoSize = true;
            C5.Location = new Point(442, 29);
            C5.Name = "C5";
            C5.Size = new Size(38, 15);
            C5.TabIndex = 15;
            C5.Text = "label5";
            C5.Click += C5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(442, 110);
            button1.Name = "button1";
            button1.Size = new Size(123, 38);
            button1.TabIndex = 14;
            button1.Text = "Koltuk Seçimi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(274, 119);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 13;
            label4.Text = "Uçak 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 119);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 12;
            label3.Text = "C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(274, 43);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 11;
            label2.Text = "Araç No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 43);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 10;
            label1.Text = "Firma İsim:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(274, 216);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 20;
            label6.Text = "Uçak 2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(41, 216);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 19;
            label7.Text = "C";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(442, 198);
            button2.Name = "button2";
            button2.Size = new Size(123, 38);
            button2.TabIndex = 21;
            button2.Text = "Koltuk Seçimi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UcakSeferler1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(C7);
            Controls.Add(C6);
            Controls.Add(label5);
            Controls.Add(C5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UcakSeferler1";
            Text = "UcakSeferler";
            Load += UcakSeferler1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label C7;
        private Label C6;
        private Label label5;
        private Label C5;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Button button2;
    }
}