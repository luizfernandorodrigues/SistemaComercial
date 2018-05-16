using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilitarios
{
    /// <summary>
    /// Classe responsavel pelas caixas de dialogo com o usuario
    /// um atalho para a classe MessageBox
    /// </summary>
    public static  class Util_Msg
    {
        private const string titulo = "SGC Informa!";
        
        /// <summary>
        /// Função responsavel por mostrar uma mensagem de Sim e Não
        /// retorna um Dialogresult sendo "sim" ou "Não"
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static DialogResult simNao(string texto)
        {
            DialogResult result;
            result = MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }
        /// <summary>
        /// Função para mostrar um aviso ao usuario
        /// recebe uma string com o texto desejado
        /// Ex: "Registro Cadastradi com Sucesso"
        /// </summary>
        /// <param name="texto"></param>
        public static void aviso(string texto)
        {
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Função para mostrar um aviso de erro ao usuario
        /// recebe uma string com o erro
        /// </summary>
        /// <param name="texto"></param>
        public static void erro(string texto)
        {
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// função responsavel para exibir um aviso ao usuario de atenção
        /// recebe uma string com o aviso de Warning
        /// </summary>
        /// <param name="texto"></param>
        public static void atencao(string texto)
        {
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
