using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Utilitarios;
using AcessaDados;
using System.Collections;

namespace Apresentacao
{
    public partial class FormPaisCadastro : Apresentacao.FormBase
    {
        Pais pais = new Pais();
        PaisDados paisDados = new PaisDados();
        int flag = 1;
        public static PaisCollection paisCollection;
        public FormPaisCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                this.salvar();
                this.valida();
                try
                {
                    paisDados.insert(pais);
                    Util_Msg.aviso(Util.MENSAGEM_SUCESSO);
                    Util.botaoSalvar(this);
                }
                catch (Exception ex)
                {
                    Util_Msg.erro(Util.MENSAGEM_ERRO + ex.Message);
                    return;
                }
            }
            else if (flag == 2)
            {

            }

        }

        private void FormPaisCadastro_Load(object sender, EventArgs e)
        {

        }

        private void salvar()
        {
            pais.Ukey = Guid.NewGuid();
            pais.Nome = txtNome.Text;
            pais.Codigo = txtCodigo.Text.Trim();
        }

        private void valida()
        {
            if (string.IsNullOrEmpty(pais.Codigo))
            {
                Util_Msg.atencao("Preencha o Campo Código");
                txtCodigo.Focus();
                return;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            FormPaisPesquisa frm = new FormPaisPesquisa(this);
            frm.Show();
        }
    }
}
