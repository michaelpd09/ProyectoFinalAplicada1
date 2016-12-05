using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class TicketsDetallesBLL
    {
        public static bool Guardar(TicketsDetalles lista)
        {
            bool retorno = false;
            try
            {
                using (var db = new BancaDB())
                {
                    db.ticketsDetalles.Add(lista);
                    db.SaveChanges();
                }
                retorno = true;

            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }
    }
}
