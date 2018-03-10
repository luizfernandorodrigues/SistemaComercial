using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apresentacao;
using Utilitarios;
namespace Apresentacao
{
    public static class Validacao
    {
        public static IEnumerable<ValidationResult> getValidationErros(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }

        public static int ValidarEntidade(object obj)
        {
            var erros = Validacao.getValidationErros(obj);
            int quantidadeErro = erros.Count();
            foreach (var error in erros)
            {
                Util_Msg.atencao(error.ErrorMessage);
               
            }
            return quantidadeErro;
        }
    }
}
