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

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlTransaction sqlTransaction;
        #endregion

        /// <summary>
        /// Construtor da classe, quando a mesma for instanciada ja cria a conexão
        /// </summary>
        public AcessaBanco()
        {
            sqlConnection = criaConexao();
        }

        /// <summary>
        /// Método para criar a conexão com o banco de dados, os dados do servidor de banco de dados fica em um arquivo
        /// chamado conecta.txt que fica no diretorio de execução do exe
        /// </summary>
        /// <returns></returns>
        public SqlConnection criaConexao()
        {
            //busca os dados de acesso ao servidor atraves do conecta
            try
            {
                //pega o caminho do executavel da aplicação
                string caminho = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
                string nomeArquivo = "conecta.txt";

                //conbinação do caminho com o nome do arquivo para fazer a leitura
                string caminhoAbsoluto = Path.Combine(caminho, nomeArquivo);

                //guardo as linhas em um array e pego a primeira e extrai os dados
                //exempplo de escrita dentro do arquivo: servidor,usuario,senha,banco
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

        //variavel local do tipo coleção de parametros onde é alimentada pelo método adicionaParametros
        private SqlParameterCollection sqlParametros = new SqlCommand().Parameters;

        /// <summary>
        /// Metodo que remove todos parametros da coleção
        /// </summary>
        public void limpaParametros()
        {
            sqlParametros.Clear();
        }

        /// <summary>
        /// Método que adiciona parametros na coleção local
        /// </summary>
        /// <param name="nomeParametro"></param>
        /// <param name="valorParametro"></param>
        public void adicionaParametros(string nomeParametro, object valorParametro)
        {
            sqlParametros.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        /// <summary>
        /// Método que executa manipulação no banco de dados
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="sql"></param>
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
        /// Método para fazer transação com mais de uma tabela
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="sql"></param>
        public void transacaoSql(CommandType commandType, string sql)
        {
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = commandType;
            sqlCommand.CommandText = sql;
            sqlCommand.CommandTimeout = 7200;
            sqlCommand.Transaction = sqlTransaction;

            foreach (SqlParameter sqlParameter in sqlParametros)
            {
                sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
            }
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Método para efetivas as transações no banco de dados
        /// </summary>
        public void commit()
        {
            try
            {
                sqlTransaction.Commit();
                close();
            }
            catch (Exception)
            {
                sqlTransaction.Rollback();
                close();
                throw;
            }
            finally
            {
                close();
            }
        }

        /// <summary>
        /// Método para abrir a transãção no banco de dados
        /// </summary>
        public void abrirTransacao()
        {
            sqlConnection.Open();
            sqlTransaction = sqlConnection.BeginTransaction();
        }

        /// <summary>
        /// Método para fechar a conexão com o banco de dados
        /// </summary>
        public void close()
        {
            sqlConnection.Close();
        }
        /// <summary>
        /// Metodo que executa consulta no banco de dados retorna uma dataTable(tabela de dados)
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable ExecutaConsulta(CommandType commandType, string sql)
        {
            try
            {

                //abre a conexao
                sqlConnection.Open();
                //cria comando que vai levar informação para o banco de dados
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
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
                sqlConnection.Close();
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
