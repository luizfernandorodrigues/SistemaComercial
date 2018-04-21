using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using MetroFramework;

namespace Apresentacao
{
    public partial class FormPaisCadastro : Apresentacao.FormBase
    {
        Pais pais = new Pais();

        public FormPaisCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.salvar();
            try
            {
                if (pais.Codigo.Length > 4 || pais.Codigo.Length < 4)
                {
                    MetroMessageBox.Show(this, "Campo Código deve ter 4 digitos!","Notification", 100);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormPaisCadastro_Load(object sender, EventArgs e)
        {

        }

        private void salvar()
        {
            pais.Codigo = txtCodigo.Text.Trim();
            pais.Nome = txtNome.Text;
        }
    }
}
