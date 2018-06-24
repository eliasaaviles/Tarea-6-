using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones
{
    
    public class Articulos
    {
        [Key] 
        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Precio { get; set; }
        public int CantidadCotizada { get; set; }
        

        public Articulos()
        {

        }


        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
