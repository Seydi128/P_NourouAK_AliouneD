using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetexam
{
    internal class User
    {
        public User() { }
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        [MaxLength(255)] 
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
