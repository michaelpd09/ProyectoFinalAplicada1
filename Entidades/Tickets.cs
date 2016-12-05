using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Tickets
    {
        [Key]

        public int IdTicket { get; set; }
        public int IdLoteria { get; set; }
        public int IdDetalle { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public bool Nulo { get; set; }
        public double Total { get; set; }
        public string NombreLoteria { get; set; }

        public virtual List<Detalles> detalles { get; set; }

        public Tickets()
        {
            this.detalles = new List<Detalles>();
        }


    }
}
