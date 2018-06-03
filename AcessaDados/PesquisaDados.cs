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
            string sql;
            try
            {
                acessaBanco.abrirTransacao();
                CriaStringSql criaStringSqlPesquisa = new CriaStringSql("tblPesquisa");
                //adiciono os campo da insert da capa da pesquisa
                criaString.addCampo(UKEY, UKEY);
                criaString.addCampo(CODIGO_PESQUISA, CODIGO_PESQUISA);
                criaString.addCampo(NOME_PESQUISA, NOME_PESQUISA);
                criaString.addCampo(TELA_PESQUISA, TELA_PESQUISA);
                criaString.addCampo(RELATORIO, RELATORIO);
                criaString.addCampo(SELECT_PESQUISA, SELECT_PESQUISA);

                //limpo os paramtros da coleção e começo adicionar paramtros da capa
                acessaBanco.limpaParametros();
                acessaBanco.adicionaParametros(UKEY, pesquisa.Ukey);
                acessaBanco.adicionaParametros(CODIGO_PESQUISA, pesquisa.CodigoPesquisa);
                acessaBanco.adicionaParametros(NOME_PESQUISA, pesquisa.NomePesquisa);
                acessaBanco.adicionaParametros(TELA_PESQUISA, pesquisa.TelaPesquisa);
                acessaBanco.adicionaParametros(RELATORIO, pesquisa.Relatorio);
                acessaBanco.adicionaParametros(SELECT_PESQUISA, pesquisa.SelectPesquisa);

                //crio a string de insert e adiciono ela em uma lista do tipo string
                sql = criaString.insert();
                acessaBanco.transacaoSql(CommandType.Text, sql);
                //crio outra instancia do objeto de criar stringsql e passo a tabela de campos da pesquisa

                CriaStringSql criaStringCampo = new CriaStringSql("tblCampoPesquisa");

                //adiciono os campo da insert dos campos da pesquisa
                criaStringCampo.addCampo(UKEY_CAMPO, UKEY_CAMPO);
                criaStringCampo.addCampo(TABELA_CAMPO, TABELA_CAMPO);
                criaStringCampo.addCampo(CAMPO, CAMPO);
                criaStringCampo.addCampo(OPERADOR_CAMPO, OPERADOR_CAMPO);
                criaStringCampo.addCampo(TIPO_CAMPO, TIPO_CAMPO);
                criaStringCampo.addCampo(PESQUISA_UKEY, PESQUISA_UKEY);

                //cria a sql de insert de campos
                sql = criaStringCampo.insert();

                //laço para percorrer a lista de campos passado como parametro e adiciona 
                foreach (var campo in campoPesquisa)
                {
                    CampoPesquisa cp = new CampoPesquisa();
                    cp = campo;
                    acessaBanco.limpaParametros();
                    acessaBanco.adicionaParametros(UKEY_CAMPO, cp.Ukey);
                    acessaBanco.adicionaParametros(TABELA_CAMPO, cp.TabelaCampo);
                    acessaBanco.adicionaParametros(CAMPO, cp.Campo);
                    acessaBanco.adicionaParametros(OPERADOR_CAMPO, cp.OperadorCampo);
                    acessaBanco.adicionaParametros(TIPO_CAMPO, cp.TipoCampo);
                    acessaBanco.adicionaParametros(PESQUISA_UKEY, cp.Pesquisa_ukey);

                    //chamo o metodo para executar o comando
                    acessaBanco.transacaoSql(CommandType.Text, sql);
                }
                //faço o commiti dos dados no banco
                acessaBanco.commit();

            }
            catch(Exception ex)
            {
                Util_Log.log(ex.Message);
                throw;
            }
        }
    }
}
