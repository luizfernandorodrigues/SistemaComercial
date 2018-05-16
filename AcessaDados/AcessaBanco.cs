using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessaDados
{
   public class AcessaBanco
    {
        #region propriedades da classe
        private string server;
        private string banco;
        private string senha;
        private string usuario;
        #endregion

        public SqlConnection criaConexao()
        {
            //busca os dados de acesso ao servidor atraves do conecta
            try
            {
                string caminho = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
                string nomeArquivo = "conecta.txt";
                string caminhoAbsoluto = Path.Combine(caminho, nomeArquivo);
                string[] array = File.ReadAllLines(caminhoAbsoluto);
                string aux = array[0];
                string[] arrayaux = aux.Split(',');
                server = arrayaux[0];
                usuario = arrayaux[1];
                senha = arrayaux[2];
                banco = arrayaux[3];
                return new SqlConnection("Data Source = " + server + "; Initial Catalog = " + banco + "; Persist Security Info = True; User ID = " + usuario + "; Password = " + senha + "");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        private SqlParameterCollection sqlParametros = new SqlCommand().Parameters;

        public void limpaParametros()
        {
            this.sqlParametros.Clear();
        }

        public void adicionaParametros(string nomeParametro, object valorParametro)
        {
            sqlParametros.Add(new SqlParameter(nomeParametro, valorParametro));
            
        }

        public void executaManipulacao(CommandType commandType, string sql)
        {
            SqlConnection sqlConnection = criaConexao();

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = sql;
                sqlCommand.CommandTimeout = 7200;

                foreach (SqlParameter sqlParameter in sqlParametros)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Metodo que executa consulta no banco de dados retorna uma dataTable(tabela de dados)
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable ExecutaConsulta(CommandType commandType, string sql)
        {
            //criar conexao
            SqlConnection sqlconnection = criaConexao();
            try
            {

                //abre a conexao
                sqlconnection.Open();
                //cria comando que vai levar informação para o banco de dados
                SqlCommand sqlCommand = sqlconnection.CreateCommand();
                //colocando as coisas dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = sql;
                sqlCommand.CommandTimeout = 7200;//tempo maximo de uma execução
                //adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParametros)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //criar um adapatador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //crias um data table vazia
                DataTable dataTable = new DataTable();
                //preenchimento da DataTable que estava vazia
                sqlDataAdapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            //fecho a conexão com o banco 
            finally
            {
                sqlconnection.Close();
            }

        }
        /// <summary>
        /// Função que busca dos dados do servidor de banco de dados a partir de um arquivo 
        /// </summary>
        /// <returns></returns>
        private string conecta()
        {
            string conecta = "";
            string server = "";
            string usuario = "";
            string senha = "";
            string banco = "";
            string[] array = File.ReadAllLines(@"C:\JMTI\conecta.txt");
            string aux = array[0];
            string[] arrayaux = aux.Split(',');
            server = arrayaux[0];
            usuario = arrayaux[1];
            senha = arrayaux[2];
            banco = arrayaux[3];
            return conecta = "Data Source = " + server + "; Initial Catalog = " + banco + "; Persist Security Info = True; User ID = " + usuario + "; Password = " + senha + "";
        }
    }
}
