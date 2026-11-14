using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ApiSantuario.Models
{
    public class Caballero
    {
        [Key]
        public int CaballeroId { get; set; }
        public string Nombre { get; set; }
        public int Edad {  get; set; }
    }
}