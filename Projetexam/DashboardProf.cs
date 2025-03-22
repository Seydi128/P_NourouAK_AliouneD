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
    public partial class DashboardProf : Form
    {
        private int professeursConnectedId;
        public DashboardProf(int userId)
        {
            InitializeComponent();
            professeursConnectedId = userId;
        }

        private void DashboardProf_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             FormGestionEmargement formGestionEmargement=new FormGestionEmargement(professeursConnectedId);
            formGestionEmargement.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormManager.ShowLoginForm();
        }
    }
}
