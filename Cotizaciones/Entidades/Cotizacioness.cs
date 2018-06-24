using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones.Entidades
{
    public class Cotizacioness
    {

        [Key]
        public int CotizacionId { get; set; }
        public string Fecha { get; set; }
        public string Comentario { get; set; }
        public float Monto { get; set; }

        public virtual ICollection<DetalleCotizaciones> Detalle { get; set; }

        public Cotizacioness()
        {
          
            this.Detalle = new List<DetalleCotizaciones>();
        }

        public void AgregarDetalle(int id, int CotizacionId, int PersonaId, int ArticuloId, int Cantidad, int Precio, float Importe)
        {
            this.Detalle.Add(new DetalleCotizaciones(id, CotizacionId, PersonaId, ArticuloId, Cantidad, Precio, Importe));
        }
    }
}
