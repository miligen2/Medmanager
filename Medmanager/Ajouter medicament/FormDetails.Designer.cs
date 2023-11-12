namespace Medmanager
{
    partial class FormDetails
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.numericUpDownPrix = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQuantité = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.suppr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantité)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 83);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 160);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 167);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonValider.Location = new System.Drawing.Point(293, 228);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(76, 37);
            this.buttonValider.TabIndex = 12;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // numericUpDownPrix
            // 
            this.numericUpDownPrix.Location = new System.Drawing.Point(70, 463);
            this.numericUpDownPrix.Name = "numericUpDownPrix";
            this.numericUpDownPrix.Size = new System.Drawing.Size(199, 20);
            this.numericUpDownPrix.TabIndex = 13;
            this.numericUpDownPrix.ValueChanged += new System.EventHandler(this.numericUpDownPrix_ValueChanged);
            // 
            // numericUpDownQuantité
            // 
            this.numericUpDownQuantité.Location = new System.Drawing.Point(71, 397);
            this.numericUpDownQuantité.Name = "numericUpDownQuantité";
            this.numericUpDownQuantité.Size = new System.Drawing.Size(199, 20);
            this.numericUpDownQuantité.TabIndex = 14;
            this.numericUpDownQuantité.ValueChanged += new System.EventHandler(this.numericUpDownQuantité_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantité : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Prix :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // suppr
            // 
            this.suppr.Location = new System.Drawing.Point(293, 279);
            this.suppr.Name = "suppr";
            this.suppr.Size = new System.Drawing.Size(75, 37);
            this.suppr.TabIndex = 17;
            this.suppr.Text = "Supprimer";
            this.suppr.UseVisualStyleBackColor = true;
            this.suppr.Click += new System.EventHandler(this.suppr_Click);
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 602);
            this.Controls.Add(this.suppr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownQuantité);
            this.Controls.Add(this.numericUpDownPrix);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDetails";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantité)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.NumericUpDown numericUpDownPrix;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantité;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button suppr;
    }
}