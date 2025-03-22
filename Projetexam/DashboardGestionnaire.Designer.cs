namespace Projetexam
{
    partial class DashboardGestionnaire
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnSalle = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCours = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnStatistiques);
            this.panel1.Controls.Add(this.btnSalle);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCours);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 549);
            this.panel1.TabIndex = 1;
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.BackColor = System.Drawing.Color.Red;
            this.btnStatistiques.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistiques.Location = new System.Drawing.Point(2, 388);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(252, 86);
            this.btnStatistiques.TabIndex = 4;
            this.btnStatistiques.Text = "STATISTIQUE";
            this.btnStatistiques.UseVisualStyleBackColor = false;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            // 
            // btnSalle
            // 
            this.btnSalle.BackColor = System.Drawing.Color.Blue;
            this.btnSalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalle.Location = new System.Drawing.Point(3, 251);
            this.btnSalle.Name = "btnSalle";
            this.btnSalle.Size = new System.Drawing.Size(252, 86);
            this.btnSalle.TabIndex = 3;
            this.btnSalle.Text = "GESTION SALLES";
            this.btnSalle.UseVisualStyleBackColor = false;
            this.btnSalle.Click += new System.EventHandler(this.btnSalle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projetexam.Properties.Resources.Téléchargez_Gratuitement_des_Vecteurs__Photos_et_Vidéos;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projetexam.Properties.Resources.Costas_ícones_em_vetor_livre_criados_por_Ilham_Fitrotul_Hayat;
            this.pictureBox1.Location = new System.Drawing.Point(90, 480);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCours
            // 
            this.btnCours.BackColor = System.Drawing.Color.Yellow;
            this.btnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCours.Location = new System.Drawing.Point(3, 112);
            this.btnCours.Name = "btnCours";
            this.btnCours.Size = new System.Drawing.Size(252, 86);
            this.btnCours.TabIndex = 0;
            this.btnCours.Text = "GESTION COURS";
            this.btnCours.UseVisualStyleBackColor = false;
            this.btnCours.Click += new System.EventHandler(this.btnCours_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Projetexam.Properties.Resources.Gestionnaire_de_fichiers__Triez_et_déplacez_votre_documentaire_vers_des_sous_dossiers_;
            this.pictureBox3.Location = new System.Drawing.Point(260, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(802, 546);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // DashboardGestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 547);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardGestionnaire";
            this.Text = "DashboardGestionnaire";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCours;
        private System.Windows.Forms.Button btnSalle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnStatistiques;
    }
}