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
                criaString.addCampo(UKEY, UKEY);
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

        /// <summary>
        /// Método de pesquisa de pais, retorna uma coleçao de pais
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="codigo"></param>
        /// <param name="operadorNome"></param>
        /// <param name="operadorCodigo"></param>
        /// <param name="valorEntreNome"></param>
        /// <param name="valorEntreCodigo"></param>
        /// <returns></returns>
        public PaisCollection pesquisa(string nome, string codigo, string operadorNome, string operadorCodigo, string valorEntreNome, string valorEntreCodigo)
        {
            DataTable dataTable = new DataTable();
            PaisCollection paisCollection = new PaisCollection();
            string select = "";
            string ukey = "";
            //verifico se não passa parametro executo select * from
            if (nome.Equals("") && codigo.Equals(""))
            {
                select = "select ukey, descricaoPais,codigoPais from tblPais";
            }
            else
            {
                criaString.addCampo(UKEY);
                criaString.addCampo(DESCRICAO_PAIS);
                criaString.addCampo(CODIGO_PAIS);
                //verifico se os campos não esta vazio
                if (!nome.Equals(""))
                {
                    //colcoar % no nome quando for like
                    switch (operadorNome)
                    {
                        case "1":
                            nome = nome + "%";
                            break;
                        case "6":
                            nome = "%" + nome + "%";
                            break;
                        case "8":
                            nome = "%" + nome;
                            break;
                    }

                }
                if (!codigo.Equals(""))
                {
                    //colocar "%' quando for like o operador 1,6,8
                    switch (operadorCodigo)
                    {
                        //iniciado por
                        case "1":
                            codigo = codigo + "%";
                            break;
                        case "6":
                            codigo = "%" + codigo + "%";
                            break;
                        case "8":
                            codigo = "%" + codigo;
                            break;
                    }
                }
                criaString.addWhere(DESCRICAO_PAIS, DESCRICAO_PAIS, operadorNome, valorEntreNome, nome);
                criaString.addWhere(CODIGO_PAIS, CODIGO_PAIS, operadorCodigo, valorEntreCodigo, codigo);
                select = criaString.select();
            }
            acessaBanco.criaConexao();
            acessaBanco.limpaParametros();
            Console.WriteLine(nome);
            Console.WriteLine(codigo);
            //teste de nomes de parametros pode ser aqui o erro
            acessaBanco.adicionaParametros("@" + DESCRICAO_PAIS, nome);
            acessaBanco.adicionaParametros("@" + CODIGO_PAIS, codigo);

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

        /// <summary>
        /// Método para fazer o update do registro no banco de dados
        /// </summary>
        /// <param name="pais"></param>
        public void update(Pais pais)
        {
            try
            {
                criaString.addCampo(DESCRICAO_PAIS, DESCRICAO_PAIS);
                criaString.addCampo(CODIGO_PAIS, CODIGO_PAIS);
                criaString.addWhere(UKEY, UKEY);
                string sql = criaString.Update();
                acessaBanco.criaConexao();
                acessaBanco.limpaParametros();
                acessaBanco.adicionaParametros("@"+DESCRICAO_PAIS, pais.Nome);
                acessaBanco.adicionaParametros("@"+CODIGO_PAIS, pais.Codigo);
                acessaBanco.adicionaParametros("@"+UKEY, pais.Ukey);
                acessaBanco.executaManipulacao(CommandType.Text, sql);
            }
            catch
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Método para realizar o delete no banco de dados
        /// </summary>
        /// <param name="pais"></param>
        public void delete (Pais pais)
        {
            try
            {
                criaString.addWhere(UKEY, UKEY);
                string sql = criaString.delete();
                acessaBanco.criaConexao();
                acessaBanco.limpaParametros();
                acessaBanco.adicionaParametros("@", pais.Ukey);
                acessaBanco.executaManipulacao(CommandType.Text, sql);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
