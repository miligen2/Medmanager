namespace Medmanager.Ajouter_Consultation
{
    partial class FormConsultation
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LtypeConsult = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LCommentaire = new System.Windows.Forms.Label();
            this.LDateConsult = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(162, 153);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // LtypeConsult
            // 
            this.LtypeConsult.AutoSize = true;
            this.LtypeConsult.Location = new System.Drawing.Point(30, 156);
            this.LtypeConsult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LtypeConsult.Name = "LtypeConsult";
            this.LtypeConsult.Size = new System.Drawing.Size(109, 13);
            this.LtypeConsult.TabIndex = 9;
            this.LtypeConsult.Text = "Type De Consultation";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(162, 188);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(249, 20);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 234);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 116);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LCommentaire
            // 
            this.LCommentaire.AutoSize = true;
            this.LCommentaire.Location = new System.Drawing.Point(30, 234);
            this.LCommentaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCommentaire.Name = "LCommentaire";
            this.LCommentaire.Size = new System.Drawing.Size(68, 13);
            this.LCommentaire.TabIndex = 12;
            this.LCommentaire.Text = "Commentaire";
            // 
            // LDateConsult
            // 
            this.LDateConsult.AutoSize = true;
            this.LDateConsult.Location = new System.Drawing.Point(30, 194);
            this.LDateConsult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDateConsult.Name = "LDateConsult";
            this.LDateConsult.Size = new System.Drawing.Size(122, 13);
            this.LDateConsult.TabIndex = 11;
            this.LDateConsult.Text = "Date de la consultation :";
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonValider.Location = new System.Drawing.Point(588, 234);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(76, 37);
            this.buttonValider.TabIndex = 15;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // FormConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LCommentaire);
            this.Controls.Add(this.LDateConsult);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LtypeConsult);
            this.Name = "FormConsultation";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LtypeConsult;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LCommentaire;
        private System.Windows.Forms.Label LDateConsult;
        private System.Windows.Forms.Button buttonValider;
    }
}