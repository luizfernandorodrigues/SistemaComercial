using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Repositorio.Entidades;
using Repositorio.Dao.Repositorios;
using Utilitarios;

namespace Apresentacao
{
    public partial class FormCadastroPais : Apresentacao.FormBase
    {
        private int flag = 1;

        public FormCadastroPais()
        {
            InitializeComponent();
        }
        /// <summary>
        /// funçao do botão salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                //inserir
                try
                {
                    if (this.salvar())
                    {
                        Util_Msg.aviso(Util.MENSAGEM_SUCESSO);
                        Util.desabilitaCamposNovo(this);
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Util_Msg.erro(Util.MENSAGEM_ERRO + ex.Message);
                    return;
                }
            }
            //*** final inserir***
            else
            {
                //alterar
                try
                {

                }
                catch (Exception ex)
                {

                }
            }
        }
        /// <summary>
        /// Função responsavel por instancia o objeto pais e setar as propriedades 
        /// com os valores digitados no form, 
        /// </summary>
        private Boolean salvar()
        {
            Pais pais = new Pais();
            PaisRepositorio paisRepositorio = new PaisRepositorio();
            pais.Ukey = Guid.NewGuid();
            pais.Codigo = txtCodigo.Text;
            pais.Nome = txtNome.Text;
            //aqui passo o objeto para ser validado conforme suas caracteristicas definidas na entidade
            int quantidadeErros = Validacao.ValidarEntidade(pais);
            //chamo o repositorio e passo o objeto para ser inserido no banco de dados
            if (quantidadeErros == 0)
            {
                paisRepositorio.inserir(pais);
                return true;
            }
            else
            {
                return false;
            }

        }

        private void FormCadastroPais_Load(object sender, EventArgs e)
        {

        }
    }
}
