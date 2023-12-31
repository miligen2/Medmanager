﻿namespace Medmanager
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationMédicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentParFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutMédicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeConsultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterConsultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentsToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "navbar";
            // 
            // medicamentsToolStripMenuItem
            // 
            this.medicamentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationMédicamentToolStripMenuItem,
            this.medicamentParFamilleToolStripMenuItem,
            this.ajoutMédicamentsToolStripMenuItem});
            this.medicamentsToolStripMenuItem.Name = "medicamentsToolStripMenuItem";
            this.medicamentsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.medicamentsToolStripMenuItem.Text = "Medicaments";
            // 
            // consultationMédicamentToolStripMenuItem
            // 
            this.consultationMédicamentToolStripMenuItem.Name = "consultationMédicamentToolStripMenuItem";
            this.consultationMédicamentToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.consultationMédicamentToolStripMenuItem.Text = "Consultation / modification Médicament";
            this.consultationMédicamentToolStripMenuItem.Click += new System.EventHandler(this.consultationMédicamentToolStripMenuItem_Click);
            // 
            // medicamentParFamilleToolStripMenuItem
            // 
            this.medicamentParFamilleToolStripMenuItem.Name = "medicamentParFamilleToolStripMenuItem";
            this.medicamentParFamilleToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.medicamentParFamilleToolStripMenuItem.Text = "Medicament par Famille";
            this.medicamentParFamilleToolStripMenuItem.Click += new System.EventHandler(this.medicamentParFamilleToolStripMenuItem_Click);
            // 
            // ajoutMédicamentsToolStripMenuItem
            // 
            this.ajoutMédicamentsToolStripMenuItem.Name = "ajoutMédicamentsToolStripMenuItem";
            this.ajoutMédicamentsToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.ajoutMédicamentsToolStripMenuItem.Text = "Ajouter Médicaments";
            this.ajoutMédicamentsToolStripMenuItem.Click += new System.EventHandler(this.ajoutMédicamentsToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterPatientToolStripMenuItem,
            this.ajouterPatientToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // consulterPatientToolStripMenuItem
            // 
            this.consulterPatientToolStripMenuItem.Name = "consulterPatientToolStripMenuItem";
            this.consulterPatientToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.consulterPatientToolStripMenuItem.Text = "Consulter / Modifier Patient";
            this.consulterPatientToolStripMenuItem.Click += new System.EventHandler(this.consulterPatientToolStripMenuItem_Click);
            // 
            // ajouterPatientToolStripMenuItem
            // 
            this.ajouterPatientToolStripMenuItem.Name = "ajouterPatientToolStripMenuItem";
            this.ajouterPatientToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ajouterPatientToolStripMenuItem.Text = "Ajouter Patient";
            this.ajouterPatientToolStripMenuItem.Click += new System.EventHandler(this.ajouterPatientToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeConsultationToolStripMenuItem,
            this.ajouterConsultationToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // listeConsultationToolStripMenuItem
            // 
            this.listeConsultationToolStripMenuItem.Name = "listeConsultationToolStripMenuItem";
            this.listeConsultationToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.listeConsultationToolStripMenuItem.Text = "Liste / Modifier Consultation";
            this.listeConsultationToolStripMenuItem.Click += new System.EventHandler(this.listeConsultationToolStripMenuItem_Click);
            // 
            // ajouterConsultationToolStripMenuItem
            // 
            this.ajouterConsultationToolStripMenuItem.Name = "ajouterConsultationToolStripMenuItem";
            this.ajouterConsultationToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.ajouterConsultationToolStripMenuItem.Text = "Ajouter Consultation";
            this.ajouterConsultationToolStripMenuItem.Click += new System.EventHandler(this.ajouterConsultationToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(105, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 113);
            this.label1.TabIndex = 1;
            this.label1.Text = "MedManager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de patient : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(637, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "nombre de consultation :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(795, 558);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = " MedManager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationMédicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentParFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutMédicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeConsultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterConsultationToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

