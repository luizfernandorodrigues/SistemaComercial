namespace Apresentacao
{
    partial class FormCampoPesquisaCadastro
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
            this.lblTabela = new System.Windows.Forms.Label();
            this.txtTabela = new System.Windows.Forms.TextBox();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbxOperador = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(24, 98);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(43, 13);
            this.lblTabela.TabIndex = 3;
            this.lblTabela.Text = "Tabela:";
            // 
            // txtTabela
            // 
            this.txtTabela.Enabled = false;
            this.txtTabela.Location = new System.Drawing.Point(67, 95);
            this.txtTabela.Name = "txtTabela";
            this.txtTabela.Size = new System.Drawing.Size(219, 20);
            this.txtTabela.TabIndex = 4;
            // 
            // txtCampo
            // 
            this.txtCampo.Enabled = false;
            this.txtCampo.Location = new System.Drawing.Point(67, 123);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(219, 20);
            this.txtCampo.TabIndex = 6;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(24, 127);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 5;
            this.lblCampo.Text = "Campo:";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(13, 183);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(54, 13);
            this.lblOperador.TabIndex = 7;
            this.lblOperador.Text = "Operador:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(36, 212);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo:";
            // 
            // cbxOperador
            // 
            this.cbxOperador.Enabled = false;
            this.cbxOperador.FormattingEnabled = true;
            this.cbxOperador.Location = new System.Drawing.Point(67, 179);
            this.cbxOperador.Name = "cbxOperador";
            this.cbxOperador.Size = new System.Drawing.Size(219, 21);
            this.cbxOperador.TabIndex = 9;
            // 
            // cbxTipo
            // 
            this.cbxTipo.Enabled = false;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(67, 208);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(219, 21);
            this.cbxTipo.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(67, 151);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 20);
            this.txtNome.TabIndex = 12;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(24, 155);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome:";
            // 
            // FormCampoPesquisaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(593, 263);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxOperador);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.txtCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtTabela);
            this.Controls.Add(this.lblTabela);
            this.Name = "FormCampoPesquisaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Campos da Pesquisa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCampoPesquisaCadastro_FormClosed);
            this.Load += new System.EventHandler(this.FormCampoPesquisaCadastro_Load);
            this.Controls.SetChildIndex(this.lblTabela, 0);
            this.Controls.SetChildIndex(this.txtTabela, 0);
            this.Controls.SetChildIndex(this.lblCampo, 0);
            this.Controls.SetChildIndex(this.txtCampo, 0);
            this.Controls.SetChildIndex(this.lblOperador, 0);
            this.Controls.SetChildIndex(this.lblTipo, 0);
            this.Controls.SetChildIndex(this.cbxOperador, 0);
            this.Controls.SetChildIndex(this.cbxTipo, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.TextBox txtTabela;
        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxOperador;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}
