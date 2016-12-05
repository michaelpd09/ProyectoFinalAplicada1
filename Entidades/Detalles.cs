using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Detalles
    {
        [Key]

        public int IdDetalle { get; set; }
        public int Jugada { get; set; }
        public int Precio { get; set; }
        public string Tipo { get; set; }

        public List<Tickets> tickets { get; set; }

        public Detalles()
        {
            this.tickets = new List<Tickets>();
        }

        public Detalles(int detalleId, int jugada, int precio,string tipo )
        {
            this.IdDetalle = detalleId;
            this.Jugada = jugada;
            this.Precio = Precio;
            this.Tipo = tipo;

            this.tickets = new List<Tickets>();
        }

    }
}
