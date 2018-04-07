using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Apresentacao
{
    public partial class FormPrincipal : MetroForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Função do botao pais para abrir o form de cadastro de paises
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroPais frm = new FormCadastroPais();
            frm.Show();
        }
    }
}
