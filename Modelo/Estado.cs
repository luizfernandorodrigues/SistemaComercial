using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class Estado
    {
        private Guid ukey;
        private string descricaoEstado;
        private string siglaEstado;
        private Guid pais_ukey;

        public Guid Ukey { get => ukey; set => ukey = value; }
        public string DescricaoEstado { get => descricaoEstado; set => descricaoEstado = value; }
        public string SiglaEstado { get => siglaEstado; set => siglaEstado = value; }
        public Guid Pais_ukey { get => pais_ukey; set => pais_ukey = value; }
    }
}
