using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GesClients.Models
{
    public class Clientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCli { get; set; }
        public string  NomeCli { get; set; }
        public string CPFCli { get; set; }
        public DateTime Nascimento{ get; set; }
        
    }
}