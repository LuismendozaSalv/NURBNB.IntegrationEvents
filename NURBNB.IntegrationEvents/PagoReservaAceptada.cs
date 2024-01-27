using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NURBNB.IntegrationEvents
{
	public class PagoReservaAceptada
	{
		public Guid ReservaId { get; set; }
		public Guid ÚsuarioId { get; set; }
		public decimal Monto { get; set; }
	}
}
