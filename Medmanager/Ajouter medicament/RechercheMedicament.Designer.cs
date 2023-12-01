namespace Medmanager.Ajouter_medicament
{
    partial class RechercheMedicament
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
            this.comboBoxFamilies = new System.Windows.Forms.ComboBox();
            this.dataGridViewMedicaments = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicaments)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFamilies
            // 
            this.comboBoxFamilies.FormattingEnabled = true;
            this.comboBoxFamilies.Location = new System.Drawing.Point(36, 76);
            this.comboBoxFamilies.Name = "comboBoxFamilies";
            this.comboBoxFamilies.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFamilies.TabIndex = 0;
            this.comboBoxFamilies.SelectedIndexChanged += new System.EventHandler(this.comboBoxFamilies_SelectedIndexChanged);
            // 
            // dataGridViewMedicaments
            // 
            this.dataGridViewMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicaments.Location = new System.Drawing.Point(246, 76);
            this.dataGridViewMedicaments.Name = "dataGridViewMedicaments";
            this.dataGridViewMedicaments.Size = new System.Drawing.Size(760, 482);
            this.dataGridViewMedicaments.TabIndex = 1;
            this.dataGridViewMedicaments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicaments_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(1031, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RechercheMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewMedicaments);
            this.Controls.Add(this.comboBoxFamilies);
            this.Name = "RechercheMedicament";
            this.Text = "Medmanager - Rechercher un medicament";
            this.Load += new System.EventHandler(this.RechercheMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicaments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFamilies;
        private System.Windows.Forms.DataGridView dataGridViewMedicaments;
        private System.Windows.Forms.Button button1;
    }
}