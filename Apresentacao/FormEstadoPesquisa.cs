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
    public partial class FormEstadoPesquisa : Form
    {
        PreencheComboBox combo = new PreencheComboBox();
        public FormEstadoPesquisa()
        {
            InitializeComponent();
        }

        private void FormEstadoPesquisa_Load(object sender, EventArgs e)
        {
            dgvEstado.AutoGenerateColumns = false;
            combo.combo(cbxSigla);
            combo.combo(cbxNome);
            combo.combo(cbxNomePais);

            //setar tool tip nos botoes 
            toolTipPesquisaEstado.SetToolTip(btnCarregaFiltrado, Util.BOTAO_CARREGA_SELECIONADO);
            toolTipPesquisaEstado.SetToolTip(btnInverteSelecao, Util.BOTAO_INVERTE_SELECAO);
            toolTipPesquisaEstado.SetToolTip(btnExportaExcel, Util.BOTAO_EXPORTAR_EXCEL);
            toolTipPesquisaEstado.SetToolTip(btnDesmarcaTudo, Util.BOTAO_DESMARCA_TUDO);
            toolTipPesquisaEstado.SetToolTip(btnMarcaTudo, Util.BOTAO_SELECIONA_TUDO);
        }
    }
}
