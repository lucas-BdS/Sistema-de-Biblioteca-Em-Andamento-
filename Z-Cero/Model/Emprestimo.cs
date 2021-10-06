using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Emprestimo
	{
		public Int64 ID { get; set; }

		public Int64 IdLeitor { get; set; }

		public Int64 IdLivro { get; set; }

		public DateTime DataEmprestimo { get; set; }

		public DateTime DataDevolucao { get; set; }

		public Boolean Status { get; set; }
	}
}
