/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class Util_Delegate
    {
        enum TipoFiltro
        {
            IniciadoPor,
            Igual,
            Entre,
            MaiorIgual,
            MenorIgual,
            Contem,
            DiferenteDe,
            TerminadoPor

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="nomePropriedade"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public IQueryable FiltroDinamico(IQueryable query, string nomePropriedade, object valor)
        {
            return FiltroDinamico(query, nomePropriedade, valor, TipoFiltro.IniciadoPor);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="nomePropriedade"></param>
        /// <param name="valor"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
      
        public IQueryable FiltroDinamico(IQueryable query, string nomePropriedade, object valor, TipoFiltro tipo)
        {
            // o valor deverá sempre ser obrigatório?
            if (valor == null) return query;

            // a propriedade sempre deve estar preenchida?
            if (string.IsNullOrEmpty(nomePropriedade)) return query;

            ParameterExpression pExpr = Expression.Parameter(query.ElementType, "p");

            // Controi propriedades aninhadas
            string[] propsAninhadas = nomePropriedade.Split('.');
            Expression mbr = pExpr;

            // percorre as propriedades aninhadas, ex.: Cliente.PedidoVenda.Valor
            for (int i = 0; i < propsAninhadas.Length; i++)
                mbr = Expression.PropertyOrField(mbr, propsAninhadas[i]);

            LambdaExpression predicado = null;

            // cria predicados de comparação
            switch (tipo)
            {
                //maior igual
                case TipoFiltro.MaiorIgual:
                    predicado = Expression.Lambda(
                        Expression.GreaterThanOrEqual(mbr, Expression.Constant(valor)), pExpr
                    );
                    break;
                //igual
                case TipoFiltro.Igual:
                    predicado = Expression.Lambda(
                        Expression.Equal(mbr, Expression.Constant(valor)), pExpr
                    );
                    break;
                //menor igual
                case TipoFiltro.MenorIgual:
                    predicado = Expression.Lambda(
                        Expression.LessThanOrEqual(mbr, Expression.Constant(valor)), pExpr
                    );
                    break;
                case TipoFiltro.Entre:
                    predicado = Expression.Lambda(
                        Expression.LessThan(mbr, Expression.Constant(valor)), pExpr
                    );
                    break;
                //contem
                case TipoFiltro.Contem:
                    MethodInfo metodoContem = typeof(string).GetMethod("Contains", new[] { typeof(string) });
                    predicado = Expression.Lambda(
                        Expression.Call(mbr, metodoContem, Expression.Constant(valor)), pExpr
                    );
                    break;
                //diferente

                //preciso ver esse case de como fazer diferente
                /*case TipoFiltro.DiferenteDe:
                    MethodInfo diferente = typeof(string).GetMethod("StartsWiths", new[] { typeof(string) });
                    predicado = Expression.Lambda(
                        Expression.Call(mbr, diferente, Expression.Constant(valor)), pExpr
                    );
                    break;
                case TipoFiltro.TerminadoPor:
                    MethodInfo metodoTerminaCom = typeof(string).GetMethod("EndsWith", new[] { typeof(string) });
                    predicado = Expression.Lambda(
                        Expression.Call(mbr, metodoTerminaCom, Expression.Constant(valor)), pExpr
                    );
                    break;
                default:
                    // igualdade como padrão
                    // cria predicado de comparação de iniciado por
                    MethodInfo metodoIniciaCom = typeof(string).GetMethod("StartsWith", new[] { typeof(string) });
                    predicado = Expression.Lambda(
                        Expression.Call(mbr, metodoIniciaCom, Expression.Constant(valor)), pExpr
                    );
                    break;
            }

            return query.Provider.CreateQuery(
                Expression.Call(typeof(Queryable), "Where", new Type[] { query.ElementType }, query.Expression, predicado)
            );
        }
    }
}
*/