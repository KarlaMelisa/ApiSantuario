using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ApiSantuario.Models
{
    public class Armadura
    {
        [Key]
        public int ArmaduraId { get; set; }
        public string Nombre { get; set; }
        public string Constelacion { get; set; }
    }
}