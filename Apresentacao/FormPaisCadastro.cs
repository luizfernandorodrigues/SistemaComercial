using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Utilitarios;
using AcessaDados;


namespace Apresentacao
{
    public partial class FormPaisCadastro : Apresentacao.FormBase
    {
        Pais pais = new Pais();
        PaisDados paisDados = new PaisDados();
        int flag = 1;
        public static PaisCollection paisCollection;

        public FormPaisCadastro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento do botão salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //se for inserir
            if (flag == 1)
            {
                salvar();
                if (valida())
                {
                    try
                    {
                        paisDados.insert(pais);
                        Util_Msg.aviso(Util.MENSAGEM_SUCESSO);
                        Util.botaoSalvar(this);
                    }
                    catch (Exception ex)
                    {
                        Util_Msg.erro(Util.MENSAGEM_ERRO + ex.Message);
                        Util_Log.log(ex.Message);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            //se for anterar
            else if (flag == 2)
            {
                alterar();
                if (valida())
                {
                    try
                    {
                        paisDados.update(pais);
                        Util_Msg.aviso(Util.MENSAGEM_SUCESSO);
                        Util.botaoSalvar(this);
                    }
                    catch (Exception ex)
                    {
                        Util_Msg.erro(Util.MENSAGEM_ERRO + ex.Message);
                        Util_Log.log(ex.Message);
                        return;
                    }
                }
                else
                {
                    return;
                }

            }
        }

        /// <summary>
        /// Metodo de salvar, preenche o objeto pais
        /// </summary>
        private void salvar()
        {
            pais.Ukey = Guid.NewGuid();
            pais.Nome = txtNome.Text;
            pais.Codigo = txtCodigo.Text.Trim();
        }

        /// <summary>
        /// Método para fazer a validação dos campos obrigatório da tela
        /// </summary>
        private bool valida()
        {
            //valida se o nome preenchido
            if (string.IsNullOrEmpty(pais.Nome))
            {
                Util_Msg.atencao("Preencha o Campo Nome");
                txtNome.Focus();
                return false;
            }
            //valida se o código foi preenchido
            if (string.IsNullOrEmpty(pais.Codigo))
            {
                Util_Msg.atencao("Preencha o Campo Código");
                txtCodigo.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Evento do botão novo da tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            flag = 1;
        }

        /// <summary>
        /// Evento do botão pesquisa, abre o formPais de pesquisa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            FormPaisPesquisa frm = new FormPaisPesquisa(this, null);
            frm.Show();
            txtNome.DataBindings.Clear();
            txtCodigo.DataBindings.Clear();
        }

        /// <summary>
        /// Metodo do botão próximo para percorrer os registros retornado da pesquisa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProximo_Click(object sender, EventArgs e)
        {
            //verifico se a posição do binding é igual o total de registro
            if (bindingSourcePais.Position == bindingSourcePais.Count - 1)
            {
                Util_Msg.aviso("Ultimo Registro!");
                return;
            }
            //passo para o próximo registro
            try
            {
                bindingSourcePais.MoveNext();
            }
            catch (Exception ex)
            {
                Util_Msg.erro("Ocorreu um Erro: " + ex.Message);
            }
        }

        /// <summary>
        /// Evento do botão registro anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //verifico se a posição do binding é igual o total de registro
            if (bindingSourcePais.Position == 0)
            {
                Util_Msg.aviso("Primeiro Registro!");
                return;
            }
            //passo para o registro anterior
            try
            {
                bindingSourcePais.MovePrevious();
            }
            catch (Exception ex)
            {
                Util_Msg.erro("Ocorreu um Erro: " + ex.Message);
            }
        }

        /// <summary>
        /// Evento do botão ultimo registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUltimoRegistro_Click(object sender, EventArgs e)
        {
            //verifico se a posição do binding é igual o total de registro
            if (bindingSourcePais.Position == bindingSourcePais.Count - 1)
            {
                Util_Msg.aviso("Ultimo Registro!");
                return;
            }
            //passo para o ultimo registro
            try
            {
                bindingSourcePais.MoveLast();
            }
            catch (Exception ex)
            {
                Util_Msg.erro("Ocorreu um Erro: " + ex.Message);
            }
        }

        /// <summary>
        /// Evento do botão primeiro registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrimeiroRegistro_Click(object sender, EventArgs e)
        {
            //verifico se a posição do binding é igual a primeira
            if (bindingSourcePais.Position == 0)
            {
                Util_Msg.aviso("Primeiro Registro!");
                return;
            }
            //passo para o próximo registro
            try
            {
                bindingSourcePais.MoveFirst();
            }
            catch (Exception ex)
            {
                Util_Msg.erro("Ocorreu um Erro: " + ex.Message);
            }
        }

        /// <summary>
        /// Evento do botão editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (bindingSourcePais.Count == 0)
            {
                Util_Msg.atencao("Não há Registro Para Alterar!");
                return;
            }
            editar();
        }

        /// <summary>
        /// Método do botão editar, habilita os campos para serem editados e seta a flag para 2
        /// </summary>
        private void editar()
        {
            flag = 2;
            Util.botaoEdita(this);
        }

        /// <summary>
        /// Método de preencher o objeto pra alterar
        /// </summary>
        private void alterar()
        {
            pais = bindingSourcePais.Current as Pais;
            pais.Nome = txtNome.Text.Trim();
            pais.Codigo = txtCodigo.Text.Trim();
        }

        /// <summary>
        /// Evernto do botão excluir do formPais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (bindingSourcePais.Count == 0)
            {
                Util_Msg.atencao("Não há Registro Para Excluir!");
                return;
            }
            pais = bindingSourcePais.Current as Pais;
            try
            {
                paisDados.delete(pais);
                Util_Msg.aviso("Registro Excluido com Sucesso!");
                Util.botaoExcluir(this);

                //removo o item atual da lista
                bindingSourcePais.RemoveCurrent();
                //passo para o proximo registro do bind caso exista 
                if (bindingSourcePais.Count > 1)
                {
                    bindingSourcePais.MoveNext();
                }
            }
            catch (Exception ex)
            {
                Util_Msg.erro("Não Foi Possivel Excluir o Registro! \n" + ex.Message);
                Util_Log.log(ex.Message);
            }
        }

        /// <summary>
        /// evento do botão desfazer do formPais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                Util.desfazerEstadoNovo(this);
            }

        }

        private void FormPaisCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
