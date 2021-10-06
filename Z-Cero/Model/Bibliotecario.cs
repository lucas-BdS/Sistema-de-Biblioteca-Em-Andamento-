using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bibliotecario
    {
        public Int64 CPF { get; set; }

        public String Nome { get; set; }

        public DateTime Nascimento { get; set; }

        public Boolean NivelAcesso { get; set; }

        public String Senha { get; set; }
    }
}
