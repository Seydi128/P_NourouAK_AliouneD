﻿namespace Projetexam
{
    partial class FormGestionEmargement
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
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.txtCours = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnEmarger = new System.Windows.Forms.Button();
            this.dgvEmargement = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmargement)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label1.Location = new System.Drawing.Point(80, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du Cour";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // txtCours
            // 
            this.txtCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtCours.Location = new System.Drawing.Point(37, 121);
            this.txtCours.Name = "txtCours";
            this.txtCours.Size = new System.Drawing.Size(268, 34);
            this.txtCours.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.checkBox1.Location = new System.Drawing.Point(175, 186);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 35);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Present";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnEmarger
            // 
            this.btnEmarger.BackColor = System.Drawing.Color.Lime;
            this.btnEmarger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.btnEmarger.Location = new System.Drawing.Point(110, 281);
            this.btnEmarger.Name = "btnEmarger";
            this.btnEmarger.Size = new System.Drawing.Size(130, 46);
            this.btnEmarger.TabIndex = 3;
            this.btnEmarger.Text = "Valider";
            this.btnEmarger.UseVisualStyleBackColor = false;
            this.btnEmarger.Click += new System.EventHandler(this.btnEmarger_Click);
            // 
            // dgvEmargement
            // 
            this.dgvEmargement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmargement.Location = new System.Drawing.Point(386, 13);
            this.dgvEmargement.Name = "dgvEmargement";
            this.dgvEmargement.RowHeadersWidth = 51;
            this.dgvEmargement.RowTemplate.Height = 24;
            this.dgvEmargement.Size = new System.Drawing.Size(740, 459);
            this.dgvEmargement.TabIndex = 4;
            this.dgvEmargement.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmargement_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCours);
            this.panel1.Controls.Add(this.btnEmarger);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 383);
            this.panel1.TabIndex = 5;
            // 
            // FormGestionEmargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmargement);
            this.Name = "FormGestionEmargement";
            this.Text = "FormGestionEmargement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmargement)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TextBox txtCours;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnEmarger;
        private System.Windows.Forms.DataGridView dgvEmargement;
        private System.Windows.Forms.Panel panel1;
    }
}