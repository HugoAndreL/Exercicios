﻿namespace MiniERP
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
            label1 = new Label();
            btnForn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(797, 89);
            label1.TabIndex = 0;
            label1.Text = "O que gostaria de fazer?";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnForn
            // 
            btnForn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnForn.Location = new Point(12, 120);
            btnForn.Name = "btnForn";
            btnForn.Size = new Size(148, 77);
            btnForn.TabIndex = 1;
            btnForn.Text = "Fornecedor";
            btnForn.UseVisualStyleBackColor = true;
            btnForn.Click += NavigateFunc;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(194, 120);
            button1.Name = "button1";
            button1.Size = new Size(148, 77);
            button1.TabIndex = 2;
            button1.Text = "Produto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NavigateProd;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 209);
            Controls.Add(button1);
            Controls.Add(btnForn);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnForn;
        private Button button1;
    }
}
