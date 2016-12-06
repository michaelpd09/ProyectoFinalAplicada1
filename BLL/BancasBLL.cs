using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BancasBLL
    {
        public static bool Guardar(Bancas banca)
        {
            bool retorno = false;
            try
            {
                BancaDB db = new BancaDB();
                db.bancas.Add(banca);
                db.SaveChanges();
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
            var db = new BancaDB();
           Bancas banca = Buscar(Id);
            if (banca != null)
            {
                db.Entry(banca).State = EntityState.Deleted;
                db.SaveChanges();
                retorno = true;
            }
            return retorno;
        }

        public static Bancas Buscar(int Id)
        {
            var db = new BancaDB();

            return db.bancas.Find(Id);

        }

        public static void Modificar(Bancas banca)
        {
            var db = new BancaDB();
            db.Entry(banca).State = EntityState.Modified;
            db.SaveChanges();

        }

        public static List<Bancas> GetLista()
        {
            List<Bancas> lista = new List<Bancas>();

            var db = new BancaDB();

            lista = db.bancas.ToList();

            return lista;
        }

        public static List<Bancas> GetLista(int bancaId)
        {
            List<Bancas> lista = new List<Bancas>();

            var db = new BancaDB();

            lista = db.bancas.Where(p => p.BancaId == bancaId).ToList();

            return lista;
        }
    }
}
