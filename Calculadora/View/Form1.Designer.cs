﻿namespace Calculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHead = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCE = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnClear = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnDivision = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNumber7 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNumber8 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNumber9 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnMultiply = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNumber4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNumber5 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNumber6 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSubtract = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNumber1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNumber2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNumber3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSum = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNegative = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNumber0 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnComma = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnEqual = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblScreen = new System.Windows.Forms.Label();
            this.btnClearDigit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.panelHead.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.DarkViolet;
            this.panelHead.Controls.Add(this.pictureExit);
            this.panelHead.Controls.Add(this.label1);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(338, 43);
            this.panelHead.TabIndex = 0;
            this.panelHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseDown);
            this.panelHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseMove);
            this.panelHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pacifico", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.DarkViolet;
            this.panelFooter.Controls.Add(this.label2);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 469);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(338, 66);
            this.panelFooter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Pacifico", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created by David";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCE);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.btnClearDigit);
            this.flowLayoutPanel1.Controls.Add(this.btnDivision);
            this.flowLayoutPanel1.Controls.Add(this.btnNumber7);
            this.flowLayoutPanel1.Controls.Add(this.btnNumber8);
            this.flowLayoutPanel1.Controls.Add(this.btnNumber9);
            this.flowLayoutPanel1.Controls.Add(this.btnMultiply);
            this.flowLayoutPanel1.Controls.Add(this.btnNumber4);
            this.flowLayoutPanel1.Controls.Add(this.btnNumber5);
            this.flowLayoutPanel1.Controls.Add(this.btnNumber6);
            this.flowLayoutPanel1.Controls.Add(this.btnSubtract);
            this.flowLayoutPanel1.Controls.Add(this.btnNumber1);
            this.flowLayoutPanel1.Controls.Add(this.btnNumber2);
            this.flowLayoutPanel1.Controls.Add(this.btnNumber3);
            this.flowLayoutPanel1.Controls.Add(this.btnSum);
            this.flowLayoutPanel1.Controls.Add(this.btnNegative);
            this.flowLayoutPanel1.Controls.Add(this.btnNumber0);
            this.flowLayoutPanel1.Controls.Add(this.btnComma);
            this.flowLayoutPanel1.Controls.Add(this.btnEqual);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(338, 353);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnCE
            // 
            this.btnCE.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCE.ForeColor = System.Drawing.Color.White;
            this.btnCE.Location = new System.Drawing.Point(5, 3);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(78, 64);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(89, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 64);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDivision.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDivision.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDivision.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDivision.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.White;
            this.btnDivision.Location = new System.Drawing.Point(257, 3);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(78, 64);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Text = "÷";
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnNumber7
            // 
            this.btnNumber7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNumber7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNumber7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNumber7.ForeColor = System.Drawing.Color.White;
            this.btnNumber7.Location = new System.Drawing.Point(5, 73);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(78, 64);
            this.btnNumber7.TabIndex = 4;
            this.btnNumber7.Text = "7";
            this.btnNumber7.Click += new System.EventHandler(this.btnNumber7_Click);
            // 
            // btnNumber8
            // 
            this.btnNumber8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNumber8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNumber8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNumber8.ForeColor = System.Drawing.Color.White;
            this.btnNumber8.Location = new System.Drawing.Point(89, 73);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(78, 64);
            this.btnNumber8.TabIndex = 5;
            this.btnNumber8.Text = "8";
            this.btnNumber8.Click += new System.EventHandler(this.btnNumber8_Click);
            // 
            // btnNumber9
            // 
            this.btnNumber9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNumber9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNumber9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNumber9.ForeColor = System.Drawing.Color.White;
            this.btnNumber9.Location = new System.Drawing.Point(173, 73);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(78, 64);
            this.btnNumber9.TabIndex = 6;
            this.btnNumber9.Text = "9";
            this.btnNumber9.Click += new System.EventHandler(this.btnNumber9_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMultiply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMultiply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMultiply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.White;
            this.btnMultiply.Location = new System.Drawing.Point(257, 73);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(78, 64);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "X";
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnNumber4
            // 
            this.btnNumber4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNumber4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNumber4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNumber4.ForeColor = System.Drawing.Color.White;
            this.btnNumber4.Location = new System.Drawing.Point(5, 143);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(78, 64);
            this.btnNumber4.TabIndex = 8;
            this.btnNumber4.Text = "4";
            this.btnNumber4.Click += new System.EventHandler(this.btnNumber4_Click);
            // 
            // btnNumber5
            // 
            this.btnNumber5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNumber5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNumber5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNumber5.ForeColor = System.Drawing.Color.White;
            this.btnNumber5.Location = new System.Drawing.Point(89, 143);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(78, 64);
            this.btnNumber5.TabIndex = 9;
            this.btnNumber5.Text = "5";
            this.btnNumber5.Click += new System.EventHandler(this.btnNumber5_Click);
            // 
            // btnNumber6
            // 
            this.btnNumber6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNumber6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNumber6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNumber6.ForeColor = System.Drawing.Color.White;
            this.btnNumber6.Location = new System.Drawing.Point(173, 143);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(78, 64);
            this.btnNumber6.TabIndex = 10;
            this.btnNumber6.Text = "6";
            this.btnNumber6.Click += new System.EventHandler(this.btnNumber6_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubtract.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubtract.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubtract.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.ForeColor = System.Drawing.Color.White;
            this.btnSubtract.Location = new System.Drawing.Point(257, 143);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(78, 64);
            this.btnSubtract.TabIndex = 11;
            this.btnSubtract.Text = "-";
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnNumber1
            // 
            this.btnNumber1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNumber1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNumber1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNumber1.ForeColor = System.Drawing.Color.White;
            this.btnNumber1.Location = new System.Drawing.Point(5, 213);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(78, 64);
            this.btnNumber1.TabIndex = 12;
            this.btnNumber1.Text = "1";
            this.btnNumber1.Click += new System.EventHandler(this.btnNumber1_Click);
            // 
            // btnNumber2
            // 
            this.btnNumber2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNumber2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNumber2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNumber2.ForeColor = System.Drawing.Color.White;
            this.btnNumber2.Location = new System.Drawing.Point(89, 213);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(78, 64);
            this.btnNumber2.TabIndex = 13;
            this.btnNumber2.Text = "2";
            this.btnNumber2.Click += new System.EventHandler(this.btnNumber2_Click);
            // 
            // btnNumber3
            // 
            this.btnNumber3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNumber3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNumber3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNumber3.ForeColor = System.Drawing.Color.White;
            this.btnNumber3.Location = new System.Drawing.Point(173, 213);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(78, 64);
            this.btnNumber3.TabIndex = 14;
            this.btnNumber3.Text = "3";
            this.btnNumber3.Click += new System.EventHandler(this.btnNumber3_Click);
            // 
            // btnSum
            // 
            this.btnSum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSum.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.ForeColor = System.Drawing.Color.White;
            this.btnSum.Location = new System.Drawing.Point(257, 213);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(78, 64);
            this.btnSum.TabIndex = 15;
            this.btnSum.Text = "+";
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNegative.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNegative.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNegative.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNegative.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNegative.ForeColor = System.Drawing.Color.White;
            this.btnNegative.Location = new System.Drawing.Point(5, 283);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(78, 64);
            this.btnNegative.TabIndex = 16;
            this.btnNegative.Text = "+/-";
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnNumber0
            // 
            this.btnNumber0.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber0.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNumber0.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNumber0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNumber0.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNumber0.ForeColor = System.Drawing.Color.White;
            this.btnNumber0.Location = new System.Drawing.Point(89, 283);
            this.btnNumber0.Name = "btnNumber0";
            this.btnNumber0.Size = new System.Drawing.Size(78, 64);
            this.btnNumber0.TabIndex = 17;
            this.btnNumber0.Text = "0";
            this.btnNumber0.Click += new System.EventHandler(this.btnNumber0_Click);
            // 
            // btnComma
            // 
            this.btnComma.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComma.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComma.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComma.ForeColor = System.Drawing.Color.White;
            this.btnComma.Location = new System.Drawing.Point(173, 283);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(78, 64);
            this.btnComma.TabIndex = 18;
            this.btnComma.Text = ",";
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEqual.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEqual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEqual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.White;
            this.btnEqual.Location = new System.Drawing.Point(257, 283);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(78, 64);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // lblScreen
            // 
            this.lblScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.ForeColor = System.Drawing.Color.Black;
            this.lblScreen.Location = new System.Drawing.Point(5, 60);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(329, 44);
            this.lblScreen.TabIndex = 5;
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClearDigit
            // 
            this.btnClearDigit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearDigit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearDigit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearDigit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearDigit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearDigit.ForeColor = System.Drawing.Color.White;
            this.btnClearDigit.Image = global::Calculadora.Properties.Resources.Clear_Symbol;
            this.btnClearDigit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClearDigit.Location = new System.Drawing.Point(173, 3);
            this.btnClearDigit.Name = "btnClearDigit";
            this.btnClearDigit.Size = new System.Drawing.Size(78, 64);
            this.btnClearDigit.TabIndex = 2;
            this.btnClearDigit.Click += new System.EventHandler(this.btnClearDigit_Click);
            // 
            // pictureExit
            // 
            this.pictureExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureExit.Image = global::Calculadora.Properties.Resources.Close;
            this.pictureExit.Location = new System.Drawing.Point(302, 6);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(29, 28);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExit.TabIndex = 1;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureExit.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureExit.MouseLeave += new System.EventHandler(this.pictureExit_MouseLeave);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(338, 535);
            this.Controls.Add(this.lblScreen);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHead;
        private Guna.UI2.WinForms.Guna2Panel panelFooter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCE;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnClear;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnClearDigit;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDivision;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNumber7;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNumber8;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNumber9;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnMultiply;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNumber4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNumber5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNumber6;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSubtract;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNumber1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNumber2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNumber3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSum;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNegative;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNumber0;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnComma;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnEqual;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureExit;
    }
}

