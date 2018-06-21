using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class CampoPesquisa
    {
        private Guid ukey;
        private string tabelaCampo;
        private string campo;
        private string nomeCampo;
        private int operadorCampo;
        private int tipoCampo;
        private Guid pesquisa_ukey;

        public Guid Ukey { get => ukey; set => ukey = value; }
        public string TabelaCampo { get => tabelaCampo; set => tabelaCampo = value; }
        public string Campo { get => campo; set => campo = value; }
        public int OperadorCampo { get => operadorCampo; set => operadorCampo = value; }
        public int TipoCampo { get => tipoCampo; set => tipoCampo = value; }
        public Guid Pesquisa_ukey { get => pesquisa_ukey; set => pesquisa_ukey = value; }
        public string NomeCampo { get => nomeCampo; set => nomeCampo = value; }
    }
}
