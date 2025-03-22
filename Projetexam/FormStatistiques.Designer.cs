namespace Projetexam
{
    partial class FormStatistiques
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.crtNEP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crtEE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crtTPC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crtNEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtEE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtTPC)).BeginInit();
            this.SuspendLayout();
            // 
            // crtNEP
            // 
            this.crtNEP.BackColor = System.Drawing.Color.Transparent;
            this.crtNEP.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.crtNEP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtNEP.Legends.Add(legend1);
            this.crtNEP.Location = new System.Drawing.Point(23, 12);
            this.crtNEP.Name = "crtNEP";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.crtNEP.Series.Add(series1);
            this.crtNEP.Size = new System.Drawing.Size(407, 391);
            this.crtNEP.TabIndex = 0;
            this.crtNEP.Text = "chart1";
            // 
            // crtEE
            // 
            this.crtEE.BackColor = System.Drawing.Color.Transparent;
            this.crtEE.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.crtEE.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.crtEE.Legends.Add(legend2);
            this.crtEE.Location = new System.Drawing.Point(455, 12);
            this.crtEE.Name = "crtEE";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.crtEE.Series.Add(series2);
            this.crtEE.Size = new System.Drawing.Size(470, 391);
            this.crtEE.TabIndex = 1;
            this.crtEE.Text = "chart2";
            // 
            // crtTPC
            // 
            this.crtTPC.BackColor = System.Drawing.Color.Transparent;
            this.crtTPC.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.crtTPC.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.crtTPC.Legends.Add(legend3);
            this.crtTPC.Location = new System.Drawing.Point(966, 12);
            this.crtTPC.Name = "crtTPC";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.crtTPC.Series.Add(series3);
            this.crtTPC.Size = new System.Drawing.Size(460, 391);
            this.crtTPC.TabIndex = 2;
            this.crtTPC.Text = "chart3";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Lime;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold);
            this.btnExport.Location = new System.Drawing.Point(506, 489);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(398, 55);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Exportation PDF ET EXCEL";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Emargements par Professeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(557, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Evolution des Emargements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1024, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Taux de Presences par Cour";
            // 
            // FormStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1466, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.crtTPC);
            this.Controls.Add(this.crtEE);
            this.Controls.Add(this.crtNEP);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormStatistiques";
            this.Text = "FormStatistiques";
            ((System.ComponentModel.ISupportInitialize)(this.crtNEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtEE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtTPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtNEP;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtEE;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtTPC;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}