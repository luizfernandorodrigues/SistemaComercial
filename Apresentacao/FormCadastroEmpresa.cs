﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FormCadastroEmpresa : Apresentacao.FormBase
    {
        public FormCadastroEmpresa()
        {
            InitializeComponent();
        }

        private void buttonBuscaCep_Click(object sender, EventArgs e)
        {
            FormCepPesquisa frm = new FormCepPesquisa();
            frm.Show();
        }

        private void FormCadastroEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
