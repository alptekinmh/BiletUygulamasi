﻿namespace ProLab2
{
    partial class GuzergahUcak
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
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(189, 235);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 9;
            label3.Text = "İstanbul-Ankara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(195, 117);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 8;
            label2.Text = "İstanbul-Konya";
            // 
            // button2
            // 
            button2.Location = new Point(12, 227);
            button2.Name = "button2";
            button2.Size = new Size(87, 39);
            button2.TabIndex = 7;
            button2.Text = "Güzergah 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 109);
            button1.Name = "button1";
            button1.Size = new Size(87, 39);
            button1.TabIndex = 6;
            button1.Text = "Güzergah 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(55, 47);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 5;
            label1.Text = "Güzergah Seçiniz:";
            // 
            // GuzergahUcak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(390, 349);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "GuzergahUcak";
            Text = "GuzergahUcak";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label1;
    }
}