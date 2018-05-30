using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilitarios;
using AcessaDados;
using Modelo;

namespace Apresentacao
{
    public partial class FormCampoPesquisaCadastro : Apresentacao.FormBase
    {
        PreencheComboBox preencheCombo = new PreencheComboBox();
        private int flag = 1;
        CampoPesquisaCollection campos = new CampoPesquisaCollection();
        FormPesquisaCadastro frm;
          
        public FormCampoPesquisaCadastro(FormPesquisaCadastro formPesquisaCadastro)
        {
            InitializeComponent();
            frm = formPesquisaCadastro;
        }

        private void FormCampoPesquisaCadastro_Load(object sender, EventArgs e)
        {
            preencheCombo.combo(cbxOperador);
            preencheCombo.tipo(cbxTipo);
            btnPesquisa.Visible = false;
            btnRelatorio.Visible = false;
        }

        /// <summary>
        /// Evento do botão salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //inserindo
            if (flag == 1)
            {
                try
                {
                    preencheObjeto();
                    Util.botaoSalvar(this);
                }
                catch (Exception ex)
                {
                    Util_Msg.atencao(Util.MENSAGEM_ERRO + ex.Message);
                }
            }
            //alterando
            else if (flag == 2)
            {

            }
        }

        /// <summary>
        /// Método para preencher o obejto
        /// </summary>
        private void preencheObjeto()
        {
            CampoPesquisa campoPesquisa = new CampoPesquisa();
            campoPesquisa.Pesquisa_ukey = FormPesquisaCadastro.ukey;
            campoPesquisa.Ukey = Guid.NewGuid();
            campoPesquisa.TabelaCampo = txtTabela.Text.Trim();
            campoPesquisa.Campo = txtCampo.Text.Trim();
            campoPesquisa.OperadorCampo = Convert.ToInt32(cbxOperador.SelectedValue.ToString());
            campoPesquisa.TipoCampo = Convert.ToInt32(cbxTipo.SelectedValue.ToString());
            FormPesquisaCadastro.campoPesquisas.Add(campoPesquisa);
        }

        /// <summary>
        /// Evento que ocorre quando o form é fechado, utilizado para 
        /// preencher a grid do form de cadastro de pesquisa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCampoPesquisaCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.preencheGrid();
        }

        /// <summary>
        /// Evento do botão sair, chama o preenche grid do form de cadastro de pesquisa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSair_Click(object sender, EventArgs e)
        {
            frm.preencheGrid();
        }
    }
}
