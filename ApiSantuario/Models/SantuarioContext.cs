using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ApiSantuario.Models
{
    public class SantuarioContext : DbContext
    {
        public SantuarioContext() : base("name=SantuarioConnection") { }

        public DbSet<Caballero> Caballero {  get; set; }
        public DbSet<Armadura> Armadura { get; set; }
    }
}