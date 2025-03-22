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
    public partial class FormGestionUser : Form
    {
        private DBpro db;
        public FormGestionUser()
        {
            db = new DBpro();
            
            InitializeComponent();
            Actualiser();

            dgvUtilisateurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUtilisateurs.MultiSelect = false;

            cmbRole.Items.Add("admin");
            cmbRole.Items.Add("professeur");
            cmbRole.Items.Add("gestionnaire");
            cmbRole.SelectedIndex = 1;

        }
        private void Actualiser()
        {

            var utilisateurs = db.Users.ToList();
            dgvUtilisateurs.DataSource = utilisateurs.Select(u => new
            {
                u.Id,
                u.Nom,
                u.Prenom,
                u.Email,
                u.Role
            }).ToList();
        }

        private void Effacer()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            cmbRole.Text = "Selectionner";
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            string mdpHacker = BCrypt.Net.BCrypt.HashPassword(password);

            var user = new User
            {
                Nom = txtNom.Text,
                Prenom = txtPrenom.Text,
                Email = txtEmail.Text,
                Password = mdpHacker,
                Role = cmbRole.SelectedItem.ToString()
            };

            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Utilisateur ajouté avec succès !");
            Actualiser();
            Effacer();


        }

        

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = (int)dgvUtilisateurs.SelectedRows[0].Cells["Id"].Value;
            var user = db.Users.Find(id);
            string password = txtPassword.Text;
            string mdpHacker = BCrypt.Net.BCrypt.HashPassword(password);


            if (user != null)
            {
                user.Nom = txtNom.Text;
                user.Prenom = txtPrenom.Text;
                user.Email = txtEmail.Text;
                user.Password = mdpHacker;
                user.Role = cmbRole.SelectedItem.ToString();

                db.SaveChanges();
                MessageBox.Show("Utilisateur modifié avec succès !");
                Actualiser();
                Effacer();
            }


        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvUtilisateurs.SelectedRows.Count > 0)
            {
                int id = (int)dgvUtilisateurs.SelectedRows[0].Cells["Id"].Value;
                var user = db.Users.Find(id);

                if (user != null)
                {
                    if (MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.Users.Remove(user);
                        db.SaveChanges();
                        MessageBox.Show("Utilisateur supprimé avec succès !");
                        Actualiser();
                    }
                }
            }

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Effacer();
        }

        private void dgvUtilisateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUtilisateurs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNom.Text = dgvUtilisateurs.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                txtPrenom.Text = dgvUtilisateurs.Rows[e.RowIndex].Cells["Prenom"].Value.ToString();
                txtEmail.Text = dgvUtilisateurs.Rows[e.RowIndex].Cells["Email"].Value.ToString();

                cmbRole.SelectedItem = dgvUtilisateurs.Rows[e.RowIndex].Cells["Role"].Value.ToString();
            }

        }
    }
}
