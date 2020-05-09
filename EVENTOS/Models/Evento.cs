using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EVENTOS.Models
{
    public class Evento
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripción { get; set; }

        public string Lugar { get; set; }

        public DateTime? Fecha { get; set; }

        public string Status { get; set; }

              public string Usuario { get; set; }

                   
    }
}