using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Utilitarios;
namespace AcessaDados
{
    public class PaisDados
    {
        //dados da tabela do banco de dados
        private const string TABELA = "tblPais";
        private const string UKEY = "ukey";
        private const string DESCRICAO_PAIS = "descricaoPais";
        private const string CODIGO_PAIS = "codigoPais";

        AcessaBanco acessaBanco = new AcessaBanco();
        CriaStringSql criaString = new CriaStringSql("tblPais");

        /// <summary>
        /// Método que insere no banco de dados o objeto pais 
        /// </summary>
        /// <param name="pais"></param>
        public void insert(Pais pais)
        {
            try
            {
                criaString.addCampo(UKEY,UKEY);
                criaString.addCampo(DESCRICAO_PAIS, DESCRICAO_PAIS);
                criaString.addCampo(CODIGO_PAIS, CODIGO_PAIS);
                string sql = criaString.insert();
                acessaBanco.criaConexao();
                acessaBanco.limpaParametros();
                acessaBanco.adicionaParametros(UKEY, pais.Ukey);
                acessaBanco.adicionaParametros(DESCRICAO_PAIS, pais.Nome);
                acessaBanco.adicionaParametros(CODIGO_PAIS, pais.Codigo);

                acessaBanco.executaManipulacao(CommandType.Text, sql);

            }
            catch
            {
                throw new Exception();
            }
        }

        public PaisCollection pesquisa(string nome, string codigo, string operadorNome, string operadorCodigo, string valorEntreNome, string valorEntreCodigo)
        {
            DataTable dataTable = new DataTable();
            PaisCollection paisCollection = new PaisCollection();
            string ukey = "";
            criaString.addCampo(UKEY);
            criaString.addCampo(DESCRICAO_PAIS);
            criaString.addCampo(CODIGO_PAIS);
            criaString.addWhere(DESCRICAO_PAIS, DESCRICAO_PAIS, operadorNome, valorEntreNome);
            criaString.addWhere(CODIGO_PAIS, CODIGO_PAIS, operadorCodigo, valorEntreCodigo);
            string select = criaString.select();
            acessaBanco.criaConexao();
            acessaBanco.limpaParametros();
            acessaBanco.adicionaParametros(DESCRICAO_PAIS, nome);
            acessaBanco.adicionaParametros(CODIGO_PAIS, codigo);

            dataTable = acessaBanco.ExecutaConsulta(CommandType.Text, select);

            foreach (DataRow linha in dataTable.Rows)
            {
                Pais pais = new Pais();
                ukey = Convert.ToString(linha["ukey"]);
                pais.Ukey = Guid.Parse(ukey);
                pais.Nome = Convert.ToString(linha["descricaoPais"]);
                pais.Codigo = Convert.ToString(linha["codigoPais"]);
                paisCollection.Add(pais);
            }
            return paisCollection;
        }
    }
}
