using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessaDados;
using Modelo;
using Utilitarios;

namespace Apresentacao
{
    public partial class FormPaisPesquisa : Form
    {
        PreencheComboBox combo = new PreencheComboBox();
        FormPaisCadastro form;
        public FormPaisPesquisa(FormPaisCadastro frm)
        {
            InitializeComponent();
            form = frm;
        }

        private void FormPaisPesquisa_Load(object sender, EventArgs e)
        {
            dgvPais.AutoGenerateColumns = false;
            combo.combo(cbxCodigo);
            combo.combo(cbxNome);

            //setar tool tip nos botoes 
            toolTipPesquisaPais.SetToolTip(btnCarregaFiltrado, Util.BOTAO_CARREGA_SELECIONADO);
            toolTipPesquisaPais.SetToolTip(btnInverteSelecao, Util.BOTAO_INVERTE_SELECAO);
            toolTipPesquisaPais.SetToolTip(btnExportaExcel, Util.BOTAO_EXPORTAR_EXCEL);
            toolTipPesquisaPais.SetToolTip(btnDesmarcaTudo, Util.BOTAO_DESMARCA_TUDO);
            toolTipPesquisaPais.SetToolTip(btnMarcaTudo, Util.BOTAO_SELECIONA_TUDO);
        }
        /// <summary>
        /// Evento para mostrar camop de valor entre do nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxNome_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxNome.SelectedIndex == 2)
            {
                txtNomeEntre.Visible = true;
            }
            else
            {
                txtNomeEntre.Visible = false;
            }
        }
        /// <summary>
        /// evento do clique do mouse pesquisa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                PaisDados paisDados = new PaisDados();
                PaisCollection pais = new PaisCollection();
                pais = paisDados.pesquisa(txtNome.Text, txtCodigo.Text, cbxNome.SelectedValue.ToString(), cbxCodigo.SelectedValue.ToString(), txtNomeEntre.Text, txtCodigoEntre.Text);
                var lista = pais.OrderBy(p => p.Nome).ToList();
                if (lista.Count == 0)
                {
                    Util_Msg.atencao("Nenhum Regitro Encontrado!");
                    return;
                }
                else
                {
                    dgvPais.DataSource = lista;
                }

            }
            catch (Exception ex)
            {
                Util_Msg.erro(Util.MENSAGEM_ERRO + ex.Message);
                return;
            }

        }

        private PaisCollection carregaFiltrado()
        {
            PaisCollection paisCollection = new PaisCollection();
            Pais pais = new Pais();

            for (int i = 0; i < dgvPais.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvPais.Rows[i].Cells[0].Value))
                {
                    pais = dgvPais.Rows[i].DataBoundItem as Pais;
                    paisCollection.Add(pais);
                }

            }
            return paisCollection;
        }
        //evento do botão carregar filtrados
        private void btnCarregaFiltrado_Click(object sender, EventArgs e)
        {
            PaisCollection p = new PaisCollection();
            p = carregaFiltrado();
            
            if(p.Count == 0)
            {
                Util_Msg.atencao("Nenhum Registro Selecionado!");
                return;
            } else
            {
                FormPaisCadastro.paisCollection = p;
                form.bindingSourcePais.DataSource = p;
                form.txtCodigo.DataBindings.Add("Text",form.bindingSourcePais,"codigo");
                form.txtNome.DataBindings.Add("Text", form.bindingSourcePais, "nome");
                form.btnAnterior.Enabled = true;
                form.btnEditar.Enabled = true;
                form.btnExcluir.Enabled = true;
                form.btnPrimeiroRegistro.Enabled = true;
                form.btnProximo.Enabled = true;
                form.btnUltimoRegistro.Enabled = true;
                this.Dispose();
            }
        }
    }
}
