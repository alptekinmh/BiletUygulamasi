namespace ProLab2
{
    partial class AracSecenek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracSecenek));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(24, 173);
            button1.Name = "button1";
            button1.Size = new Size(99, 43);
            button1.TabIndex = 0;
            button1.Text = "Tren";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(231, 173);
            button2.Name = "button2";
            button2.Size = new Size(99, 43);
            button2.TabIndex = 1;
            button2.Text = "Uçak";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(446, 173);
            button3.Name = "button3";
            button3.Size = new Size(99, 43);
            button3.TabIndex = 2;
            button3.Text = "Otobüs";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AracSecenek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(630, 357);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AracSecenek";
            Text = "AracSecenek";
            Load += AracSecenek_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}