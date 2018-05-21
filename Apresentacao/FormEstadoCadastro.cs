using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FormEstadoCadastro : Apresentacao.FormBase
    {
        private int flag = 1;
        Guid pais_ukey;

        public FormEstadoCadastro()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtDescricao.Enabled = false;
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals("?"))
            {
                FormPaisPesquisa frm = new FormPaisPesquisa(null, this);
            }
        }
    }
}
