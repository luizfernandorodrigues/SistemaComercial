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
        public const string BOTAO_INVERTE_SELECAO = "Inverter seleção!";

        public static Guid usuarioLogado;
        public static Guid empresaLogado;

        public enum Flags
        {
            Novo = 1,
            Editar = 2,
            Excluir = 3
        };
        /// <summary>
        /// Metodo responsavel por controlar os controles do formPais na hora que o botão novo é acionado
        /// </summary>
        /// <param name="ctrl"></param>
        public static void botaoNovo(Control ctrl)
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
                    c.Text = "";
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
                else if (c is Button && c.Name.Equals("btnEditar"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnNovo"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnEcluir"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnSair"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnProximo"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnAnterior"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnPrimeiroRegistro"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnUltimoRegistro"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnPesquisa"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnRelatorio"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnSalvar"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnDesfazer"))
                {
                    c.Enabled = true;
                }
                if (c.HasChildren)
                {
                    botaoNovo(c);
                }
            }
        }

        /// <summary>
        /// Função para desabilitar os botões quando o formPais entra em estado de inclusão
        /// </summary>
        /// <param name="ctr"></param>
        public static void botaoSalvar(Control ctr)
        {
            foreach (Control c in ctr.Controls)
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
                else if (c is DataGridView)
                {
                    c.Enabled = false;
                }
                else if (c is BindingNavigator)
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnEditar"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnNovo"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnEcluir"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnSair"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnProximo"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnAnterior"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnPrimeiroRegistro"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnUltimoRegistro"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnPesquisa"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnRelatorio"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnSalvar"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnDesfazer"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnSalvar"))
                {
                    c.Enabled = true;
                }
                if (c.HasChildren)
                {
                    botaoSalvar(c);
                }
            }
        }

        /// <summary>
        /// Função para desabilitar os campos quando clicar no botão salvar
        /// </summary>
        /// <param name="ctrl"></param>
        public static void botaoEdita(Control ctrl)
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
                else if (c is Button && c.Name.Equals("btnEditar"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnNovo"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnEcluir"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnSair"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnProximo"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnAnterior"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnPrimeiroRegistro"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnUltimoRegistro"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnPesquisa"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnRelatorio"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnSalvar"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnDesfazer"))
                {
                    c.Enabled = true;
                }
                if (c.HasChildren)
                {
                    botaoEdita(c);
                }
            }
        }

        /// <summary>
        /// Função para habilitar botões depois que clicar em salvar no modo de inclusão e alteração
        /// </summary>
        /// <param name="ctr"></param>
        public static void botaoExcluir(Control ctr)
        {
            foreach (Control c in ctr.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                else if (c is MaskedTextBox)
                {
                    c.Text = "";
                }
                if (c.HasChildren)
                {
                    botaoExcluir(c);
                }
            }
        }

        public static void desfazerEstadoNovo(Control ctr)
        {
            botaoEdita(ctr);

            foreach (Control c in ctr.Controls)
            {
                if (c is Button && c.Name.Equals("btnSair"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnPesquisa"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnProximo"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnUltimoRegistro"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnAnterior"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnPrimeiroRegistro"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnNovo"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnRelatorio"))
                {
                    c.Enabled = true;
                }
                else if (c is Button && c.Name.Equals("btnExcluir"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("btnEditar"))
                {
                    c.Enabled = false;
                } else if(c is Button && c.Name.Equals("btnSalvar"))
                {
                    c.Enabled = false;
                }
                else if (c is TextBox)
                {
                    c.Enabled = false;
                    c.Text = "";
                } else if(c is MaskedTextBox)
                {
                    c.Enabled = false;
                }
                if (c.HasChildren)
                {
                    desfazerEstadoNovo(c);
                }
            }

        }

    }
}
