using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Entidades;
using Repositorio.Dao.Repositorios.Base;

namespace Repositorio.Dao.Repositorios
{
    public class CepRepositorio : Repositorio<Cep>
    {

        public List<Cep> buscaCep(string cep, string cidade, string operadorCep, string operadorCidade, string cepEntre, string cidadeEntre)
        {
           string filtro = operadorCep;
            List<Cep> lstCep = new List<Cep>();
            using (var repositorioCep = new CepRepositorio())
            {
                // se cep e cidade for nulos retorna tudo
                if (string.IsNullOrEmpty(cidade) && string.IsNullOrEmpty(cep))
                {
                    lstCep = repositorioCep.GetAll().ToList<Cep>();
                }
                else
                {
                    lstCep = repositorioCep.Get(c => c.Cepe + ".filtro" + (cep)).ToList<Cep>();
                }

                lstCep = repositorioCep.Get(c => c.Cepe.Equals(cep)).ToList<Cep>();
                return lstCep;
            }

        }
    }
}