using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EVENTOS.Models
{
    public class EventoDbContext : DbContext
    {

        public EventoDbContext():base("MyConnection")
        {

        }
        public DbSet<Evento> Eventos { get; set; }
    }
}
