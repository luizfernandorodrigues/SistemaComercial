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

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPaisCadastro frm = new FormPaisCadastro();
            frm.Show();
        }
    }
}
