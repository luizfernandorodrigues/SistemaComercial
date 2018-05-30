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

        private const string UKEY_CAMPO = "ukey";
        private const string TABELA_CAMPO = "tabelaCampo";
        private const string CAMPO = "campo";
        private const string OPERADOR_CAMPO = "operadorCampo";
        private const string TIPO_CAMPO = "tipoCampo";
        private const string PESQUISA_UKEY = "pesquisa_ukey";



        AcessaBanco acessaBanco = new AcessaBanco();
        CriaStringSql criaString = new CriaStringSql("tblPesquisa");



        public void insert(Pesquisa pesquisa, CampoPesquisaCollection campoPesquisa)
        {
            List<string> comandoSql = new List<string>();
            try
            {
                criaString.addCampo(UKEY, UKEY);
                criaString.addCampo(CODIGO_PESQUISA, CODIGO_PESQUISA);
                criaString.addCampo(NOME_PESQUISA, NOME_PESQUISA);
                criaString.addCampo(TELA_PESQUISA, TELA_PESQUISA);
                criaString.addCampo(RELATORIO, RELATORIO);
                criaString.addCampo(SELECT_PESQUISA, SELECT_PESQUISA);

                acessaBanco.limpaParametros();
                acessaBanco.adicionaParametros(UKEY, pesquisa.Ukey);
                acessaBanco.adicionaParametros(CODIGO_PESQUISA, pesquisa.CodigoPesquisa);
                acessaBanco.adicionaParametros(NOME_PESQUISA, pesquisa.NomePesquisa);
                acessaBanco.adicionaParametros(TELA_PESQUISA, pesquisa.TelaPesquisa);
                acessaBanco.adicionaParametros(RELATORIO, pesquisa.Relatorio);
                acessaBanco.adicionaParametros(SELECT_PESQUISA, pesquisa.SelectPesquisa);

                comandoSql.Add(criaString.insert());

                             
                CriaStringSql criaStringCampo = new CriaStringSql("tblCampoPesquisa");

                criaStringCampo.addCampo(UKEY_CAMPO, UKEY_CAMPO);
                criaStringCampo.addCampo(TABELA_CAMPO, TABELA_CAMPO);
                criaStringCampo.addCampo(CAMPO, CAMPO);
                criaStringCampo.addCampo(OPERADOR_CAMPO, OPERADOR_CAMPO);
                criaStringCampo.addCampo(TIPO_CAMPO, TIPO_CAMPO);
                criaStringCampo.addCampo(PESQUISA_UKEY, PESQUISA_UKEY);

                comandoSql.Add(criaStringCampo.insert());

                acessaBanco.transacaoSql(CommandType.Text, comandoSql);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
