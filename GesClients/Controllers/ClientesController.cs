﻿using System;
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
        //método que retona todos os clientes
        [HttpGet]
        public IEnumerable<Clientes> GetClientes()
        {
            try
            {
                var consulta = context.Clientes.AsEnumerable();
                return consulta;
            }
            catch(Exception ex)
            {
                System.Console.Write(ex);
                return null;
            }

        }
        //método para adição de clientes
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
        // método de atualização de clientes 
        [HttpPut]
        public void Put(Clientes cli)
        {
            cli.IdCli = cli.IdCli;
            cli.NomeCli = cli.NomeCli;
            cli.DataNascimentoCli = cli.DataNascimentoCli;
            cli.CPFCli = cli.CPFCli;

            if (ModelState.IsValid)
            {
                context.Entry(cli).State = System.Data.Entity.EntityState.Modified;
                try
                {
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        // método de remoçãod e clientes 
        [HttpDelete]
        public void DeleteCliente(int id)
        {
            Clientes cliente = context.Clientes.Find(id);
            if (cliente != null)
            {
                try
                {
                    context.Clientes.Remove(cliente);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


    }
}
