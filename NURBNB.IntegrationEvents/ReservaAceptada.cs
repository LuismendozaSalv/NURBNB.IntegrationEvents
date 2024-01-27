using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NURBNB.IntegrationEvents
{
	public class ReservaAceptada
	{

		public Guid GuestId { get; set; }
		public Guid reservaId { get; set; }
		public Guid PropiedadId { get; set; }
		public decimal Monto { get; set; }
	}
}
