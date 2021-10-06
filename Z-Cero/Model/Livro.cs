using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Livro
	{
		public Int64 ID { get; set; }

		public Int64 ISBN { get; set; }

		public String Editora { get; set; }

		public String Autor { get; set; }

		public String Titulo { get; set; }

		public Int16 Paginas { get; set; }

		public String Capa { get; set; }

		public DateTime DataChegada { get; set; }

		public Int16 AnoLancamento { get; set; }

		public Boolean Status { get; set; }
	}
}
