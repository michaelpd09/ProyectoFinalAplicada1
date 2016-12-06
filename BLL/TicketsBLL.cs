using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BLL
{
    public class TicketsBLL
    {
        public static bool Guardar(Tickets ticket)
        {
            bool retorno = false;
            try
            {
                using (var db = new BancaDB())
                {
                    if (Buscar(ticket.IdTicket) == null)
                        db.tickets.Add(ticket);
                    else
                        db.Entry(ticket).State = EntityState.Modified;

                    foreach (var detalles in ticket.detalles)
                    {
                        db.Entry(detalles).State = EntityState.Unchanged;
                    }
                    db.SaveChanges();
                }
                retorno = true;
            }
            catch (Exception )
            {

                throw;
            }
            return retorno;
        }

        public static Tickets Buscar(int Id)
        {
           Tickets date = null;
            using (var db = new BancaDB())
            {
                date = db.tickets.Find(Id);
                if (date != null)
                    date.detalles.Count();
            }
            return date;
        }

        public static bool Eliminar(int Id)
        {
            bool retorno = false;

            try
            {
                using (BancaDB db = new BancaDB())
                {
                    Tickets ticket = (from c in db.tickets where c.IdTicket == Id select c).FirstOrDefault();
                    db.tickets.Remove(ticket);
                    db.SaveChanges();
                    retorno = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public static List<Tickets> GetLista()
        {
            List<Tickets> lista = new List<Tickets>();
            BancaDB db = new BancaDB();

            lista = db.tickets.ToList();
            return lista;
        }

        public static List<Tickets> GetLista(int Id)
        {
            List<Tickets> lista = new List<Tickets>();
            BancaDB db = new BancaDB();

            lista = db.tickets.Where(u => u.IdTicket == Id).ToList();
            return lista;
        }
    }
}
