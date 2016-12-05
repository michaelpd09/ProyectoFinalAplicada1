using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BLL
{
    public class DetallesBLL
    {
        public static bool Guardar(Detalles detalle)
        {
            bool retorno = false;
            try
            {
                var db = new BancaDB();
                db.detalles.Add(detalle);
                db.SaveChanges();

                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public static bool Editar(int Id, Detalles detalles)
        {
            bool retorno = false;
            try
            {
                using (var db = new BancaDB())
                {
                    Detalles detalle = db.detalles.Find(Id);

                    detalle.Jugada = detalles.Jugada;
                    detalle.Precio = detalles.Precio;
                    detalle.Tipo = detalles.Tipo;

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

        public static bool Eliminar(int Id)
        {  
            bool retorno = false;

            try
            {
                using (BancaDB db = new BancaDB())
                {
                   Detalles detalle = (from d in db.detalles where d.IdDetalle == Id select d).FirstOrDefault();
                     db.detalles.Remove(detalle);
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

        public static List<Detalles> GetLista()
        {
            List<Detalles> lista = new List<Detalles>();
            BancaDB db = new BancaDB();

            lista = db.detalles.ToList();
            return lista;
        }

        public static List<Detalles> GetLista(int Id)
        {
            List<Detalles> lista = new List<Detalles>();
            BancaDB db = new BancaDB();

            lista = db.detalles.Where(u => u.IdDetalle == Id).ToList();
            return lista;
        }

        public static Detalles Buscar(int id)
        {
            Detalles detalles = new Detalles();
            using (var db = new BancaDB())
            {
                detalles = db.detalles.Find(id);
            }
            return detalles;
        }

    }
}
