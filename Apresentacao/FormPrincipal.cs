﻿using System;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroEmpresa frm = new FormCadastroEmpresa();
            frm.Show();
        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroPais frm = new FormCadastroPais();
            frm.Show();
        }
    }
}
