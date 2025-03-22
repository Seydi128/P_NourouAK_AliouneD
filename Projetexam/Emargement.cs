using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetexam
{
    internal class Emargement
    {
        public Emargement() { }
        public int Id { get; set; }
        public DateTime? DateEmargement { get; set; }
        public string EstPresent { get; set; } // en attente, présent, absent
        public int ProfesseurId { get; set; }
        public User Professeur { get; set; }
        public int CoursId { get; set; }
        public Cours Cours { get; set; }


    }
}
