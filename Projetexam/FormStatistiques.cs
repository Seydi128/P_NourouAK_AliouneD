using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ClosedXML.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace Projetexam
{
    public partial class FormStatistiques : Form
    {

        private DBpro db;

        public FormStatistiques()
        {
           InitializeComponent();
            db = new DBpro();
            ChargerStatistiques();
        }
        private void ChargerStatistiques()
        {
            ChargerNombreEmargementsParProfesseur();
            ChargerEvolutionEmargements();
            ChargerTauxPresenceParCours();
        }

        private void ChargerNombreEmargementsParProfesseur()
        {
            var data = db.Emargements
                .GroupBy(e => e.Professeur.Nom)
                .Select(g => new { Professeur = g.Key, Nombre = g.Count() })
                .OrderByDescending(g => g.Nombre)
                .ToList();

            crtNEP.Series.Clear();
            Series serie = new Series("Nombre d'émargements")
            {
                ChartType = SeriesChartType.Column
            };

            foreach (var item in data)
            {
                serie.Points.AddXY(item.Professeur, item.Nombre);
            }

            crtNEP.Series.Add(serie);
        }
        private void ChargerEvolutionEmargements()
        {
            var data = db.Emargements
                .Where(e => e.DateEmargement.HasValue) // ✅ Ignore les dates nulles
                .AsEnumerable() // ✅ Convertit les résultats en mémoire pour utiliser .Date
                .GroupBy(e => e.DateEmargement.Value.Date) // ✅ Maintenant .Date fonctionne
                .Select(g => new { Date = g.Key, Nombre = g.Count() })
                .OrderBy(g => g.Date)
                .ToList();

            crtEE.Series.Clear();
            Series serie = new Series("Évolution des émargements")
            {
                ChartType = SeriesChartType.Line
            };

            foreach (var item in data)
            {
                serie.Points.AddXY(item.Date.ToShortDateString(), item.Nombre);
            }

            crtEE.Series.Add(serie);
        }



        private void ChargerTauxPresenceParCours()
        {
            var total = db.Emargements.Count();
            var data = db.Emargements
                .GroupBy(e => e.Cours.Nom)
                .Select(g => new { Cours = g.Key, Taux = (double)g.Count() / total * 100 })
                .ToList();

            crtTPC.Series.Clear();
            Series serie = new Series("Taux de Présence")
            {
                ChartType = SeriesChartType.Doughnut
            };

            foreach (var item in data)
            {
                serie.Points.AddXY(item.Cours, item.Taux);
            }

            crtTPC.Series.Add(serie);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = db.GetEmargements();

            if (dt.Rows.Count > 0)
            {
                ExportToExcel(dt); // ✅ Assurez-vous que cette méthode existe !
                ExportToPDF(dt);   // ✅ Assurez-vous que cette méthode existe !
                MessageBox.Show("Exportation réussie !");
            }
            else
            {
                MessageBox.Show("Aucune donnée trouvée !");
            }
        }

        private void ExportToExcel(DataTable dt)
        {
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Emargement");
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Emargement.xlsx");
                wb.SaveAs(filePath);
            }
        }

        private void ExportToPDF(DataTable dt)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Emargement.pdf");

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            foreach (DataColumn col in dt.Columns)
            {
                table.AddCell(new Phrase(col.ColumnName));
            }

            foreach (DataRow row in dt.Rows)
            {
                foreach (object cell in row.ItemArray)
                {
                    table.AddCell(cell.ToString());
                }
            }

            document.Add(table);
            document.Close();
        }

       
    }
}
        
