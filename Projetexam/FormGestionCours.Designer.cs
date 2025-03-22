namespace Projetexam
{
    partial class FormGestionCours
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpDateCours = new System.Windows.Forms.DateTimePicker();
            this.dtpHeureDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpHeureFin = new System.Windows.Forms.DateTimePicker();
            this.cmbSalle = new System.Windows.Forms.ComboBox();
            this.cmbProfesseur = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btmEffacer = new System.Windows.Forms.Button();
            this.dgvCours = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCours)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du Cour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(333, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date du Cour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(11, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Heure Debut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(11, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Heure Fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(370, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(344, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Professeur";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtNom.Location = new System.Drawing.Point(17, 31);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(169, 28);
            this.txtNom.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtDescription.Location = new System.Drawing.Point(306, 31);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(169, 28);
            this.txtDescription.TabIndex = 8;
            // 
            // dtpDateCours
            // 
            this.dtpDateCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateCours.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateCours.Location = new System.Drawing.Point(15, 96);
            this.dtpDateCours.Name = "dtpDateCours";
            this.dtpDateCours.Size = new System.Drawing.Size(169, 34);
            this.dtpDateCours.TabIndex = 9;
            // 
            // dtpHeureDebut
            // 
            this.dtpHeureDebut.CustomFormat = "HH:mm";
            this.dtpHeureDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHeureDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHeureDebut.Location = new System.Drawing.Point(12, 198);
            this.dtpHeureDebut.Name = "dtpHeureDebut";
            this.dtpHeureDebut.ShowUpDown = true;
            this.dtpHeureDebut.Size = new System.Drawing.Size(93, 34);
            this.dtpHeureDebut.TabIndex = 10;
            // 
            // dtpHeureFin
            // 
            this.dtpHeureFin.CustomFormat = "HH:mm";
            this.dtpHeureFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHeureFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHeureFin.Location = new System.Drawing.Point(12, 274);
            this.dtpHeureFin.Name = "dtpHeureFin";
            this.dtpHeureFin.ShowUpDown = true;
            this.dtpHeureFin.Size = new System.Drawing.Size(93, 34);
            this.dtpHeureFin.TabIndex = 11;
            // 
            // cmbSalle
            // 
            this.cmbSalle.FormattingEnabled = true;
            this.cmbSalle.Location = new System.Drawing.Point(306, 96);
            this.cmbSalle.Name = "cmbSalle";
            this.cmbSalle.Size = new System.Drawing.Size(160, 24);
            this.cmbSalle.TabIndex = 12;
            // 
            // cmbProfesseur
            // 
            this.cmbProfesseur.FormattingEnabled = true;
            this.cmbProfesseur.Location = new System.Drawing.Point(306, 171);
            this.cmbProfesseur.Name = "cmbProfesseur";
            this.cmbProfesseur.Size = new System.Drawing.Size(160, 24);
            this.cmbProfesseur.TabIndex = 13;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Blue;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnAjouter.Location = new System.Drawing.Point(26, 337);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(135, 38);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Lime;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnModifier.Location = new System.Drawing.Point(326, 416);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(140, 38);
            this.btnModifier.TabIndex = 15;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnSupprimer.Location = new System.Drawing.Point(26, 416);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(140, 38);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btmEffacer
            // 
            this.btmEffacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btmEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btmEffacer.Location = new System.Drawing.Point(326, 337);
            this.btmEffacer.Name = "btmEffacer";
            this.btmEffacer.Size = new System.Drawing.Size(140, 38);
            this.btmEffacer.TabIndex = 17;
            this.btmEffacer.Text = "Effacer";
            this.btmEffacer.UseVisualStyleBackColor = false;
            this.btmEffacer.Click += new System.EventHandler(this.btmEffacer_Click);
            // 
            // dgvCours
            // 
            this.dgvCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCours.Location = new System.Drawing.Point(524, 48);
            this.dgvCours.Name = "dgvCours";
            this.dgvCours.RowHeadersWidth = 51;
            this.dgvCours.RowTemplate.Height = 24;
            this.dgvCours.Size = new System.Drawing.Size(880, 498);
            this.dgvCours.TabIndex = 18;
            this.dgvCours.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCours_CellMouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label8.Location = new System.Drawing.Point(866, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 39);
            this.label8.TabIndex = 19;
            this.label8.Text = "Liste des Cours";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btmEffacer);
            this.panel1.Controls.Add(this.dtpDateCours);
            this.panel1.Controls.Add(this.dtpHeureDebut);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbProfesseur);
            this.panel1.Controls.Add(this.dtpHeureFin);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbSalle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 487);
            this.panel1.TabIndex = 20;
            // 
            // FormGestionCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvCours);
            this.Name = "FormGestionCours";
            this.Text = "FormGestionCours";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCours)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDateCours;
        private System.Windows.Forms.DateTimePicker dtpHeureDebut;
        private System.Windows.Forms.DateTimePicker dtpHeureFin;
        private System.Windows.Forms.ComboBox cmbSalle;
        private System.Windows.Forms.ComboBox cmbProfesseur;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btmEffacer;
        private System.Windows.Forms.DataGridView dgvCours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
    }
}