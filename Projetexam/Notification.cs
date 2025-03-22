﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetexam
{
    internal class Notification
    {
        public Notification() { }
        public int Id { get; set; }
        public string Message { get; set; }
        public int DestinataireId { get; set; }
        public User Destinataire { get; set; }
        public DateTime DateEnvoi { get; set; } = DateTime.Now;

    }
}
