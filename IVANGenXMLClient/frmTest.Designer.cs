﻿
namespace IVANGenXMLClient
{
    partial class frmTest
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
            this.btnD01 = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnD01
            // 
            this.btnD01.Location = new System.Drawing.Point(12, 12);
            this.btnD01.Name = "btnD01";
            this.btnD01.Size = new System.Drawing.Size(75, 23);
            this.btnD01.TabIndex = 0;
            this.btnD01.Text = "D01";
            this.btnD01.UseVisualStyleBackColor = true;
            this.btnD01.Click += new System.EventHandler(this.btnD01_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(12, 41);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(776, 397);
            this.txtKetQua.TabIndex = 1;
            this.txtKetQua.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnD01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnD01;
        private System.Windows.Forms.RichTextBox txtKetQua;
    }
}

