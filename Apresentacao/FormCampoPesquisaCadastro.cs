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
        CampoPesquisa campoPesquisa = new CampoPesquisa();
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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                preencheObjeto();
                campos.Add(campoPesquisa);

            }
            catch (Exception ex)
            {
                Util_Msg.atencao(Util.MENSAGEM_ERRO + ex.Message);
            }
        }

        private void preencheObjeto()
        {
            campoPesquisa.Ukey = Guid.NewGuid();
            campoPesquisa.TabelaCampo = txtTabela.Text.Trim();
            campoPesquisa.Campo = txtCampo.Text.Trim();
            campoPesquisa.OperadorCampo = Convert.ToInt32(cbxOperador.SelectedValue.ToString());
            campoPesquisa.TipoCampo = Convert.ToInt32(cbxTipo.SelectedValue.ToString());
        }

        private void FormCampoPesquisaCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.preencheGrid(campos);
        }
    }
}
