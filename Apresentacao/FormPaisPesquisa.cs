using System;
using System.Collections;
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
    public partial class FormPaisPesquisa : Form
    {
        PreencheComboBox combo = new PreencheComboBox();
        public FormPaisPesquisa()
        {
            InitializeComponent();
           
        }

        private void FormPaisPesquisa_Load(object sender, EventArgs e)
        {
            combo.combo(cbxCodigo);
            combo.combo(cbxNome);
        }
    }
}
