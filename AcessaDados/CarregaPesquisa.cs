using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Modelo;
using Apresentacao;

namespace AcessaDados
{
    public class CarregaPesquisa
    {
        private string form;
        private string select;
        private const string TABELA = "tblPesquisa";
        private const string TELA = "telaPesquisa";
        private const string PESQUISA_UKEY = "pesquisa_ukey";

        AcessaBanco acessaBanco = new AcessaBanco();
        CriaStringSql criaStringSql = new CriaStringSql(TABELA);
        DataTable dataTable = new DataTable();
        PesquisaCollection pesquisaCollection = new PesquisaCollection();
        CampoPesquisaCollection campoPesquisasCollection = new CampoPesquisaCollection();
        DataTable dataTableCamposPesquisa = new DataTable();

        public CarregaPesquisa(string telaPesquisa)
        {
            form = telaPesquisa;
        }

        /// <summary>
        /// Método para retorna as pesquisas referente ao form que chamou a tela de pesquisa
        /// retorna uma coleção de pesquisas
        /// </summary>
        /// <returns></returns>
        public PesquisaCollection pesquisas()
        {
            try
            {
                criaStringSql.addWherePesquisa(TELA, TELA);
                select = criaStringSql.select();
                acessaBanco.limpaParametros();
                acessaBanco.adicionaParametros("@" + TELA, form);
                dataTable = acessaBanco.ExecutaConsulta(CommandType.Text, select);

                foreach (DataRow linha in dataTable.Rows)
                {
                    Pesquisa pesquisa = new Pesquisa();
                    pesquisa.CodigoPesquisa = Convert.ToString(linha["codigoPesquisa"]);
                    pesquisa.NomePesquisa = Convert.ToString(linha["nomePesquisa"]);
                    pesquisa.Relatorio = Convert.ToInt32(linha["relatorio"]);
                    pesquisa.SelectPesquisa = Convert.ToString(linha["selectPesquisa"]);
                    //conversão de string para Guid
                    string ukey = Convert.ToString(linha["ukey"]);
                    pesquisa.Ukey = Guid.Parse(ukey);
                    pesquisaCollection.Add(pesquisa);
                }
                return pesquisaCollection;
            }
            catch (Exception ex)
            {
                Util_Log.log(ex.Message);
                throw;
            }

        }

        public CampoPesquisaCollection camposPesquisas(string pesquisa_id)
        {
            string select;
            try
            {
                criaStringSql.addWherePesquisa(PESQUISA_UKEY, PESQUISA_UKEY);
                select = criaStringSql.select();
                acessaBanco.limpaParametros();
                acessaBanco.adicionaParametros("@" + PESQUISA_UKEY, pesquisa_id);
                dataTableCamposPesquisa = acessaBanco.ExecutaConsulta(CommandType.Text, select);

                foreach (DataRow linha in dataTableCamposPesquisa.Rows)
                {
                    CampoPesquisa campoPesquisa = new CampoPesquisa();
                    //conversao para string por causa do Guid da ukey
                    string ukey = Convert.ToString(linha["ukey"]);
                    campoPesquisa.Ukey = Guid.Parse(ukey);
                    campoPesquisa.NomeCampo = Convert.ToString(linha["nomeCampo"]);
                    campoPesquisa.OperadorCampo = Convert.ToInt32(linha["operadorCampo"]);
                    campoPesquisa.Campo = Convert.ToString(linha["campo"]);
                    campoPesquisa.TipoCampo = Convert.ToInt32(linha["tipoCampo"]);
                    //conversao para string por causa do Guid da chave strangeira
                    ukey = Convert.ToString(linha["pesquisa_ukey"]);
                    campoPesquisa.Pesquisa_ukey = Guid.Parse(ukey);
                    campoPesquisa.TabelaCampo = Convert.ToString(linha["tabelaCampo"]);
                    campoPesquisasCollection.Add(campoPesquisa);
                    return campoPesquisasCollection;
                }
            }
            catch (Exception ex)
            {
                Util_Log.log(ex.Message);
            }
        }
    }
}
