using SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.IntegrationEvents
{
    public record ArticuloCreado : IntegrationEvent
    {
        public Guid ArticuloId { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioVenta { get; set; }

        public bool EsReceta { get; set; }

        public string Descripcion { get; set; }
    }
}
