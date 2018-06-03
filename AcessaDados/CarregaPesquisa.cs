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

        AcessaBanco acessaBanco = new AcessaBanco();
        CriaStringSql criaStringSql = new CriaStringSql(TABELA);
        DataTable dataTable = new DataTable();
        PesquisaCollection pesquisaCollection = new PesquisaCollection();

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
            catch(Exception ex)
            {
                Util_Log.log(ex.Message);
                throw;
            }

        }
    }
}
