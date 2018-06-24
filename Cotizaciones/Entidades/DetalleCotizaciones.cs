using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones.Entidades

{
    public class DetalleCotizaciones
    {
        [Key]
        public int Id { get; set; }
        public int CotizacionId { get; set; }
        public int PersonaId { get; set; }
        public int ArticuloId { get; set; }
        public float Cantidad { get; set; }
        public float Precio { get; set; }
        public float Importe { get; set; }

        
        public virtual Articulos Articulos { get; set; }

        
        public virtual Personas Personas { get; set; }

        public DetalleCotizaciones()
        {
            this.Id = 0;
            this.CotizacionId = 0;

        }

        public DetalleCotizaciones(int id, int cotizacioId, int personaId, int articuloId, int cantidad, float precio, float importe)
        {
            Id = id;
            CotizacionId = cotizacioId;
            PersonaId = personaId;
            ArticuloId = articuloId;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
    }
}
