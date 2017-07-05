using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GesClients.Models
{
    public class GesClientsDb :DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
    }
}