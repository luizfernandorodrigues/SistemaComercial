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
    public partial class FormEstadoCadastro : Apresentacao.FormBase
    {
        private int flag = 1;
        public static Guid pais_ukey;

        Estado estado = new Estado();
        EstadoDados estadoDados = new EstadoDados();

        public FormEstadoCadastro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento do Botão Novo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtDescricao.Enabled = false;
        }

        /// <summary>
        /// Evento do Botão de pesquisa pais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisaPais_Click(object sender, EventArgs e)
        {
            FormPaisPesquisa frm = new FormPaisPesquisa(null, this);
            frm.Show();
        }

        /// <summary>
        /// Evento do Botão Salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                valida();
                gravar();
                try
                {
                    estadoDados.insert(estado);
                    Util.botaoSalvar(this);
                    Util_Msg.aviso(Util.MENSAGEM_SUCESSO);
                }
                catch (Exception ex)
                {
                    Util_Msg.erro(Util.MENSAGEM_ERRO + ex.Message);
                    throw;
                }
                
            } else if (flag == 2)
            {

            }
        }

        /// <summary>
        /// Método para preencher o objeto estado
        /// </summary>
        private void gravar()
        {
            estado.Pais_ukey = pais_ukey;
            estado.Ukey = Guid.NewGuid();
            estado.SiglaEstado = txtSigla.Text.Trim();
            estado.DescricaoEstado = txtNome.Text.Trim();
        }

        /// <summary>
        /// Método para validar os campos do form
        /// </summary>
        private void valida()
        {
            //verifica nome
            if (txtNome.Text.Trim().Equals(""))
            {
                Util_Msg.atencao("Informe o Nome do Estado!");
                return;
            }
            //verifica sigla
            if (txtSigla.Text.Trim().Equals(""))
            {
                Util_Msg.atencao("Informe uma Sigla!");
                return;
            }
            //verifica pais
            if (pais_ukey == Guid.Empty)
            {
                Util_Msg.atencao("Selecione um Pais!");
                return;
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            FormEstadoPesquisa frm = new FormEstadoPesquisa();
            frm.Show();
        }

        private void FormEstadoCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
