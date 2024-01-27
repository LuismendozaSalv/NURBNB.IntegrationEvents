using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NURBNB.IntegrationEvents
{
	public class PagoReservaRegistrado
	{
		public Guid ReservaId { get; set; }
		public Guid TransaccionId { get; set; }
	}
}
