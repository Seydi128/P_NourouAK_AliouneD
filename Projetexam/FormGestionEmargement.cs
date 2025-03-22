using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetexam
{
    public partial class FormGestionEmargement : Form
    {
        private DBpro db;
        private int professeurConnectedId;
        private int emargementId;
        public FormGestionEmargement(int userId)
        {
            InitializeComponent();
            db = new DBpro();
            professeurConnectedId = userId;
            Actualiser();
        }
        private void Actualiser()
        {

            // Définir la plage de dates (début et fin de la journée actuelle)
            DateTime aujourdHuiDebut = DateTime.Today; // 00:00:00
            DateTime aujourdHuiFin = aujourdHuiDebut.AddDays(1); // 00:00:00 du lendemain

            var historique = db.Emargements
                .Where(e => e.Cours != null) // Évite les erreurs si e.Cours est null
                .Where(e => e.ProfesseurId == professeurConnectedId) // Filtre par le professeur connecté
                .Where(e => e.Cours.DateCours >= aujourdHuiDebut && e.Cours.DateCours < aujourdHuiFin) // Comparer la plage
                .Select(e => new
                {
                    e.Id,
                    Cours = e.Cours.Nom,
                    e.DateEmargement,
                    Statu = e.EstPresent
                })
                .ToList();

            dgvEmargement.DataSource = historique;
        }


        private void btnEmarger_Click(object sender, EventArgs e)
        {
            if (emargementId == 0)
            {
                MessageBox.Show("Veuillez sélectionner un cours.");
                return;
            }

            var emargement = db.Emargements.Find(emargementId);
            if (emargement != null)
            {
                emargement.EstPresent = checkBox1.Checked ? "Présent" : "Absent";
                emargement.DateEmargement = DateTime.Now;
                db.SaveChanges();
                MessageBox.Show("Émargement mis à jour !");
                Actualiser();
                checkBox1.Checked = false;
                txtCours.Text = "";
            }

        }

        private void dgvEmargement_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvEmargement.Rows.Count)
            {
                emargementId = Convert.ToInt32(dgvEmargement.Rows[e.RowIndex].Cells["Id"].Value);
                txtCours.Text = dgvEmargement.Rows[e.RowIndex].Cells["Cours"].Value.ToString();
            }

        }

    }
}
