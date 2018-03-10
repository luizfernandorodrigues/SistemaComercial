using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Entidades;
using Repositorio.Dao.Repositorios.Base;
using Repositorio.Dao.Contexto;

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

        public PaisCollection pesquisa(string nome, string codigo, int operadorNome, int operadorCodigo)
        {
            BDContexto ctx = new BDContexto();
            PaisCollection listaPaises = null;
            using (var repPais = new PaisRepositorio())
            {
                if (nome.Equals("") && codigo.Equals(""))
                {
                    var paises = ctx.Pais.Where(p => p.Nome.StartsWith(nome));

                    /// criar uma classe onde eu coloco todos tipos de filtros de acordo com o value da combobox
                    /// exemplo var paises = ctx.Pais.Where(p => p.Nome.StartsWith(nome)); --iniciado por
                    /// var paises = ctx.Pais.Where(p => p.Nome.Contains(nome)); -- contem
                    /// precisa bolar algo assim de acordo com o value da com o value da combobox chama a query

                }

            }

            return listaPaises;
        }
    }
}
