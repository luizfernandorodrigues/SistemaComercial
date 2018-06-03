namespace Apresentacao
{
    partial class FormPesquisaCadastro
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
            this.Tabela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditaRegistro = new System.Windows.Forms.Button();
            this.btnVisualizaRegistro = new System.Windows.Forms.Button();
            this.btnApagaRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
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
            this.btnNovoRegistro.Enabled = false;
            this.btnNovoRegistro.Image = global::Apresentacao.Properties.Resources.Add_List_15px;
            this.btnNovoRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoRegistro.Location = new System.Drawing.Point(21, 485);
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnNovoRegistro.TabIndex = 12;
            this.btnNovoRegistro.Text = "Novo";
            this.btnNovoRegistro.UseVisualStyleBackColor = true;
            this.btnNovoRegistro.Click += new System.EventHandler(this.btnNovoRegistro_Click);
            // 
            // dgvCampos
            // 
            this.dgvCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tabela,
            this.Campo,
            this.Operador,
            this.Tipo});
            this.dgvCampos.Location = new System.Drawing.Point(21, 514);
            this.dgvCampos.Name = "dgvCampos";
            this.dgvCampos.Size = new System.Drawing.Size(568, 150);
            this.dgvCampos.TabIndex = 13;
            // 
            // Tabela
            // 
            this.Tabela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tabela.DataPropertyName = "tabelaCampo";
            this.Tabela.HeaderText = "Tabela";
            this.Tabela.Name = "Tabela";
            // 
            // Campo
            // 
            this.Campo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Campo.DataPropertyName = "campo";
            this.Campo.HeaderText = "Campo";
            this.Campo.Name = "Campo";
            // 
            // Operador
            // 
            this.Operador.DataPropertyName = "operadorCampo";
            this.Operador.HeaderText = "Operador";
            this.Operador.Name = "Operador";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipoCampo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // btnEditaRegistro
            // 
            this.btnEditaRegistro.Enabled = false;
            this.btnEditaRegistro.Image = global::Apresentacao.Properties.Resources.Edit_Property_15px;
            this.btnEditaRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditaRegistro.Location = new System.Drawing.Point(102, 485);
            this.btnEditaRegistro.Name = "btnEditaRegistro";
            this.btnEditaRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnEditaRegistro.TabIndex = 14;
            this.btnEditaRegistro.Text = "Editar";
            this.btnEditaRegistro.UseVisualStyleBackColor = true;
            // 
            // btnVisualizaRegistro
            // 
            this.btnVisualizaRegistro.Enabled = false;
            this.btnVisualizaRegistro.Image = global::Apresentacao.Properties.Resources.Page_Overview__15px;
            this.btnVisualizaRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizaRegistro.Location = new System.Drawing.Point(183, 485);
            this.btnVisualizaRegistro.Name = "btnVisualizaRegistro";
            this.btnVisualizaRegistro.Size = new System.Drawing.Size(71, 23);
            this.btnVisualizaRegistro.TabIndex = 15;
            this.btnVisualizaRegistro.Text = "Visualiza";
            this.btnVisualizaRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizaRegistro.UseVisualStyleBackColor = true;
            // 
            // btnApagaRegistro
            // 
            this.btnApagaRegistro.Enabled = false;
            this.btnApagaRegistro.Image = global::Apresentacao.Properties.Resources.Delete_Property_15px;
            this.btnApagaRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagaRegistro.Location = new System.Drawing.Point(264, 485);
            this.btnApagaRegistro.Name = "btnApagaRegistro";
            this.btnApagaRegistro.Size = new System.Drawing.Size(66, 23);
            this.btnApagaRegistro.TabIndex = 16;
            this.btnApagaRegistro.Text = "Apagar";
            this.btnApagaRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagaRegistro.UseVisualStyleBackColor = true;
            // 
            // FormPesquisaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(593, 671);
            this.Controls.Add(this.btnApagaRegistro);
            this.Controls.Add(this.btnVisualizaRegistro);
            this.Controls.Add(this.btnEditaRegistro);
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
            this.Name = "FormPesquisaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pesquisa";
            this.Load += new System.EventHandler(this.FormPesquisaCadastro_Load);
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
            this.Controls.SetChildIndex(this.btnEditaRegistro, 0);
            this.Controls.SetChildIndex(this.btnVisualizaRegistro, 0);
            this.Controls.SetChildIndex(this.btnApagaRegistro, 0);
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
        private System.Windows.Forms.Button btnEditaRegistro;
        private System.Windows.Forms.Button btnVisualizaRegistro;
        private System.Windows.Forms.Button btnApagaRegistro;
        public System.Windows.Forms.DataGridView dgvCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}
