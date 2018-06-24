using Cotizaciones.DAL;
using Cotizaciones.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones.BLL

{
    public class ArticuloBLL
    {
       
        public static bool Guardar(Articulos articulo)
        {
            bool guardado = false;
            
            Contexto contexto = new Contexto();
          
                if (contexto.Articulos.Add(articulo) != null)
                {
                    contexto.SaveChanges();
                    guardado = true;
                }

                contexto.Dispose();
          
            
            return guardado;
        }
       
        public static bool Modificar(Articulos articulo)
        {

            bool modificado = false;

            Contexto contexto = new Contexto();


            contexto.Entry(articulo).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    modificado = true;

                }

                contexto.Dispose();

            

           

            return modificado;



        }
       

        public static bool Eliminar(int id)
        {

            bool eliminado = false;

            Contexto contexto = new Contexto();

           

                Articulos articulo = contexto.Articulos.Find(id);
                contexto.Articulos.Remove(articulo);
                if (contexto.SaveChanges() > 0)
                {

                    eliminado = true;

                }

                contexto.Dispose();

         

            return eliminado;

        }
       

        public static Articulos Buscar(int id)
        {

            Articulos articulo = new Articulos();
            Contexto contexto = new Contexto();

          
                articulo = contexto.Articulos.Find(id);
                contexto.Dispose();

               

            return articulo;

        }
       

        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
        {

            List<Articulos> Articulos = new List<Articulos>();
            Contexto contexto = new Contexto();

            try
            {

                Articulos = contexto.Articulos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return Articulos;
        }
    }
}
