using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BLL
{
   public  class LoteriasBLL
    {
        public static bool Guardar(Loterias loteria)
        {
            bool retorno = false;
            try
            {
                BancaDB db = new BancaDB();
                db.loterias.Add(loteria);
                db.SaveChanges();
                retorno = true;
            }
            catch (Exception e)
            {
                throw e;
                
            }

            return retorno;
        }

        public static bool Eliminar(int ID)
        {
            bool retorno = false;
            var db = new BancaDB();
            Loterias loterias = Buscar(ID);
            if (loterias != null)
            {
                db.Entry(loterias).State = EntityState.Deleted;
                db.SaveChanges();
                retorno = true;
            }
            return retorno;
        }

        public static Loterias Buscar(int ID)
        {
            var db = new BancaDB();

            return db.loterias.Find(ID);

        }

        public static void Modificar(Loterias loteria)
        {
            var db = new BancaDB();
            db.Entry(loteria).State = EntityState.Modified;
            db.SaveChanges();

        }

        public static List<Loterias> GetLista()
        {
            List<Loterias> lista = new List<Loterias>();

            var db = new BancaDB();

            lista = db.loterias.ToList();

            return lista;
        }

        public static List<Loterias> GetListaLoteriaID(int LoteriaID)
        {
            List<Loterias> lista = new List<Loterias>();

            var db = new BancaDB();

            lista = db.loterias.Where(l => l.IdLoteria == LoteriaID).ToList();

            return lista;
        }
        
        public static List<Loterias> GetListaLoterias(string loteria)
        {
            List<Loterias> lista = new List<Loterias>();
            BancaDB db = new BancaDB();
            lista = db.loterias.Where(p => (p.Nombre.Contains(loteria))).ToList();
            return lista;
        }
    }
}
