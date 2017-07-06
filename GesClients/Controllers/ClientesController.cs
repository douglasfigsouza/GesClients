using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GesClients.Models;
using System.Data.SqlClient;

namespace GesClients.Controllers
{
    public class ClientesController : ApiController
    {
        private GesClientsDb context;
        public ClientesController()
        {
            this.context = new GesClientsDb();
        }
        [HttpGet]
        public IEnumerable<Clientes> GetClientes()
        {
            return context.Clientes.AsEnumerable();
        }

        // POST: api/Subscriber
        [HttpPost]
        public void AddClients(Clientes cliente)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    context.Clientes.Add(cliente);
                    context.SaveChanges();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.GetType().FullName);
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
