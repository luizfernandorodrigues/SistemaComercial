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
    }
}
