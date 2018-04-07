using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Entidades;
using Repositorio.Dao.Repositorios.Base;
using Repositorio.Dao.Contexto;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Linq.Expressions;

namespace Repositorio.Dao.Repositorios
{
    public class PaisRepositorio : Repositorio<Pais>
    {
        /// <summary>
        /// Função para inserir o pais no banco de dados
        /// </summary>
        /// <param name="pais"></param>
        public void inserir(Pais pais)
        {
            using (var repPais = new PaisRepositorio())
            {
                string nome = "Brasil";
                repPais.Adicionar(pais);
                repPais.SalvarTodos();
                BDContexto contexto = new BDContexto();
                var data = contexto.Set<Pais>().SqlQuery("SELECT * FROM PAIS WHERE NOME = @NOME", nome);
            }
        }

        public void alterar(Pais pais)
        {

        }

        public void excluir(string ukey)
        {

        }

        public async Task<PaisCollection> pesquisaAsync(string nome, string codigo, string operadorNome, string operadorCodigo)
        {
            var filtro = "Pais => Pais.Nome." + operadorNome + "(" + nome + ")";
            var opcoes = ScriptOptions.Default.AddReferences(typeof(Repositorio.Dao.Repositorios.PaisRepositorio).Assembly);
            Func<Pais, bool> filtroPais = await CSharpScript.EvaluateAsync<Func<Pais, bool>>(filtro, opcoes);
            PaisCollection listaPaises = null;
            Pais pais = new Pais();
            var repPais = new PaisRepositorio();
            BDContexto paisContexto = new BDContexto();
            paisContexto.Pais.Where(filtroPais);

            var resultado = repPais.Get(filtroPais);
            foreach (var p in resultado)
            {
                pais = p;
                listaPaises.Add(pais);
            }
            return listaPaises;
        }
    }
}
