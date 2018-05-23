namespace Apresentacao
{
    partial class FormEstadoCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnAbreRegistro = new System.Windows.Forms.Button();
            this.btnPesquisaPais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 100);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(53, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(536, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtSigla
            // 
            this.txtSigla.Enabled = false;
            this.txtSigla.Location = new System.Drawing.Point(53, 117);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(45, 20);
            this.txtSigla.TabIndex = 5;
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(14, 121);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(33, 13);
            this.lblSigla.TabIndex = 6;
            this.lblSigla.Text = "Sigla:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(98, 121);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 8;
            this.lblPais.Text = "Pais:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(128, 117);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(263, 117);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(293, 20);
            this.txtDescricao.TabIndex = 9;
            // 
            // btnAbreRegistro
            // 
            this.btnAbreRegistro.Image = global::Apresentacao.Properties.Resources.Circled_Chevron_Right_15px;
            this.btnAbreRegistro.Location = new System.Drawing.Point(229, 117);
            this.btnAbreRegistro.Name = "btnAbreRegistro";
            this.btnAbreRegistro.Size = new System.Drawing.Size(33, 21);
            this.btnAbreRegistro.TabIndex = 10;
            this.btnAbreRegistro.UseVisualStyleBackColor = true;
            // 
            // btnPesquisaPais
            // 
            this.btnPesquisaPais.Image = global::Apresentacao.Properties.Resources.Search_15px_1;
            this.btnPesquisaPais.Location = new System.Drawing.Point(557, 117);
            this.btnPesquisaPais.Name = "btnPesquisaPais";
            this.btnPesquisaPais.Size = new System.Drawing.Size(33, 21);
            this.btnPesquisaPais.TabIndex = 11;
            this.btnPesquisaPais.UseVisualStyleBackColor = true;
            this.btnPesquisaPais.Click += new System.EventHandler(this.btnPesquisaPais_Click);
            // 
            // FormEstadoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(593, 153);
            this.Controls.Add(this.btnPesquisaPais);
            this.Controls.Add(this.btnAbreRegistro);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FormEstadoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Estado";
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.Controls.SetChildIndex(this.lblSigla, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.btnAbreRegistro, 0);
            this.Controls.SetChildIndex(this.btnPesquisaPais, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnAbreRegistro;
        private System.Windows.Forms.Button btnPesquisaPais;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtDescricao;
    }
}
