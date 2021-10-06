using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Leitor
	{
		public Int64 ID { get; set; }

		public Int64 CPF { get; set; }

		public String Nome { get; set; }

		public String Email { get; set; }

		public DateTime Nascimento { get; set; }

		public String Logradouro { get; set; }

		public Int64 CEP { get; set; }

		public Int64 Celular { get; set; }
	}
}
