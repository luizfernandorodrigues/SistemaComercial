using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Utilitarios;
namespace AcessaDados
{
    public class PaisDados
    {
        AcessaBanco acessaBanco = new AcessaBanco();
        CriaStringSql criaString = new CriaStringSql("tblPais");
        ArrayList camposPais = new ArrayList();
        ArrayList valoresPais = new ArrayList();

        public void insert(Pais pais)
        {
            try
            {
                criaString.addCampo("ukey", "@ukey");
                criaString.addCampo("descricaoPais", "@descricaoPais");
                criaString.addCampo("codigoPais", "@codigoPais");
                string sql = criaString.insert();
                acessaBanco.criaConexao();
                acessaBanco.limpaParametros();
                acessaBanco.adicionaParametros("@ukey", pais.Ukey);
                acessaBanco.adicionaParametros("@descricaoPais", pais.Nome);
                acessaBanco.adicionaParametros("@codigoPais", pais.Codigo);

                acessaBanco.executaManipulacao(System.Data.CommandType.Text, sql);

            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
