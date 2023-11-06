namespace Medmanager
{
    partial class AConsultation
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
            this.LMatricule = new System.Windows.Forms.Label();
            this.LDateConsult = new System.Windows.Forms.Label();
            this.LtypeConsult = new System.Windows.Forms.Label();
            this.LCommentaire = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LMatricule
            // 
            this.LMatricule.AutoSize = true;
            this.LMatricule.Location = new System.Drawing.Point(74, 62);
            this.LMatricule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LMatricule.Name = "LMatricule";
            this.LMatricule.Size = new System.Drawing.Size(41, 13);
            this.LMatricule.TabIndex = 0;
            this.LMatricule.Text = "Avec : ";
            this.LMatricule.Click += new System.EventHandler(this.label1_Click);
            // 
            // LDateConsult
            // 
            this.LDateConsult.AutoSize = true;
            this.LDateConsult.Location = new System.Drawing.Point(74, 214);
            this.LDateConsult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDateConsult.Name = "LDateConsult";
            this.LDateConsult.Size = new System.Drawing.Size(122, 13);
            this.LDateConsult.TabIndex = 1;
            this.LDateConsult.Text = "Date de la consultation :";
            this.LDateConsult.Click += new System.EventHandler(this.label2_Click);
            // 
            // LtypeConsult
            // 
            this.LtypeConsult.AutoSize = true;
            this.LtypeConsult.Location = new System.Drawing.Point(74, 183);
            this.LtypeConsult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LtypeConsult.Name = "LtypeConsult";
            this.LtypeConsult.Size = new System.Drawing.Size(109, 13);
            this.LtypeConsult.TabIndex = 2;
            this.LtypeConsult.Text = "Type De Consultation";
            this.LtypeConsult.Click += new System.EventHandler(this.label3_Click);
            // 
            // LCommentaire
            // 
            this.LCommentaire.AutoSize = true;
            this.LCommentaire.Location = new System.Drawing.Point(74, 254);
            this.LCommentaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCommentaire.Name = "LCommentaire";
            this.LCommentaire.Size = new System.Drawing.Size(68, 13);
            this.LCommentaire.TabIndex = 3;
            this.LCommentaire.Text = "Commentaire";
            this.LCommentaire.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 254);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 116);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(316, 213);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(224, 20);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(316, 178);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonValider.Location = new System.Drawing.Point(76, 394);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(76, 37);
            this.buttonValider.TabIndex = 9;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.DarkRed;
            this.buttonAnnuler.Location = new System.Drawing.Point(190, 394);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(76, 37);
            this.buttonAnnuler.TabIndex = 10;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(316, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 95);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(604, 507);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LCommentaire);
            this.Controls.Add(this.LtypeConsult);
            this.Controls.Add(this.LDateConsult);
            this.Controls.Add(this.LMatricule);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AConsultation";
            this.Text = "MedManager - Ajouter une consultation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LMatricule;
        private System.Windows.Forms.Label LDateConsult;
        private System.Windows.Forms.Label LtypeConsult;
        private System.Windows.Forms.Label LCommentaire;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ListBox listBox1;
    }
}