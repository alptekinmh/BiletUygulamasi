namespace ProLab2
{
    partial class DemirYolu1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Kalkış Noktası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Varış Noktası";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "Yolculuk Tarihi";
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "comboBox1";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Istanbul", "Kocaeli", "Bilecik", "Eskisehir", "Ankara" });
            comboBox1.Location = new Point(12, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Istanbul", "Kocaeli", "Bilecik", "Eskisehir", "Ankara" });
            comboBox2.Location = new Point(12, 138);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(15, 218);
            dateTimePicker1.MaxDate = new DateTime(2023, 12, 10, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2023, 12, 4, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2023, 12, 4, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(100, 268);
            button1.Name = "button1";
            button1.Size = new Size(115, 29);
            button1.TabIndex = 6;
            button1.Text = "Bilet Bul";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DemirYolu1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(324, 309);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DemirYolu1";
            Text = "Demiryolu1";
            Load += DemirYolu1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}