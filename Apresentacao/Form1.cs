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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CEPAbertoResponse cep;
           cep = CepAberto.GetCepInfo(textBox1.Text);
            string saida = "Cidade: " + cep.cidade + "\n";
            saida += "CEP: " + cep.cep + "\n";
            saida += "Estado: " + cep.estado + "\n";
            saida += "Rua: " + cep.logradouro + "\n";
            label1.Text = saida;

        }
    }
}
