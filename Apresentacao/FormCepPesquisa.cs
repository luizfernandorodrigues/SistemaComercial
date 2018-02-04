using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio.Entidades;
using Repositorio.Dao.Repositorios;

namespace Apresentacao
{
    public partial class FormCepPesquisa : Form
    {
        public FormCepPesquisa()
        {
            InitializeComponent();
        }

        private void FormCepPesquisa_Load(object sender, EventArgs e)
        {
            PreencheComboBox preencheComboBox = new PreencheComboBox();
            preencheComboBox.combo(comboBoxCep);
            preencheComboBox.combo(comboBoxCidade);
            dataGridViewCep.AutoGenerateColumns = false;
            toolTipPesquisaCep.SetToolTip(buttonCarregaSelecionado, Util.BOTAO_CARREGA_SELECIONADO);
            toolTipPesquisaCep.SetToolTip(buttonDesmarcaTudo, Util.BOTAO_DESMARCA_TUDO);
            toolTipPesquisaCep.SetToolTip(buttonExcel, Util.BOTAO_EXPORTAR_EXCEL);
            toolTipPesquisaCep.SetToolTip(buttonMarcarTudo, Util.BOTAO_SELECIONA_TUDO);
        }

        private void comboBoxCep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxCep.SelectedValue.Equals("3"))
            {
                textBoxCepEntre.Visible = true;
            }
            else
            {
                textBoxCepEntre.Visible = false;
            }
        }

        private void comboBoxCidade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxCidade.SelectedValue.Equals("3"))
            {
                textBoxCidadeEntre.Visible = true;
            }
            else
            {
                textBoxCidadeEntre.Visible = false;
            }
        }

        private void buttonPesquisaCep_Click(object sender, EventArgs e)
        {
            preencheGrid();
        }

        private void preencheGrid()
        {
            List<Cep> cep = new List<Cep>();
            CepRepositorio cepRepositorio = new CepRepositorio();
            cep = cepRepositorio.buscaCep(textBoxCep.Text);
            dataGridViewCep.DataSource = cep;
            
        }
    }
}
