namespace Medmanager
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationMédicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentParFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutMédicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerMédicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeConsultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterConsultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerConsultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1060, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "navbar";
            // 
            // medicamentsToolStripMenuItem
            // 
            this.medicamentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationMédicamentToolStripMenuItem,
            this.medicamentParFamilleToolStripMenuItem,
            this.ajoutMédicamentsToolStripMenuItem,
            this.supprimerMédicamentToolStripMenuItem});
            this.medicamentsToolStripMenuItem.Name = "medicamentsToolStripMenuItem";
            this.medicamentsToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.medicamentsToolStripMenuItem.Text = "Medicaments";
            // 
            // consultationMédicamentToolStripMenuItem
            // 
            this.consultationMédicamentToolStripMenuItem.Name = "consultationMédicamentToolStripMenuItem";
            this.consultationMédicamentToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.consultationMédicamentToolStripMenuItem.Text = "Consultation Médicament";
            this.consultationMédicamentToolStripMenuItem.Click += new System.EventHandler(this.consultationMédicamentToolStripMenuItem_Click);
            // 
            // medicamentParFamilleToolStripMenuItem
            // 
            this.medicamentParFamilleToolStripMenuItem.Name = "medicamentParFamilleToolStripMenuItem";
            this.medicamentParFamilleToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.medicamentParFamilleToolStripMenuItem.Text = "Medicament par Famille";
            // 
            // ajoutMédicamentsToolStripMenuItem
            // 
            this.ajoutMédicamentsToolStripMenuItem.Name = "ajoutMédicamentsToolStripMenuItem";
            this.ajoutMédicamentsToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.ajoutMédicamentsToolStripMenuItem.Text = "Ajout Médicaments";
            // 
            // supprimerMédicamentToolStripMenuItem
            // 
            this.supprimerMédicamentToolStripMenuItem.Name = "supprimerMédicamentToolStripMenuItem";
            this.supprimerMédicamentToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.supprimerMédicamentToolStripMenuItem.Text = "Supprimer Médicament";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterPatientToolStripMenuItem,
            this.ajouterPatientToolStripMenuItem,
            this.supprimerPatientToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // consulterPatientToolStripMenuItem
            // 
            this.consulterPatientToolStripMenuItem.Name = "consulterPatientToolStripMenuItem";
            this.consulterPatientToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.consulterPatientToolStripMenuItem.Text = "Consulter Patient";
            // 
            // ajouterPatientToolStripMenuItem
            // 
            this.ajouterPatientToolStripMenuItem.Name = "ajouterPatientToolStripMenuItem";
            this.ajouterPatientToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.ajouterPatientToolStripMenuItem.Text = "Ajouter Patient";
            // 
            // supprimerPatientToolStripMenuItem
            // 
            this.supprimerPatientToolStripMenuItem.Name = "supprimerPatientToolStripMenuItem";
            this.supprimerPatientToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.supprimerPatientToolStripMenuItem.Text = "Supprimer Patient";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeConsultationToolStripMenuItem,
            this.ajouterConsultationToolStripMenuItem,
            this.supprimerConsultationToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // listeConsultationToolStripMenuItem
            // 
            this.listeConsultationToolStripMenuItem.Name = "listeConsultationToolStripMenuItem";
            this.listeConsultationToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.listeConsultationToolStripMenuItem.Text = "Liste Consultation";
            // 
            // ajouterConsultationToolStripMenuItem
            // 
            this.ajouterConsultationToolStripMenuItem.Name = "ajouterConsultationToolStripMenuItem";
            this.ajouterConsultationToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.ajouterConsultationToolStripMenuItem.Text = "Ajouter Consultation";
            // 
            // supprimerConsultationToolStripMenuItem
            // 
            this.supprimerConsultationToolStripMenuItem.Name = "supprimerConsultationToolStripMenuItem";
            this.supprimerConsultationToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.supprimerConsultationToolStripMenuItem.Text = "Supprimer Consultation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(131, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 142);
            this.label1.TabIndex = 1;
            this.label1.Text = "MedManager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1060, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem supprimerMédicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeConsultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterConsultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerConsultationToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

