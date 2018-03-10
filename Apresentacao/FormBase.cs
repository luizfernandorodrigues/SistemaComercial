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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Função do botao de sair, fecha o form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            Util.habilitaBotoesNovo(this);
            Util.habilitaCamposNovos(this);
            buttonSair.Enabled = true;
        }

        private void FormBase_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
