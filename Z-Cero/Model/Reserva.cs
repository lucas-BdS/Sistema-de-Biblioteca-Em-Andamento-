using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Reserva
	{
		public Int64 ISBN { get; set; }

		public Int64 IdLeitor { get; set; }

		public DateTime Data { get; set; }

		public DateTime Hora { get; set; }

		public Boolean Status { get; set; }
	}
}
