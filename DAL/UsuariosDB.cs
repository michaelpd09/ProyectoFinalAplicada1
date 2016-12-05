using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;

namespace DAL
{
   public class UsuariosDB : DbContext
    {
        public UsuariosDB() : base("name=ConStr")
        {

        }
        public virtual DbSet<Usuarios> usuarios { get; set; }
        public virtual DbSet<Ticket> ticket { get; set;  }
        public virtual DbSet<Loteria> loteria { get; set; }
    }
}
