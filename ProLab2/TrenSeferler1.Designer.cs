namespace ProLab2
{
    partial class TrenSeferler1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrenSeferler1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            C5 = new Label();
            label5 = new Label();
            C6 = new Label();
            c7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 54);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Firma İsim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(272, 54);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Araç No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 130);
            label3.Name = "label3";
            label3.Size = new Size(20, 20);
            label3.TabIndex = 2;
            label3.Text = "D";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(272, 130);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Tren 1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(440, 121);
            button1.Name = "button1";
            button1.Size = new Size(123, 38);
            button1.TabIndex = 4;
            button1.Text = "Koltuk Seçimi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // C5
            // 
            C5.AutoSize = true;
            C5.Location = new Point(440, 40);
            C5.Name = "C5";
            C5.Size = new Size(38, 15);
            C5.TabIndex = 5;
            C5.Text = "label5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 40);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 6;
            label5.Text = "-";
            // 
            // C6
            // 
            C6.AutoSize = true;
            C6.Location = new Point(502, 40);
            C6.Name = "C6";
            C6.Size = new Size(38, 15);
            C6.TabIndex = 7;
            C6.Text = "label6";
            // 
            // c7
            // 
            c7.AutoSize = true;
            c7.Location = new Point(474, 83);
            c7.Name = "c7";
            c7.Size = new Size(38, 15);
            c7.TabIndex = 9;
            c7.Text = "label7";
            c7.Click += c7_Click;
            // 
            // TrenSeferler1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(622, 204);
            Controls.Add(c7);
            Controls.Add(C6);
            Controls.Add(label5);
            Controls.Add(C5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TrenSeferler1";
            Text = "TrenSeferler1";
            Load += TrenSeferler1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label C5;
        private Label label5;
        private Label C6;
        private Label c7;
    }
}