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
    public class CotizacionesBLL
    {

        public static bool Guardar(Cotizacioness cotizacion)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
         
                if (contexto.Cotizaciones.Add(cotizacion) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }

                contexto.Dispose();
            
          
            return paso;
        }

        public static bool Modificar(Cotizacioness cotizacion)
        {

            bool paso = false;

            Contexto contexto = new Contexto();

           

                foreach (var item in cotizacion.Detalle)
                {
                   
                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;
                }

               
                contexto.Entry(cotizacion).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
           
            return paso;

        }

        public static bool Eliminar(int id)
        {

            bool paso = false;

            Contexto contexto = new Contexto();

           
                Cotizacioness cotizacion = contexto.Cotizaciones.Find(id);
                contexto.Cotizaciones.Remove(cotizacion);
                if (contexto.SaveChanges() > 0)
                {

                    paso = true;

                }

                contexto.Dispose();

                

            return paso;
        }

        public static Cotizacioness Buscar(int id)
        {

            Cotizacioness cotizacion = new Cotizacioness();
            Contexto contexto = new Contexto();

           
                cotizacion = contexto.Cotizaciones.Find(id);
               
                cotizacion.Detalle.Count();

               
                foreach (var item in cotizacion.Detalle)
                {
                  
                    string s = item.Articulos.Descripcion;
                    string r = item.Personas.Nombre;
                }
                contexto.Dispose();
            

          

            return cotizacion;

        }

        public static List<Cotizacioness> GetList(Expression<Func<Cotizacioness, bool>> expression)
        {

            List<Cotizacioness> Cotizaciones = new List<Cotizacioness>();
            Contexto contexto = new Contexto();

           
                Cotizaciones = contexto.Cotizaciones.Where(expression).ToList();
                contexto.Dispose();
           

            return Cotizaciones;
        }


    }
}