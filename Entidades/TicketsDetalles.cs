using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TicketsDetalles
    {
        [Key]

        public int IdTicketsDetalles { get; set; }
        public int IdTicket { get; set; }
        public int IdDetalle { get; set; }

      //  public virtual List<Tickets> tickets { get; set; }
    }
}
