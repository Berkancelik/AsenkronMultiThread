﻿namespace TaskFormApp
{
    partial class Form1
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
            this.BtnReadFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnCounter = new System.Windows.Forms.Button();
            this.textBoxXounter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnReadFile
            // 
            this.BtnReadFile.Location = new System.Drawing.Point(35, 23);
            this.BtnReadFile.Name = "BtnReadFile";
            this.BtnReadFile.Size = new System.Drawing.Size(153, 46);
            this.BtnReadFile.TabIndex = 0;
            this.BtnReadFile.Text = "Dosya Oku";
            this.BtnReadFile.UseVisualStyleBackColor = true;
            this.BtnReadFile.Click += new System.EventHandler(this.BtnReadFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 137);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(184, 151);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // BtnCounter
            // 
            this.BtnCounter.Location = new System.Drawing.Point(350, 23);
            this.BtnCounter.Name = "BtnCounter";
            this.BtnCounter.Size = new System.Drawing.Size(153, 46);
            this.BtnCounter.TabIndex = 0;
            this.BtnCounter.Text = "Sayaç Arttır";
            this.BtnCounter.UseVisualStyleBackColor = true;
            this.BtnCounter.Click += new System.EventHandler(this.BtnCounter_Click);
            // 
            // textBoxXounter
            // 
            this.textBoxXounter.Location = new System.Drawing.Point(350, 137);
            this.textBoxXounter.Name = "textBoxXounter";
            this.textBoxXounter.Size = new System.Drawing.Size(100, 22);
            this.textBoxXounter.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxXounter);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnCounter);
            this.Controls.Add(this.BtnReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReadFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnCounter;
        private System.Windows.Forms.TextBox textBoxXounter;
    }
}

