using SegundoParcial2.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SegundoParcial2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Vendedor> Vende { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}