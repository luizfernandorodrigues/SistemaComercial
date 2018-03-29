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
                repPais.Adicionar(pais);
                repPais.SalvarTodos();
            }
        }

        public void alterar(Pais pais)
        {

        }

        public void excluir(string ukey)
        {

        }

        public async Task<PaisCollection> pesquisaAsync(string nome, string codigo, int operadorNome, int operadorCodigo)
        {
            var filtro = "Pais => Pais.Nome" + operadorNome + nome;
            var opcoes = ScriptOptions.Default.AddReferences(typeof(Pais).Assembly);
            Func<Pais, bool> filtroPais = await CSharpScript.EvaluateAsync<Func<Pais, bool>>(filtro, opcoes);
            PaisCollection listaPaises = null;
            Pais pais = new Pais();
            using (var repPais = new PaisRepositorio())
            {
                var resultado = repPais.Get(filtroPais);
               foreach(var p in resultado)
                {
                    pais = p;
                    listaPaises.Add(pais);
                }
                return listaPaises;
            }

            
        }
    }
}
