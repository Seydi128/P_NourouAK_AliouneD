using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Projetexam
{
    public partial class FormGestionCours : Form
    {
        private DBpro db;


        public FormGestionCours()
        {
            InitializeComponent();
            db = new DBpro();
            Configurer();
            ActualiserProfesseurs();
            ActualiserSalles();
            ActualiserCours();
            int professeurId = (int)cmbProfesseur.SelectedValue; // Récupère l'ID du professeur
            string emailProf = GetEmailProfesseur(professeurId); 




            dgvCours.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCours.MultiSelect = false;




        }

        /// 🔹Méthode pour récupérer l'email du professeur avec son ID via DBpro
        private string GetEmailProfesseur(int professeurId)
        {
            var professeur = db.Users.FirstOrDefault(u => u.Id == professeurId && u.Role == "Professeur");
            return professeur?.Email;
        }

        /// Méthode pour envoyer un email avec Gmail
        private void EnvoyerEmailGmail(string destinataire, Cours cours)
        {
            try
            {
                string sujet = "Affectation d'un cours";
                string corps = $"Bonjour,\n\n" +
                               $"Vous avez été affecté à un cours.\n\n" +
                               $" Date : {cours.DateCours:dd/MM/yyyy}\n" +
                               $" Heure : {cours.HeureDebut} - {cours.HeureFin}\n" +
                               $" Salle : {db.Salles.FirstOrDefault(s => s.Id == cours.SalleId)?.Libelle ?? "Non spécifiée"}\n\n" +
                               $"Merci de confirmer votre présence.\n\n" +
                               $"Cordialement,\nVotre administration";

                SmtpClient smtp = new SmtpClient("smtp.mailtrap.io")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("3ff1941e41bd68", "8df5ae6ebc10e8"),
                    EnableSsl = true
                };

                MailMessage message = new MailMessage
                {
                    From = new MailAddress("test@mailtrap.io"),
                    Subject = sujet,
                    Body = corps,
                    IsBodyHtml = false
                };
                message.To.Add(destinataire);

                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'envoi de l'e-mail : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Configurer()
        {
            dtpHeureDebut.Format = DateTimePickerFormat.Custom;
            dtpHeureDebut.CustomFormat = "HH:mm";
            dtpHeureDebut.ShowUpDown = true;

            dtpHeureFin.Format = DateTimePickerFormat.Custom;
            dtpHeureFin.CustomFormat = "HH:mm";
            dtpHeureFin.ShowUpDown = true;

            dtpDateCours.Format = DateTimePickerFormat.Custom;
            dtpDateCours.CustomFormat = "dd/MM/yyyy";
            dtpDateCours.ShowUpDown = false;
        }

        private void ActualiserProfesseurs()
        {
            cmbProfesseur.DataSource = db.Users
                 .Where(u => u.Role == "Professeur")
                 .Select(u => new { u.Id, NomComplet = u.Nom + " " + u.Prenom })
                 .ToList();

            cmbProfesseur.DisplayMember = "NomComplet";
            cmbProfesseur.ValueMember = "Id";
        }
        private void ActualiserSalles()
        {
            cmbSalle.DataSource = db.Salles
                .Select(s => new { s.Id, s.Libelle })
                .ToList();

            cmbSalle.DisplayMember = "Libelle";
            cmbSalle.ValueMember = "Id";
        }

        private void ActualiserCours()
        {
            dgvCours.DataSource = db.Cours.Select(c => new
            {
                c.Id,
                c.Nom,
                c.Description,
                Professeur = c.Professeur.Nom + " " + c.Professeur.Prenom,
                c.ProfesseurId,
                Salle = c.Salle.Libelle,
                c.SalleId,
                c.DateCours,
                c.HeureDebut,
                c.HeureFin
            }).ToList();

            dgvCours.Columns["ProfesseurId"].Visible = false;
            dgvCours.Columns["SalleId"].Visible = false;
        }

        private bool ExisteConflitHoraire(int professeurId, DateTime date, TimeSpan debut, TimeSpan fin, int? idCours = null)
        {
            return db.Cours.Any(c =>
                c.ProfesseurId == professeurId &&
                c.DateCours == date &&
                ((debut < c.HeureFin && fin > c.HeureDebut)) &&
                (idCours == null || c.Id != idCours));
        }

        private bool ExisteConflitSalle(int salleId, DateTime date, TimeSpan heureDebut, TimeSpan heureFin, int? coursId = null)
        {
            return db.Cours.Any(c =>
                c.SalleId == salleId &&
                c.DateCours == date &&
                (coursId == null || c.Id != coursId) &&
                ((heureDebut < c.HeureFin && heureFin > c.HeureDebut))
            );
        }

        private void ViderChamps()
        {
            txtNom.Text = "";
            txtDescription.Text = "";
            cmbProfesseur.Text = "Selectionner";
            cmbSalle.Text = "Selectionner"; ;
            dtpDateCours.Value = DateTime.Today;
            dtpHeureDebut.Value = DateTime.Now;
            dtpHeureFin.Value = DateTime.Now;
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int professeurId = (int)cmbProfesseur.SelectedValue;
            string nom = txtNom.Text.Trim();
            string description = txtDescription.Text.Trim();
            DateTime dateCour = dtpDateCours.Value.Date;
            TimeSpan heureDebut = dtpHeureDebut.Value.TimeOfDay;
            TimeSpan heureFin = dtpHeureFin.Value.TimeOfDay;
            int salleId = (int)cmbSalle.SelectedValue;

            // Vérifier les conflits d'horaires du professeur
            if (ExisteConflitHoraire(professeurId, dateCour, heureDebut, heureFin))
            {
                MessageBox.Show(" Conflit d'horaire détecté ! Le professeur a déjà un cours à ce créneau.");
                return;
            }

            // Vérifier les conflits de salle
            if (ExisteConflitSalle(salleId, dateCour, heureDebut, heureFin))
            {
                MessageBox.Show("Conflit d'horaire détecté ! Cette salle est déjà occupée à ce créneau.");
                return;
            }
            var cours = new Cours
            {
                Nom = nom,
                Description = description,
                DateCours = dateCour,
                HeureDebut = heureDebut,
                HeureFin = heureFin,
                SalleId = salleId,
                ProfesseurId = professeurId
            };

            db.Cours.Add(cours);
            var emargement = new Emargement
            {
                ProfesseurId = professeurId,
                CoursId = cours.Id,
                DateEmargement = null,
                EstPresent = "Absent"
            };
            db.Emargements.Add(emargement);
            db.SaveChanges();
            ActualiserCours();

            // 🔹 Récupérer l'email du professeur et envoyer le mail
            string emailProf = GetEmailProfesseur(professeurId);
            if (!string.IsNullOrEmpty(emailProf))
            {
                EnvoyerEmailGmail(emailProf, cours);
                MessageBox.Show("Cours ajouté et email envoyé au professeur !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cours ajouté, mais l'email du professeur est introuvable.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void dgvCours_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCours.Rows.Count)
            {
                var row = dgvCours.Rows[e.RowIndex];

                // Remplir les champs texte avec les informations du cours sélectionné
                txtNom.Text = row.Cells["Nom"].Value?.ToString() ?? string.Empty;
                txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? string.Empty;
                cmbProfesseur.SelectedValue = row.Cells["ProfesseurId"].Value;
                cmbSalle.SelectedValue = row.Cells["SalleId"].Value;
                dtpDateCours.Value = (DateTime)row.Cells["DateCours"].Value;
                dtpHeureDebut.Value = DateTime.Today.Add((TimeSpan)row.Cells["HeureDebut"].Value);
                dtpHeureFin.Value = DateTime.Today.Add((TimeSpan)row.Cells["HeureFin"].Value);
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvCours.SelectedRows.Count == 0)
            {
                MessageBox.Show("Aucune ligne sélectionnée pour la suppression.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = (int)dgvCours.SelectedRows[0].Cells["Id"].Value;
            var cours = db.Cours.Find(id);

            if (cours == null)
            {
                MessageBox.Show("Cours non trouvé dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show("Confirmez-vous la suppression ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                db.Cours.Remove(cours);
                db.SaveChanges();
                MessageBox.Show(" Cours supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualiserCours();
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvCours.SelectedRows.Count == 0)
            {
                MessageBox.Show("Aucune ligne sélectionnée pour la modification.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = (int)dgvCours.SelectedRows[0].Cells["Id"].Value;
            var cours = db.Cours.Find(id);
            if (cours == null)
            {
                MessageBox.Show("Cours non trouvé dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int professeurId = (int)cmbProfesseur.SelectedValue;
            int salleId = (int)cmbSalle.SelectedValue;
            DateTime date = dtpDateCours.Value;
            TimeSpan debut = dtpHeureDebut.Value.TimeOfDay;
            TimeSpan fin = dtpHeureFin.Value.TimeOfDay;
            if (ExisteConflitHoraire(professeurId, date, debut, fin, id))
            {
                MessageBox.Show("Conflit d'horaire détecté pour le professeur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ExisteConflitSalle(salleId, date, debut, fin, id))
            {
                MessageBox.Show(" Cette salle est déjà réservée pour ce créneau !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cours.Nom = txtNom.Text.Trim();
            cours.Description = txtDescription.Text.Trim();
            cours.DateCours = date;
            cours.HeureDebut = debut;
            cours.HeureFin = fin;
            cours.ProfesseurId = professeurId;
            cours.SalleId = salleId;
            db.SaveChanges();
            MessageBox.Show("Cours modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualiserCours();
            ViderChamps();

        }

        private void btmEffacer_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }

      
    }
}
