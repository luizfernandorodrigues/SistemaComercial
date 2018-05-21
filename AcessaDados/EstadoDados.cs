using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Modelo;
using System.Data;

namespace AcessaDados
{
    public class EstadoDados
    {
        //dados da tabela do banco de dados
        private const string TABELA = "tblEstado";
        private const string UKEY = "ukey";
        private const string DESCRICAO_ESTADO = "descricaoEstado";
        private const string SIGLA_ESADO = "siglaEstado";
        private const string UKEY_PAIS = "pais_ukey";

        AcessaBanco acessaBanco = new AcessaBanco();
        CriaStringSql criaString = new CriaStringSql("tblEstado");

        /// <summary>
        /// Método que insere no banco de dados o objeto estado
        /// </summary>
        /// <param name="estado"></param>
        public void insert(Estado estado)
        {
            try
            {
                criaString.addCampo(UKEY, UKEY);
                criaString.addCampo(DESCRICAO_ESTADO, DESCRICAO_ESTADO);
                criaString.addCampo(SIGLA_ESADO, SIGLA_ESADO);
                criaString.addCampo(UKEY_PAIS, UKEY_PAIS);
                string sql = criaString.insert();
                acessaBanco.criaConexao();
                acessaBanco.limpaParametros();
                acessaBanco.adicionaParametros(UKEY, estado.Ukey);
                acessaBanco.adicionaParametros(DESCRICAO_ESTADO, estado.DescricaoEstado);
                acessaBanco.adicionaParametros(SIGLA_ESADO, estado.SiglaEstado);
                acessaBanco.adicionaParametros(UKEY_PAIS, estado.Pais_ukey);

                acessaBanco.executaManipulacao(CommandType.Text, sql);
            }
            catch
            {
                throw new Exception();
            }
        }

    }
}

