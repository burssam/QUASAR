﻿using System;

namespace WindowsFormsApplication3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LBLinst = new System.Windows.Forms.Label();
            this.LBLtitle = new System.Windows.Forms.Label();
            this.BUTstart = new System.Windows.Forms.Button();
            this.BUTbet = new System.Windows.Forms.Button();
            this.BUTstay = new System.Windows.Forms.Button();
            this.BUT47 = new System.Windows.Forms.Button();
            this.BUT18 = new System.Windows.Forms.Button();
            this.NUDbet = new System.Windows.Forms.NumericUpDown();
            this.TBsum = new System.Windows.Forms.TextBox();
            this.TB18 = new System.Windows.Forms.TextBox();
            this.TB47 = new System.Windows.Forms.TextBox();
            this.TBsingle = new System.Windows.Forms.TextBox();
            this.TBmulti = new System.Windows.Forms.TextBox();
            this.LBLsingle = new System.Windows.Forms.Label();
            this.LBLmulti = new System.Windows.Forms.Label();
            this.BUTnumplay = new System.Windows.Forms.Button();
            this.LBLstupid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDbet)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLinst
            // 
            this.LBLinst.AutoSize = true;
            this.LBLinst.BackColor = System.Drawing.Color.Lime;
            this.LBLinst.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLinst.Location = new System.Drawing.Point(35, 116);
            this.LBLinst.Name = "LBLinst";
            this.LBLinst.Size = new System.Drawing.Size(621, 209);
            this.LBLinst.TabIndex = 0;
            this.LBLinst.Text = resources.GetString("LBLinst.Text");
            // 
            // LBLtitle
            // 
            this.LBLtitle.AutoSize = true;
            this.LBLtitle.BackColor = System.Drawing.Color.Lime;
            this.LBLtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtitle.ForeColor = System.Drawing.Color.Blue;
            this.LBLtitle.Location = new System.Drawing.Point(228, 9);
            this.LBLtitle.Name = "LBLtitle";
            this.LBLtitle.Size = new System.Drawing.Size(227, 55);
            this.LBLtitle.TabIndex = 1;
            this.LBLtitle.Text = "QUASAR";
            // 
            // BUTstart
            // 
            this.BUTstart.BackColor = System.Drawing.Color.Lime;
            this.BUTstart.Location = new System.Drawing.Point(238, 335);
            this.BUTstart.Name = "BUTstart";
            this.BUTstart.Size = new System.Drawing.Size(231, 62);
            this.BUTstart.TabIndex = 2;
            this.BUTstart.Text = "Begin!";
            this.BUTstart.UseVisualStyleBackColor = false;
            this.BUTstart.Click += new System.EventHandler(this.BUTstart_Click);
            // 
            // BUTbet
            // 
            this.BUTbet.BackColor = System.Drawing.Color.Lime;
            this.BUTbet.Location = new System.Drawing.Point(263, 264);
            this.BUTbet.Name = "BUTbet";
            this.BUTbet.Size = new System.Drawing.Size(140, 23);
            this.BUTbet.TabIndex = 3;
            this.BUTbet.Text = "Place your bet!";
            this.BUTbet.UseVisualStyleBackColor = false;
            this.BUTbet.Click += new System.EventHandler(this.BUTbet_Click_1);
            // 
            // BUTstay
            // 
            this.BUTstay.BackColor = System.Drawing.Color.Lime;
            this.BUTstay.Location = new System.Drawing.Point(294, 90);
            this.BUTstay.Name = "BUTstay";
            this.BUTstay.Size = new System.Drawing.Size(75, 23);
            this.BUTstay.TabIndex = 4;
            this.BUTstay.Text = "Stop Rolling";
            this.BUTstay.UseVisualStyleBackColor = false;
            // 
            // BUT47
            // 
            this.BUT47.BackColor = System.Drawing.Color.Lime;
            this.BUT47.Location = new System.Drawing.Point(546, 47);
            this.BUT47.Name = "BUT47";
            this.BUT47.Size = new System.Drawing.Size(75, 23);
            this.BUT47.TabIndex = 5;
            this.BUT47.Text = "Roll 4 - 7";
            this.BUT47.UseVisualStyleBackColor = false;
            // 
            // BUT18
            // 
            this.BUT18.BackColor = System.Drawing.Color.Lime;
            this.BUT18.Location = new System.Drawing.Point(59, 47);
            this.BUT18.Name = "BUT18";
            this.BUT18.Size = new System.Drawing.Size(75, 23);
            this.BUT18.TabIndex = 6;
            this.BUT18.Text = "Roll 1 - 8";
            this.BUT18.UseVisualStyleBackColor = false;
            // 
            // NUDbet
            // 
            this.NUDbet.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDbet.Location = new System.Drawing.Point(274, 227);
            this.NUDbet.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUDbet.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDbet.Name = "NUDbet";
            this.NUDbet.Size = new System.Drawing.Size(120, 20);
            this.NUDbet.TabIndex = 7;
            this.NUDbet.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // TBsum
            // 
            this.TBsum.Location = new System.Drawing.Point(283, 171);
            this.TBsum.Name = "TBsum";
            this.TBsum.Size = new System.Drawing.Size(100, 20);
            this.TBsum.TabIndex = 8;
            // 
            // TB18
            // 
            this.TB18.Location = new System.Drawing.Point(48, 76);
            this.TB18.Name = "TB18";
            this.TB18.Size = new System.Drawing.Size(100, 20);
            this.TB18.TabIndex = 9;
            // 
            // TB47
            // 
            this.TB47.Location = new System.Drawing.Point(535, 76);
            this.TB47.Name = "TB47";
            this.TB47.Size = new System.Drawing.Size(100, 20);
            this.TB47.TabIndex = 10;
            // 
            // TBsingle
            // 
            this.TBsingle.Location = new System.Drawing.Point(28, 129);
            this.TBsingle.Multiline = true;
            this.TBsingle.Name = "TBsingle";
            this.TBsingle.Size = new System.Drawing.Size(188, 92);
            this.TBsingle.TabIndex = 11;
            this.TBsingle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TBmulti
            // 
            this.TBmulti.Location = new System.Drawing.Point(474, 129);
            this.TBmulti.Multiline = true;
            this.TBmulti.Name = "TBmulti";
            this.TBmulti.Size = new System.Drawing.Size(188, 92);
            this.TBmulti.TabIndex = 12;
            this.TBmulti.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LBLsingle
            // 
            this.LBLsingle.AutoSize = true;
            this.LBLsingle.Location = new System.Drawing.Point(45, 229);
            this.LBLsingle.Name = "LBLsingle";
            this.LBLsingle.Size = new System.Drawing.Size(160, 13);
            this.LBLsingle.TabIndex = 13;
            this.LBLsingle.Text = "Enter your name for single player";
            // 
            // LBLmulti
            // 
            this.LBLmulti.AutoSize = true;
            this.LBLmulti.Location = new System.Drawing.Point(442, 224);
            this.LBLmulti.Name = "LBLmulti";
            this.LBLmulti.Size = new System.Drawing.Size(234, 26);
            this.LBLmulti.TabIndex = 14;
            this.LBLmulti.Text = "Enter all players\' names, each on a different line,\r\n for multiple players";
            // 
            // BUTnumplay
            // 
            this.BUTnumplay.Location = new System.Drawing.Point(233, 293);
            this.BUTnumplay.Name = "BUTnumplay";
            this.BUTnumplay.Size = new System.Drawing.Size(222, 53);
            this.BUTnumplay.TabIndex = 15;
            this.BUTnumplay.Text = "Proceed to bet making!";
            this.BUTnumplay.UseVisualStyleBackColor = true;
            this.BUTnumplay.Click += new System.EventHandler(this.BUTnumplay_Click);
            // 
            // LBLstupid
            // 
            this.LBLstupid.AutoSize = true;
            this.LBLstupid.Location = new System.Drawing.Point(206, 208);
            this.LBLstupid.Name = "LBLstupid";
            this.LBLstupid.Size = new System.Drawing.Size(276, 13);
            this.LBLstupid.TabIndex = 16;
            this.LBLstupid.Text = "You MUST enter a name or names into one of the boxes!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 409);
            this.Controls.Add(this.LBLstupid);
            this.Controls.Add(this.BUTnumplay);
            this.Controls.Add(this.LBLmulti);
            this.Controls.Add(this.LBLsingle);
            this.Controls.Add(this.TBmulti);
            this.Controls.Add(this.TBsingle);
            this.Controls.Add(this.TB47);
            this.Controls.Add(this.TB18);
            this.Controls.Add(this.TBsum);
            this.Controls.Add(this.NUDbet);
            this.Controls.Add(this.BUT18);
            this.Controls.Add(this.BUT47);
            this.Controls.Add(this.BUTstay);
            this.Controls.Add(this.BUTbet);
            this.Controls.Add(this.BUTstart);
            this.Controls.Add(this.LBLtitle);
            this.Controls.Add(this.LBLinst);
            this.Name = "Form1";
            this.Text = "QUASAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDbet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label LBLinst;
        private System.Windows.Forms.Label LBLtitle;
        private System.Windows.Forms.Button BUTstart;
        private System.Windows.Forms.Button BUTbet;
        private System.Windows.Forms.Button BUTstay;
        private System.Windows.Forms.Button BUT47;
        private System.Windows.Forms.Button BUT18;
        private System.Windows.Forms.NumericUpDown NUDbet;
        private System.Windows.Forms.TextBox TBsum;
        private System.Windows.Forms.TextBox TB18;
        private System.Windows.Forms.TextBox TB47;
        private System.Windows.Forms.TextBox TBsingle;
        private System.Windows.Forms.TextBox TBmulti;
        private System.Windows.Forms.Label LBLsingle;
        private System.Windows.Forms.Label LBLmulti;
        private System.Windows.Forms.Button BUTnumplay;
        private System.Windows.Forms.Label LBLstupid;
    }
}

