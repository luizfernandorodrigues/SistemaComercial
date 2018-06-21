using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using AcessaDados;
using Utilitarios;

namespace Apresentacao
{
    public partial class FormPesquisa : Form
    {
        private string form;
        CampoPesquisa campoPesquisa = new CampoPesquisa();

        public FormPesquisa(string nomeForm)
        {
            InitializeComponent();
            form = nomeForm;
        }

        private void FormPesquisa_Load(object sender, EventArgs e)
        {
            //coloca a grid para não gerar colunas automatico
            dgvPesquisas.AutoGenerateColumns = false;
            CarregaPesquisa carregaPesquisa = new CarregaPesquisa(form);
            bsPesquisa.DataSource = carregaPesquisa.pesquisas();
            if (bsPesquisa.Count == 0)
            {
                Util_Msg.atencao("Nenhuma Pesquisa Configurada!");
                Dispose();
            }
            dgvPesquisas.DataSource = bsPesquisa;
        }

        private void montaFiltros()
        {
            dgvFiltrosPesquisa.Columns.Clear();
            int posiçãoSelecionada = dgvPesquisas.CurrentRow.Index;
            campoPesquisa = dgvPesquisas.Rows[posiçãoSelecionada].DataBoundItem as CampoPesquisa;
        }
    }
}
