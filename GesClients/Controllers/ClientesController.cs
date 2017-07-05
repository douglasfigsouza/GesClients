using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GesClients.Models;

namespace GesClients.Controllers
{
    public class ClientesController : ApiController
    {
        private GesClientsDb context;
        public ClientesController()
        {
            this.context = new GesClientsDb();
        }
        // POST: api/Subscriber
        [HttpPost]
        public void AddClients(Clientes cliente)
        {
            if (ModelState.IsValid)
            {
               
                cliente.IdCli = cliente.IdCli;
                try
                {
                    context.SaveChanges();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Exception: " +ex.Message);
                }
            }
        }

    }
}
