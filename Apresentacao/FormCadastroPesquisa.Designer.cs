namespace Apresentacao
{
    partial class FormCadastroPesquisa
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTela = new System.Windows.Forms.TextBox();
            this.lblTela = new System.Windows.Forms.Label();
            this.ckbRelatorio = new System.Windows.Forms.CheckBox();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.lblSql = new System.Windows.Forms.Label();
            this.btnNovoRegistro = new System.Windows.Forms.Button();
            this.dgvCampos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).BeginInit();
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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 97);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(55, 93);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(196, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(393, 20);
            this.txtNome.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(158, 97);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // txtTela
            // 
            this.txtTela.Enabled = false;
            this.txtTela.Location = new System.Drawing.Point(55, 119);
            this.txtTela.Name = "txtTela";
            this.txtTela.Size = new System.Drawing.Size(100, 20);
            this.txtTela.TabIndex = 8;
            // 
            // lblTela
            // 
            this.lblTela.AutoSize = true;
            this.lblTela.Location = new System.Drawing.Point(24, 123);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(31, 13);
            this.lblTela.TabIndex = 7;
            this.lblTela.Text = "Tela:";
            // 
            // ckbRelatorio
            // 
            this.ckbRelatorio.AutoSize = true;
            this.ckbRelatorio.Enabled = false;
            this.ckbRelatorio.Location = new System.Drawing.Point(161, 123);
            this.ckbRelatorio.Name = "ckbRelatorio";
            this.ckbRelatorio.Size = new System.Drawing.Size(78, 17);
            this.ckbRelatorio.TabIndex = 9;
            this.ckbRelatorio.Text = "É Relatório";
            this.ckbRelatorio.UseVisualStyleBackColor = true;
            // 
            // txtSql
            // 
            this.txtSql.Enabled = false;
            this.txtSql.Location = new System.Drawing.Point(55, 145);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(534, 325);
            this.txtSql.TabIndex = 10;
            // 
            // lblSql
            // 
            this.lblSql.AutoSize = true;
            this.lblSql.Location = new System.Drawing.Point(18, 278);
            this.lblSql.Name = "lblSql";
            this.lblSql.Size = new System.Drawing.Size(31, 13);
            this.lblSql.TabIndex = 11;
            this.lblSql.Text = "SQL:";
            // 
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.Image = global::Apresentacao.Properties.Resources.plus_15px;
            this.btnNovoRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoRegistro.Location = new System.Drawing.Point(21, 485);
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnNovoRegistro.TabIndex = 12;
            this.btnNovoRegistro.Text = "Novo";
            this.btnNovoRegistro.UseVisualStyleBackColor = true;
            // 
            // dgvCampos
            // 
            this.dgvCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampos.Location = new System.Drawing.Point(21, 514);
            this.dgvCampos.Name = "dgvCampos";
            this.dgvCampos.Size = new System.Drawing.Size(568, 150);
            this.dgvCampos.TabIndex = 13;
            // 
            // FormCadastroPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(593, 671);
            this.Controls.Add(this.dgvCampos);
            this.Controls.Add(this.btnNovoRegistro);
            this.Controls.Add(this.lblSql);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.ckbRelatorio);
            this.Controls.Add(this.txtTela);
            this.Controls.Add(this.lblTela);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FormCadastroPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pesquisa";
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.lblTela, 0);
            this.Controls.SetChildIndex(this.txtTela, 0);
            this.Controls.SetChildIndex(this.ckbRelatorio, 0);
            this.Controls.SetChildIndex(this.txtSql, 0);
            this.Controls.SetChildIndex(this.lblSql, 0);
            this.Controls.SetChildIndex(this.btnNovoRegistro, 0);
            this.Controls.SetChildIndex(this.dgvCampos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtTela;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.CheckBox ckbRelatorio;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.Label lblSql;
        private System.Windows.Forms.Button btnNovoRegistro;
        private System.Windows.Forms.DataGridView dgvCampos;
    }
}
