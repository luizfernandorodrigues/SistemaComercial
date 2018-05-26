using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace AcessaDados
{
    public class CarregaPesquisa
    {
        private string telaPesquisa;
        private const string CAMPO = "selectPesquisa";
        private const string TABELA = "tblPesquisa";
        private const string COLUNA = "telaPesquisa";
        AcessaBanco acessaBanco = new AcessaBanco();

        public CarregaPesquisa(string telaPesquisa)
        {
            this.telaPesquisa = telaPesquisa;
        }

        public string query()
        {
            try
            {
                string select;
                DataTable dataTable = new DataTable();
                CriaStringSql criaStringSql = new CriaStringSql(TABELA);
                criaStringSql.addCampo(CAMPO);
                criaStringSql.addWherePesquisa(COLUNA, COLUNA);
                string sql = criaStringSql.select();
                acessaBanco.criaConexao();
                acessaBanco.limpaParametros();
                acessaBanco.adicionaParametros("@"+COLUNA,telaPesquisa);
                dataTable = acessaBanco.ExecutaConsulta(CommandType.Text, sql);
                DataRow posicao = dataTable.Rows[0];
                select = Convert.ToString(posicao[CAMPO]);
                return select;
            }
            catch
            {
                throw new Exception();
            }
            
        }
    }
}
