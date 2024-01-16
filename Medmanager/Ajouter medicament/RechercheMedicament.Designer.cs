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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RechercheMedicament));
            this.comboBoxFamilies = new System.Windows.Forms.ComboBox();
            this.dataGridViewMedicaments = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1069, 573);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // RechercheMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 619);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewMedicaments);
            this.Controls.Add(this.comboBoxFamilies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RechercheMedicament";
            this.Text = "Medmanager - Rechercher un medicament";
            this.Load += new System.EventHandler(this.RechercheMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFamilies;
        private System.Windows.Forms.DataGridView dataGridViewMedicaments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}