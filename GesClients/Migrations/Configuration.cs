namespace GesClients.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GesClients.Models.GesClientsDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GesClients.Models.GesClientsDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            ////  to avoid creating duplicate seed data. E.g.
            ////
            //context.Clientes.AddOrUpdate(
            //  p => p.IdCli,
            //  new Clientes { NomeCli = "Andrew Peters", CPFCli = "081.087.506-36" },
            //  new Clientes { NomeCli = "José Carlos", CPFCli = "082.085.503-38" });
        }
    }
}
