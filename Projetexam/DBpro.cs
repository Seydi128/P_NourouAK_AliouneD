using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetexam
{
    internal class DBpro : DbContext
    {
        public DBpro() : base("exam")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Salle> Salles { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Emargement> Emargements { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        // ✅ Ajout d'une méthode pour récupérer les émargements sous forme de DataTable
        public DataTable GetEmargements()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nom", typeof(string)); // Nom du professeur
            dt.Columns.Add("Prenom", typeof(string)); // Prénom du professeur
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Statut", typeof(string)); // Présent, Absent, etc.

            var emargements = Emargements.Include(e => e.Professeur).ToList(); // Charger le professeur

            foreach (var emargement in emargements)
            {
                dt.Rows.Add(
                    emargement.Id,
                    emargement.Professeur?.Nom ?? "Inconnu",  // Récupérer Nom du professeur
                    emargement.Professeur?.Prenom ?? "Inconnu",  // Récupérer Prénom du professeur
                    emargement.DateEmargement ?? DateTime.MinValue,
                    emargement.EstPresent
                );
            }

            return dt;
        }
    }
}
