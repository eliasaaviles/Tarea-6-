using Cotizaciones.DAL;
using Cotizaciones.Entidades;
using Cotizaciones.UI.RegistroPersonas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace Cotizaciones.BLL
{
    
    public class PersonaBLL
    {

    
        public static bool Guardar(Personas personas)
        {
            bool guardado = false;
            
            Contexto contexto = new Contexto();
          
                if (contexto.Personas.Add(personas) != null)
                {
                    contexto.SaveChanges(); 
                    guardado = true;
                }

                contexto.Dispose();
          
            return guardado;
        }

       
        public static bool Modificar(Personas personas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
          
                contexto.Entry(personas).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
           
            return paso;
        }

      
        public static bool Eliminar(int id)
        {
            bool eliminado = false;

            Contexto contexto = new Contexto();
           
                Personas personas = contexto.Personas.Find(id);

                contexto.Personas.Remove(personas);

                if (contexto.SaveChanges() > 0)
                {
                    eliminado = true;
                }
                contexto.Dispose();
          
            return eliminado;
        }

        
        public static Personas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Personas personas = new Personas();
          
                personas = contexto.Personas.Find(id);
                contexto.Dispose();
            
            return personas;
        }

        internal static bool Guardar(RegistroPersonas personas)
        {
            throw new NotImplementedException();
        }

        public static List<Personas> GetList(Expression<Func<Personas, bool>> expression)
        {
            List<Personas> Personas = new List<Personas>();
            Contexto contexto = new Contexto();
           
                Personas = contexto.Personas.Where(expression).ToList();
                contexto.Dispose();
          

            return Personas;
        }

        internal static bool Modificar(RegistroPersonas personas)
        {
            throw new NotImplementedException();
        }
    }
}