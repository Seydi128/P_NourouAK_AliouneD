using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetexam
{
    internal class Cours
    {
        public Cours() { }
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public DateTime DateCours { get; set; }
        public TimeSpan HeureDebut { get; set; }
        public TimeSpan HeureFin { get; set; }
        public int ProfesseurId { get; set; }
        public User Professeur { get; set; }
        public int SalleId { get; set; }
        public Salle Salle { get; set; }

    }
}
