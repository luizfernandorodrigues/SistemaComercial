using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pais
    {
        private Guid ukey;
        private string nome;
        private string codigo;

        public Guid Ukey { get => ukey; set => ukey = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
