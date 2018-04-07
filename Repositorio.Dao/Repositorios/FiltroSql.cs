using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dao.Repositorios
{
    public class FiltroSql
    {
        enum filtro
        {
            IniciadoPor ,
            Igual,
            Entre,
            MaiorIgual,
            MenorIgual,
            Contem,
            DiferenteDe,
            TerminadoPor
        }
        public String query(string tabela, string[] campos,  string[] operador)
        {
            string select = "SELECT * FROM ";
            string where = " WHERE ";
            string filtro = "";

            if(operador.Length > 1)
            {
                foreach(var op in operador)
                {
                    switch (op)
                    {
                        case "1":
                            filtro = " LIKE ";
                            break;
                        case "2":
                            filtro = " = ";
                            break;
                        case "3":
                            filtro = " BETWEEN ";
                            break;
                        case "4":
                            filtro = " >= ";
                            break;
                        case "5":
                            filtro = " <= ";
                            break;
                        case "6":
                            filtro = " LIKE ";
                            break;
                        case "7":
                            filtro = " <> ";
                            break;
                        case "8":
                            filtro = " LIKE ";
                            break;
                        default:
                            break;
                    }

                }

            }

            if (campos.Length >0)
            {
                foreach (var campo in campos)
                {
                    select += tabela + where + campo +filtro +"@"+campo+", ";
                }
            }
            return select;

        }
    }
}
