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
    public partial class Form1 : Form
    {
        private DBpro db;
        public Form1()
        {
            InitializeComponent();
            db = new DBpro();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBox1.Checked ? '\0' : '.';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = db.Users.FirstOrDefault(u => u.Email == email);

            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                switch (user.Role)
                {
                    case "admin":
                        FormManager.ShowDashboardAdmin();
                        break;
                    case "professeur":
                        FormManager.ShowDashboardProfesseur(user.Id);
                        break;
                    case "gestionnaire":
                        FormManager.ShowDashboardGestionnaire();
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("mot de passe ou mail incorrect");
                
            }

        }

       
    }
}
