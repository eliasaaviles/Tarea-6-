using System;
using System.ComponentModel.DataAnnotations;


namespace Cotizaciones.Entidades
{
    
    public class Personas
    {
        
        [Key]
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }


        public Personas()
        {

        }

        public override string ToString()
        {
            return this.Nombre;
        }

    }
}