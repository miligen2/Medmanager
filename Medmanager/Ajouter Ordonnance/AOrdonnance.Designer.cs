﻿namespace Medmanager
{
    partial class AOrdonnance
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
            this.buttonValider = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Durée = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonValider.Location = new System.Drawing.Point(505, 495);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(101, 46);
            this.buttonValider.TabIndex = 9;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 85);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(433, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patient : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(661, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(513, 260);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(661, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Posologie :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(53, 193);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Durée
            // 
            this.Durée.AutoSize = true;
            this.Durée.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Durée.Location = new System.Drawing.Point(50, 144);
            this.Durée.Name = "Durée";
            this.Durée.Size = new System.Drawing.Size(65, 25);
            this.Durée.TabIndex = 16;
            this.Durée.Text = "Durée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "jour(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(661, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Instruction spécifique";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(661, 400);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(513, 72);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AOrdonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1281, 599);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Durée);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonValider);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AOrdonnance";
            this.Text = "MedManager - Ajouter une consultation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Durée;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}