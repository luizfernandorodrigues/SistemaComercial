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
        /// Evento load ocorre quando o form é carregado
        /// **Criado Rotina de setar as dicas quando o mouse passa sobre os botões de controles e navegação do form
        ///     Autor: Luiz Fernando
        ///     Data : 20/04/2018
        ///   Versão : 1.0.1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBase_Load(object sender, EventArgs e)
        {
            this.toolTipCadastro.SetToolTip(this.btnAnterior, Util.BOTAO_ANTERIOR);
            this.toolTipCadastro.SetToolTip(this.btnDesfazer, Util.BOTAO_DESFAZER);
            this.toolTipCadastro.SetToolTip(this.btnEditar, Util.BOTAO_EDITAR);
            this.toolTipCadastro.SetToolTip(this.btnExcluir, Util.BOTAO_EXCLUIR);
            this.toolTipCadastro.SetToolTip(this.btnNovo, Util.BOTAO_NOVO);
            this.toolTipCadastro.SetToolTip(this.btnPesquisa, Util.BOTAO_PESQUISA);
            this.toolTipCadastro.SetToolTip(this.btnPrimeiroRegistro, Util.BOTAO_PRIMEIRO);
            this.toolTipCadastro.SetToolTip(this.btnProximo, Util.BOTAO_PROXIMO);
            this.toolTipCadastro.SetToolTip(this.btnRelatorio, Util.BOTAO_RELATORIO);
            this.toolTipCadastro.SetToolTip(this.btnSalvar, Util.BOTAO_SALVAR);
            this.toolTipCadastro.SetToolTip(this.btnUltimoRegistro, Util.BOTAO_ULTIMO);
            this.toolTipCadastro.SetToolTip(this.btnSair, Util.BOTAO_SAIR);
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
