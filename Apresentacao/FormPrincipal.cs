using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarios;

namespace Apresentacao
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPaisCadastro frm = new FormPaisCadastro();
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resposta = Util_Msg.simNao("Deseja Realmente Sair do Sistema?");
            if (resposta == DialogResult.Yes)
            {
                Dispose();
            }
            return;
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstadoCadastro frm = new FormEstadoCadastro();
            frm.Show();
        }

        private void cadastroDePesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroPesquisa frm = new FormCadastroPesquisa();
            frm.Show();
        }
    }
}
