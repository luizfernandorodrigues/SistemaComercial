namespace Apresentacao
{
    partial class FormCadastroEmpresa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCampos = new System.Windows.Forms.Panel();
            this.buttonBuscaCep = new System.Windows.Forms.Button();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxFantasia = new System.Windows.Forms.TextBox();
            this.labelFone = new System.Windows.Forms.Label();
            this.labelCelular = new System.Windows.Forms.Label();
            this.labelCnpj = new System.Windows.Forms.Label();
            this.labelFax = new System.Windows.Forms.Label();
            this.labelInscricao = new System.Windows.Forms.Label();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.textBoxlogradouro = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFax = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxInscricao = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCep = new System.Windows.Forms.TextBox();
            this.labelCep = new System.Windows.Forms.Label();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.labelPais = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBoxPesquisaCep = new System.Windows.Forms.TextBox();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.textBoxRazao = new System.Windows.Forms.TextBox();
            this.labelFantasia = new System.Windows.Forms.Label();
            this.labelRazao = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.panelCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCampos.Controls.Add(this.buttonBuscaCep);
            this.panelCampos.Controls.Add(this.textBoxemail);
            this.panelCampos.Controls.Add(this.labelEmail);
            this.panelCampos.Controls.Add(this.textBoxComplemento);
            this.panelCampos.Controls.Add(this.labelComplemento);
            this.panelCampos.Controls.Add(this.textBoxBairro);
            this.panelCampos.Controls.Add(this.labelBairro);
            this.panelCampos.Controls.Add(this.textBoxNumero);
            this.panelCampos.Controls.Add(this.labelNumero);
            this.panelCampos.Controls.Add(this.textBoxFantasia);
            this.panelCampos.Controls.Add(this.labelFone);
            this.panelCampos.Controls.Add(this.labelCelular);
            this.panelCampos.Controls.Add(this.labelCnpj);
            this.panelCampos.Controls.Add(this.labelFax);
            this.panelCampos.Controls.Add(this.labelInscricao);
            this.panelCampos.Controls.Add(this.labelLogradouro);
            this.panelCampos.Controls.Add(this.textBoxlogradouro);
            this.panelCampos.Controls.Add(this.maskedTextBoxCnpj);
            this.panelCampos.Controls.Add(this.maskedTextBoxCelular);
            this.panelCampos.Controls.Add(this.maskedTextBoxFone);
            this.panelCampos.Controls.Add(this.maskedTextBoxFax);
            this.panelCampos.Controls.Add(this.maskedTextBoxInscricao);
            this.panelCampos.Controls.Add(this.textBoxCep);
            this.panelCampos.Controls.Add(this.labelCep);
            this.panelCampos.Controls.Add(this.textBoxPais);
            this.panelCampos.Controls.Add(this.labelPais);
            this.panelCampos.Controls.Add(this.textBoxEstado);
            this.panelCampos.Controls.Add(this.labelEstado);
            this.panelCampos.Controls.Add(this.textBoxCidade);
            this.panelCampos.Controls.Add(this.labelCidade);
            this.panelCampos.Controls.Add(this.textBoxPesquisaCep);
            this.panelCampos.Controls.Add(this.labelPesquisa);
            this.panelCampos.Controls.Add(this.textBoxRazao);
            this.panelCampos.Controls.Add(this.labelFantasia);
            this.panelCampos.Controls.Add(this.labelRazao);
            this.panelCampos.Controls.Add(this.textBoxCodigo);
            this.panelCampos.Controls.Add(this.labelCodigo);
            this.panelCampos.Location = new System.Drawing.Point(2, 97);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(570, 297);
            this.panelCampos.TabIndex = 3;
            // 
            // buttonBuscaCep
            // 
            this.buttonBuscaCep.Enabled = false;
            this.buttonBuscaCep.Image = global::Apresentacao.Properties.Resources.Search_15px_1;
            this.buttonBuscaCep.Location = new System.Drawing.Point(538, 58);
            this.buttonBuscaCep.Name = "buttonBuscaCep";
            this.buttonBuscaCep.Size = new System.Drawing.Size(25, 22);
            this.buttonBuscaCep.TabIndex = 35;
            this.buttonBuscaCep.UseVisualStyleBackColor = true;
            this.buttonBuscaCep.Click += new System.EventHandler(this.buttonBuscaCep_Click);
            // 
            // textBoxemail
            // 
            this.textBoxemail.Enabled = false;
            this.textBoxemail.Location = new System.Drawing.Point(321, 255);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(242, 20);
            this.textBoxemail.TabIndex = 34;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(283, 259);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 33;
            this.labelEmail.Text = "E-mail:";
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Enabled = false;
            this.textBoxComplemento.Location = new System.Drawing.Point(357, 171);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(206, 20);
            this.textBoxComplemento.TabIndex = 32;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(283, 175);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(74, 13);
            this.labelComplemento.TabIndex = 31;
            this.labelComplemento.Text = "Complemento:";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Enabled = false;
            this.textBoxBairro.Location = new System.Drawing.Point(65, 171);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(218, 20);
            this.textBoxBairro.TabIndex = 30;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(28, 175);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(37, 13);
            this.labelBairro.TabIndex = 29;
            this.labelBairro.Text = "Bairro:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Enabled = false;
            this.textBoxNumero.Location = new System.Drawing.Point(445, 143);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(118, 20);
            this.textBoxNumero.TabIndex = 28;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(398, 147);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(47, 13);
            this.labelNumero.TabIndex = 27;
            this.labelNumero.Text = "Número:";
            // 
            // textBoxFantasia
            // 
            this.textBoxFantasia.Enabled = false;
            this.textBoxFantasia.Location = new System.Drawing.Point(219, 4);
            this.textBoxFantasia.Name = "textBoxFantasia";
            this.textBoxFantasia.Size = new System.Drawing.Size(344, 20);
            this.textBoxFantasia.TabIndex = 26;
            // 
            // labelFone
            // 
            this.labelFone.AutoSize = true;
            this.labelFone.Location = new System.Drawing.Point(31, 231);
            this.labelFone.Name = "labelFone";
            this.labelFone.Size = new System.Drawing.Size(34, 13);
            this.labelFone.TabIndex = 25;
            this.labelFone.Text = "Fone:";
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Location = new System.Drawing.Point(314, 231);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(42, 13);
            this.labelCelular.TabIndex = 24;
            this.labelCelular.Text = "Celular:";
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Location = new System.Drawing.Point(34, 203);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(31, 13);
            this.labelCnpj.TabIndex = 23;
            this.labelCnpj.Text = "Cnpj:";
            // 
            // labelFax
            // 
            this.labelFax.AutoSize = true;
            this.labelFax.Location = new System.Drawing.Point(38, 259);
            this.labelFax.Name = "labelFax";
            this.labelFax.Size = new System.Drawing.Size(27, 13);
            this.labelFax.TabIndex = 22;
            this.labelFax.Text = "Fax:";
            // 
            // labelInscricao
            // 
            this.labelInscricao.AutoSize = true;
            this.labelInscricao.Location = new System.Drawing.Point(304, 203);
            this.labelInscricao.Name = "labelInscricao";
            this.labelInscricao.Size = new System.Drawing.Size(53, 13);
            this.labelInscricao.TabIndex = 21;
            this.labelInscricao.Text = "Inscrição:";
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(1, 147);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(64, 13);
            this.labelLogradouro.TabIndex = 20;
            this.labelLogradouro.Text = "Logradouro:";
            // 
            // textBoxlogradouro
            // 
            this.textBoxlogradouro.Enabled = false;
            this.textBoxlogradouro.Location = new System.Drawing.Point(65, 143);
            this.textBoxlogradouro.Name = "textBoxlogradouro";
            this.textBoxlogradouro.Size = new System.Drawing.Size(333, 20);
            this.textBoxlogradouro.TabIndex = 19;
            // 
            // maskedTextBoxCnpj
            // 
            this.maskedTextBoxCnpj.Enabled = false;
            this.maskedTextBoxCnpj.Location = new System.Drawing.Point(65, 199);
            this.maskedTextBoxCnpj.Mask = "00.000.000/0000-00";
            this.maskedTextBoxCnpj.Name = "maskedTextBoxCnpj";
            this.maskedTextBoxCnpj.Size = new System.Drawing.Size(218, 20);
            this.maskedTextBoxCnpj.TabIndex = 18;
            // 
            // maskedTextBoxCelular
            // 
            this.maskedTextBoxCelular.Enabled = false;
            this.maskedTextBoxCelular.Location = new System.Drawing.Point(357, 227);
            this.maskedTextBoxCelular.Mask = "(##) #####-####";
            this.maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            this.maskedTextBoxCelular.Size = new System.Drawing.Size(206, 20);
            this.maskedTextBoxCelular.TabIndex = 17;
            // 
            // maskedTextBoxFone
            // 
            this.maskedTextBoxFone.Enabled = false;
            this.maskedTextBoxFone.Location = new System.Drawing.Point(65, 227);
            this.maskedTextBoxFone.Mask = "(##) ####-####";
            this.maskedTextBoxFone.Name = "maskedTextBoxFone";
            this.maskedTextBoxFone.Size = new System.Drawing.Size(218, 20);
            this.maskedTextBoxFone.TabIndex = 16;
            // 
            // maskedTextBoxFax
            // 
            this.maskedTextBoxFax.Enabled = false;
            this.maskedTextBoxFax.Location = new System.Drawing.Point(65, 255);
            this.maskedTextBoxFax.Mask = "(##) ####-####";
            this.maskedTextBoxFax.Name = "maskedTextBoxFax";
            this.maskedTextBoxFax.Size = new System.Drawing.Size(218, 20);
            this.maskedTextBoxFax.TabIndex = 15;
            // 
            // maskedTextBoxInscricao
            // 
            this.maskedTextBoxInscricao.Enabled = false;
            this.maskedTextBoxInscricao.Location = new System.Drawing.Point(357, 199);
            this.maskedTextBoxInscricao.Mask = "00000000-00";
            this.maskedTextBoxInscricao.Name = "maskedTextBoxInscricao";
            this.maskedTextBoxInscricao.Size = new System.Drawing.Size(206, 20);
            this.maskedTextBoxInscricao.TabIndex = 14;
            // 
            // textBoxCep
            // 
            this.textBoxCep.Enabled = false;
            this.textBoxCep.Location = new System.Drawing.Point(326, 116);
            this.textBoxCep.Name = "textBoxCep";
            this.textBoxCep.Size = new System.Drawing.Size(237, 20);
            this.textBoxCep.TabIndex = 13;
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(295, 119);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(31, 13);
            this.labelCep.TabIndex = 12;
            this.labelCep.Text = "CEP:";
            // 
            // textBoxPais
            // 
            this.textBoxPais.Enabled = false;
            this.textBoxPais.Location = new System.Drawing.Point(65, 115);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(218, 20);
            this.textBoxPais.TabIndex = 11;
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(33, 119);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(32, 13);
            this.labelPais.TabIndex = 10;
            this.labelPais.Text = "País:";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Enabled = false;
            this.textBoxEstado.Location = new System.Drawing.Point(326, 88);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(237, 20);
            this.textBoxEstado.TabIndex = 9;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(283, 91);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(43, 13);
            this.labelEstado.TabIndex = 8;
            this.labelEstado.Text = "Estado:";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Enabled = false;
            this.textBoxCidade.Location = new System.Drawing.Point(65, 87);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(218, 20);
            this.textBoxCidade.TabIndex = 7;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(22, 91);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(43, 13);
            this.labelCidade.TabIndex = 6;
            this.labelCidade.Text = "Cidade:";
            // 
            // textBoxPesquisaCep
            // 
            this.textBoxPesquisaCep.Enabled = false;
            this.textBoxPesquisaCep.Location = new System.Drawing.Point(65, 59);
            this.textBoxPesquisaCep.Name = "textBoxPesquisaCep";
            this.textBoxPesquisaCep.Size = new System.Drawing.Size(467, 20);
            this.textBoxPesquisaCep.TabIndex = 5;
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Location = new System.Drawing.Point(12, 63);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(53, 13);
            this.labelPesquisa.TabIndex = 4;
            this.labelPesquisa.Text = "Pesquisa:";
            // 
            // textBoxRazao
            // 
            this.textBoxRazao.Enabled = false;
            this.textBoxRazao.Location = new System.Drawing.Point(65, 31);
            this.textBoxRazao.Name = "textBoxRazao";
            this.textBoxRazao.Size = new System.Drawing.Size(498, 20);
            this.textBoxRazao.TabIndex = 3;
            // 
            // labelFantasia
            // 
            this.labelFantasia.AutoSize = true;
            this.labelFantasia.Location = new System.Drawing.Point(169, 7);
            this.labelFantasia.Name = "labelFantasia";
            this.labelFantasia.Size = new System.Drawing.Size(50, 13);
            this.labelFantasia.TabIndex = 2;
            this.labelFantasia.Text = "Fantasia:";
            // 
            // labelRazao
            // 
            this.labelRazao.AutoSize = true;
            this.labelRazao.Location = new System.Drawing.Point(24, 35);
            this.labelRazao.Name = "labelRazao";
            this.labelRazao.Size = new System.Drawing.Size(41, 13);
            this.labelRazao.TabIndex = 2;
            this.labelRazao.Text = "Razão:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(65, 3);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(104, 20);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(22, 7);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Código:";
            // 
            // FormCadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(578, 406);
            this.Controls.Add(this.panelCampos);
            this.Name = "FormCadastroEmpresa";
            this.Text = "Cadastro de Empresa";
            this.Load += new System.EventHandler(this.FormCadastroEmpresa_Load);
            this.Controls.SetChildIndex(this.panelCampos, 0);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.TextBox textBoxFantasia;
        private System.Windows.Forms.Label labelFone;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.Label labelCnpj;
        private System.Windows.Forms.Label labelFax;
        private System.Windows.Forms.Label labelInscricao;
        private System.Windows.Forms.Label labelLogradouro;
        private System.Windows.Forms.TextBox textBoxlogradouro;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCnpj;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelular;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFax;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInscricao;
        private System.Windows.Forms.TextBox textBoxCep;
        private System.Windows.Forms.Label labelCep;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox textBoxPesquisaCep;
        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.TextBox textBoxRazao;
        private System.Windows.Forms.Label labelFantasia;
        private System.Windows.Forms.Label labelRazao;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonBuscaCep;
    }
}
