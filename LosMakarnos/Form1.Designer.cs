﻿namespace LosMakarnos
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
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(156, 170);
            button1.Name = "button1";
            button1.Size = new Size(225, 128);
            button1.TabIndex = 0;
            button1.Text = "Masalar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(564, 170);
            button2.Name = "button2";
            button2.Size = new Size(225, 128);
            button2.TabIndex = 1;
            button2.Text = "Ayarlar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 493);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Açılış Sayfası";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}