using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class Pesquisa
    {
        private Guid ukey;
        private string codigoPesquisa;
        private string nomePesquisa;
        private string telaPesquisa;
        private int relatorio;
        private string selectPesquisa;

        public Guid Ukey { get => ukey; set => ukey = value; }
        public string CodigoPesquisa { get => codigoPesquisa; set => codigoPesquisa = value; }
        public string NomePesquisa { get => nomePesquisa; set => nomePesquisa = value; }
        public string TelaPesquisa { get => telaPesquisa; set => telaPesquisa = value; }
        public int Relatorio { get => relatorio; set => relatorio = value; }
        public string SelectPesquisa { get => selectPesquisa; set => selectPesquisa = value; }
    }
}
