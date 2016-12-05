using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Loteria
    {
        [Key]

        public int IdLoteria { get; set; }
        public string Nombre { get; set;  }
        public int MontoPrimera { get; set; }
        public int MontoSegunda { get; set; }
        public int MontoTercera { get; set; }
        public int MontoPale1 { get; set; }
        public int MontoPale2 { get; set; }
        public int MontoTripleta1 { get; set; }
        public int MontoTripleta2 { get; set; }
        public DateTime HoraApectura { get; set; }
        public DateTime HoraCierre { get; set; }
        public int MaximoQuiniela { get; set; }
        public int MaximoPale { get; set; }
        public int MaximoTripleta { get; set; }
        public int MontoJugado { get; set; }
    }
}
