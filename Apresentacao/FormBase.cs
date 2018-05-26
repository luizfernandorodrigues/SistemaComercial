using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento load ocorre quando o formPais é carregado
        /// **Criado Rotina de setar as dicas quando o mouse passa sobre os botões de controles e navegação do formPais
        ///     Autor: Luiz Fernando
        ///     Data : 20/04/2018
        ///   Versão : 1.0.1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBase_Load(object sender, EventArgs e)
        {
            toolTipCadastro.SetToolTip(btnAnterior, Util.BOTAO_ANTERIOR);
            toolTipCadastro.SetToolTip(btnDesfazer, Util.BOTAO_DESFAZER);
            toolTipCadastro.SetToolTip(btnEditar, Util.BOTAO_EDITAR);
            toolTipCadastro.SetToolTip(btnExcluir, Util.BOTAO_EXCLUIR);
            toolTipCadastro.SetToolTip(btnNovo, Util.BOTAO_NOVO);
            toolTipCadastro.SetToolTip(btnPesquisa, Util.BOTAO_PESQUISA);
            toolTipCadastro.SetToolTip(btnPrimeiroRegistro, Util.BOTAO_PRIMEIRO);
            toolTipCadastro.SetToolTip(btnProximo, Util.BOTAO_PROXIMO);
            toolTipCadastro.SetToolTip(btnRelatorio, Util.BOTAO_RELATORIO);
            toolTipCadastro.SetToolTip(btnSalvar, Util.BOTAO_SALVAR);
            toolTipCadastro.SetToolTip(btnUltimoRegistro, Util.BOTAO_ULTIMO);
            toolTipCadastro.SetToolTip(btnSair, Util.BOTAO_SAIR);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Util.botaoNovo(this);
            textBox1.Text = "Controles";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public bool b_grava()
        {
            return false;
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {

        }
    }
}
