using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Utilitarios;

namespace AcessaDados
{
    public class PesquisaDados
    {
        private const string UKEY = "ukey";
        private const string CODIGO_PESQUISA = "codigoPesquisa";
        private const string NOME_PESQUISA = "nomePesquisa";
        private const string TELA_PESQUISA = "telaPesquisa";
        private const string RELATORIO = "relatorio";
        private const string SELECT_PESQUISA = "selectPesquisa";

        AcessaBanco acessaBanco = new AcessaBanco();
        CriaStringSql criaString = new CriaStringSql("tblPesquisa");

        public void insert(Pesquisa pesquisa)
        {
            try
            {
                criaString.addCampo(UKEY, UKEY);
                criaString.addCampo(CODIGO_PESQUISA, CODIGO_PESQUISA);
                criaString.addCampo(NOME_PESQUISA, NOME_PESQUISA);
                criaString.addCampo(TELA_PESQUISA, TELA_PESQUISA);
                criaString.addCampo(RELATORIO, RELATORIO);
                criaString.addCampo(SELECT_PESQUISA, SELECT_PESQUISA);
                string sql = criaString.insert();
                acessaBanco.criaConexao();
                acessaBanco.limpaParametros();
                acessaBanco.adicionaParametros(UKEY, pesquisa.Ukey);
                acessaBanco.adicionaParametros(CODIGO_PESQUISA, pesquisa.CodigoPesquisa);
                acessaBanco.adicionaParametros(NOME_PESQUISA, pesquisa.NomePesquisa);
                acessaBanco.adicionaParametros(TELA_PESQUISA, pesquisa.TelaPesquisa);
                acessaBanco.adicionaParametros(RELATORIO, pesquisa.Relatorio);
                acessaBanco.adicionaParametros(SELECT_PESQUISA, pesquisa.SelectPesquisa);

                acessaBanco.executaManipulacao(CommandType.Text, sql);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
