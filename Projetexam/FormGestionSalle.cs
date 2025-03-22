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
    public partial class FormGestionSalle : Form
    {
        private DBpro db;
        public FormGestionSalle()
        {
            InitializeComponent();
            db = new DBpro();
            Actualiser();
            dgvSalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalles.MultiSelect = false;

        }
        private void Actualiser()
        {
            var salles = db.Salles.ToList();
            dgvSalles.DataSource = salles.Select(s => new
            {
                s.Id,
                s.Libelle
            }).ToList();
        }


        private void FormGestionSalle_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var Salle = new Salle { Libelle = txtLibelle.Text };

            db.Salles.Add(Salle);
            db.SaveChanges();

            MessageBox.Show("Salle ajoutée avec succès !");
            Actualiser();
            txtLibelle.Text = "";

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvSalles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une salle à modifier.");
                return;
            }
            int id = (int)dgvSalles.SelectedRows[0].Cells[0].Value;
            var salle = db.Salles.Find(id);
            if (salle != null)
            {
                salle.Libelle = txtLibelle.Text;
                db.SaveChanges();

                MessageBox.Show("Salle modifiée avec succès !");
                Actualiser();
                txtLibelle.Text="";
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Demander confirmation avant de supprimer
            DialogResult confirmation = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer cette salle ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (confirmation == DialogResult.No)
            {
                return; // Annuler la suppression
            }
            // Récupérer l'ID de la salle sélectionnée
            int id = Convert.ToInt32(dgvSalles.SelectedRows[0].Cells["Id"].Value);
            var salle = db.Salles.FirstOrDefault(s => s.Id == id);
            if (salle != null)
            {
                db.Salles.Remove(salle);
                db.SaveChanges();
                MessageBox.Show("Salle supprimée avec succès !");
                Actualiser(); // Actualiser l'affichage
            }

        }

        private void dgvSalles_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtLibelle.Text = dgvSalles.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtLibelle.Text = "";
        }
    }
}
