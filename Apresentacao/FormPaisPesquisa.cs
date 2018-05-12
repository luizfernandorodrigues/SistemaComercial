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

namespace Apresentacao
{
    public partial class FormPaisPesquisa : Form
    {
        PreencheComboBox combo = new PreencheComboBox();
        public FormPaisPesquisa()
        {
            InitializeComponent();

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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            PaisDados paisDados = new PaisDados();
            PaisCollection pais = new PaisCollection();
            pais = paisDados.pesquisa(txtNome.Text, txtCodigo.Text, cbxNome.SelectedValue.ToString(), cbxCodigo.SelectedValue.ToString(), txtNomeEntre.Text, txtCodigoEntre.Text);
            var lista = pais.OrderBy(p => p.Nome).ToList();
            dgvPais.DataSource = lista;
        }
    }
}
