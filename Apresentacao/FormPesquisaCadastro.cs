using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using AcessaDados;
using Utilitarios;

namespace Apresentacao
{
    public partial class FormPesquisaCadastro : Apresentacao.FormBase
    {
        Pesquisa pesquisa = new Pesquisa();
        PesquisaDados pesquisaDados = new PesquisaDados();
        private int flag = 1;
        DataTable dataTable = new DataTable();
        BindingSource bindingSource = new BindingSource();
        public static CampoPesquisaCollection campoPesquisas = new CampoPesquisaCollection();
        public static Guid ukey;

        public FormPesquisaCadastro()
        {
            InitializeComponent();
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
                salvar();
                if (valida())
                {
                    try
                    {
                        pesquisaDados.insert(pesquisa, campoPesquisas);
                        Util_Msg.aviso(Util.MENSAGEM_SUCESSO);
                        Util.botaoSalvar(this);
                    }
                    catch (Exception ex)
                    {
                        Util_Msg.erro(Util.MENSAGEM_ERRO + ex.Message);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            //editando
            else if (flag == 2)
            {

            }
        }

        /// <summary>
        /// Método para preencher o objeto pesquisa
        /// </summary>
        private void salvar()
        {
            pesquisa.Ukey = ukey;
            pesquisa.NomePesquisa = txtNome.Text.Trim();
            pesquisa.CodigoPesquisa = txtCodigo.Text.Trim();
            pesquisa.TelaPesquisa = txtTela.Text.Trim();
            pesquisa.SelectPesquisa = txtSql.Text.Trim();
            if (ckbRelatorio.Checked)
            {
                pesquisa.Relatorio = 1;
            }
            else
            {
                pesquisa.Relatorio = 0;
            }

            //preenche objeto dos campo

        }

        /// <summary>
        /// Método para validar os campos do form de pesquisa
        /// </summary>
        private bool valida()
        {
            if (string.IsNullOrEmpty(pesquisa.CodigoPesquisa))
            {
                Util_Msg.atencao("Informe um Código para Pesquisa");
                txtCodigo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(pesquisa.NomePesquisa))
            {
                Util_Msg.atencao("Informe um Nome para Pesquisa");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(pesquisa.TelaPesquisa))
            {
                Util_Msg.atencao("Informe uma Tela para Pesquisa");
                txtTela.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(pesquisa.SelectPesquisa))
            {
                Util_Msg.atencao("Informe um Select para Pesquisa");
                txtSql.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Evento do botão novo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            flag = 1;
            btnNovoRegistro.Enabled = true;
            ukey = Guid.NewGuid();
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            FormCampoPesquisaCadastro frm = new FormCampoPesquisaCadastro(this);
            frm.Show();
        }

        private void FormPesquisaCadastro_Load(object sender, EventArgs e)
        {
            dgvCampos.AutoGenerateColumns = false;
        }

        public void preencheGrid()
        {
            dgvCampos.DataSource = null;
            dgvCampos.DataSource = campoPesquisas;
            
        }
    }
}
