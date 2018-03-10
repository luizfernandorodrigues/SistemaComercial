using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Apresentacao
{
   public static class Util
    {
        public const string TITULO = "JMSoft";
        public static string VERSAO = "Versão 1.1.1";
        public const string BOTAO_NOVO = "Adicionar Registro!";
        public const string BOTAO_EDITAR = "Editar Registro!";
        public const string BOTAO_EXCLUIR = "Excluir Registro!";
        public const string BOTAO_DESFAZER = "Desfazer Alterações!";
        public const string BOTAO_SAIR = "Sair da Tela!";
        public const string BOTAO_PRIMEIRO = "Primeiro Registro!";
        public const string BOTAO_ULTIMO = "Ultimo Registro!";
        public const string BOTAO_ANTERIOR = "Registro Anterior!";
        public const string BOTAO_PROXIMO = "Próximo Registro!";
        public const string BOTAO_RELATORIO = "Abrir Relatórios!";
        public const string BOTAO_PESQUISA = "Abrir Pesquisa!";
        public const string BOTAO_SALVAR = "Gravar Registro!";
        public const string MENSAGEM_SUCESSO = "Registro Gravado com Sucesso!";
        public const string MENSAGEM_ERRO = "Não Foi Possivel Gravar o Registro!\n Causa: ";
        public const string BOTAO_CARREGA_SELECIONADO = "Carregar selecionados!";
        public const string BOTAO_SELECIONA_TUDO = "Selecionar Todos Registros!";
        public const string BOTAO_DESMARCA_TUDO = "Desmarcar Tudo!";
        public const string BOTAO_EXPORTAR_EXCEL = "Exportar Registros Selecionado para Excel!";

        public static Guid usuarioLogado;
        public static Guid empresaLogado;

        public enum Flags
        {
            Novo = 1,
            Editar = 2,
            Excluir = 3
        };
        /// <summary>
        /// Função para habilitar o botão novo do form, quando chamada a função habilita
        /// os campos e desabilita os botões desnecessarios para o estado de inclusão
        /// </summary>
        /// <param name="ctrl"></param>
        public static void habilitaCamposNovos(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is NumericUpDown)
                {
                    c.Enabled = true;
                }
                else if (c is CheckBox)
                {
                    c.Enabled = true;
                }
                else if (c is DateTimePicker)
                {
                    c.Enabled = true;
                }
                else if (c is TextBox)
                {
                    c.Enabled = true;
                }
                else if (c is RadioButton)
                {
                    c.Enabled = true;
                }
                else if (c is ComboBox)
                {
                    c.Enabled = true;
                }
                else if (c is MaskedTextBox)
                {
                    c.Enabled = true;
                }
                else if (c is DataGridView)
                {
                    c.Enabled = true;
                }
                else if (c is BindingNavigator)
                {
                    c.Enabled = true;
                }
                else if (c is Button)
                {
                    c.Enabled = true;
                }
                if (c.HasChildren)
                {
                    habilitaCamposNovos(c);
                }
            }
            desabilitaBotoesNovo(ctrl);
        }

        /// <summary>
        /// Função para desabilitar os botões quando o form entra em estado de inclusão
        /// </summary>
        /// <param name="ctr"></param>
        public static void desabilitaBotoesNovo(Control ctr)
        {
            foreach (Control c in ctr.Controls)
            {
                if (c is Button && c.Name.Equals("buttonExcluir"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonSair"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonPesquisa"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonProximo"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonUltimo"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonAnterior"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonPrimeiro"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonNovo"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonEditar"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonRelatorio"))
                {
                    c.Enabled = false;
                }
                if (c.HasChildren)
                {
                    desabilitaBotoesNovo(c);
                }
            }
        }

        /// <summary>
        /// Função para desabilitar os campos quando clicar no botão salvar
        /// </summary>
        /// <param name="ctrl"></param>
        public static void desabilitaCamposNovo(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is NumericUpDown)
                {
                    c.Enabled = false;
                }
                else if (c is CheckBox)
                {
                    c.Enabled = false;
                }
                else if (c is DateTimePicker)
                {
                    c.Enabled = false;
                }
                else if (c is TextBox)
                {
                    c.Enabled = false;
                }
                else if (c is RadioButton)
                {
                    c.Enabled = false;
                }
                else if (c is ComboBox)
                {
                    c.Enabled = false;
                }
                else if (c is MaskedTextBox)
                {
                    c.Enabled = false;
                }
                else if (c is Button)
                {
                    c.Enabled = false;
                }
                if (c.HasChildren)
                {
                    desabilitaCamposNovo(c);
                }
            }
            habilitaBotoesNovo(ctrl);
        }

        /// <summary>
        /// Função para habilitar botões depois que clicar em salvar no modo de inclusão e alteração
        /// </summary>
        /// <param name="ctr"></param>
        public static void habilitaBotoesNovo(Control ctr)
        {
            foreach (Control c in ctr.Controls)
            {
                if (c is Button && c.Name.Equals("buttonExcluir"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonSair"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonPesquisa"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonProximo"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonUltimo"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonAnterior"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonPrimeiro"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonNovo"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonEditar"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonRelatorio"))
                {
                    c.Enabled = true;
                }
                if (c.HasChildren)
                {
                    habilitaBotoesNovo(c);
                }
            }
        }

        /// <summary>
        /// função para criar senha criptografada, recebe a senha como string e retorna o hash como string para armazenar no banco
        /// </summary>
        /// <param name="senha"></param>
        /// <returns></returns>
       // public static string codificaSenha(string senha)
        //{
            //return Crypter.
        //}

        /// <summary>
        /// Função para comparar senha, recebe o hash referente ao usuário e a senha informada return true ou false
        /// </summary>
        /// <param name="senha"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        /*public static bool compara(string senha, string hash)
        {
           // return Crypter.CheckPassword(senha, hash);
        }*/
        /// <summary>
        /// Função responsavel por desfazer o estado atual de um form
        /// no momento somente desfaz em modo de adicionar registro.
        /// necessita modificar pra gravar um objeto em memoria e depois recupera-lo se necessario
        /// </summary>
        /// <param name="ctr"></param>
        public static void desfazerEstadoNovo(Control ctr)
        {
            desabilitaCamposNovo(ctr);

            foreach (Control c in ctr.Controls)
            {
                if (c is Button && c.Name.Equals("buttonSair"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonPesquisa"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonProximo"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonUltimo"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonAnterior"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonPrimeiro"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonNovo"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonRelatorio"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("buttonExcluir"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonEditar"))
                {
                    c.Enabled = false;
                }
                if (c.HasChildren)
                {
                    habilitaBotoesNovo(c);
                }
            }

        }


    }
}
