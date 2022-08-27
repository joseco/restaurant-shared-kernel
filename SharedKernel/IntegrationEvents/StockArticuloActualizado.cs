using SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.IntegrationEvents
{
    public record  StockArticuloActualizado : IntegrationEvent
    {
        public Guid ArticuloId { get; set; }
        public decimal NuevoStock { get; set; }
    }
}
