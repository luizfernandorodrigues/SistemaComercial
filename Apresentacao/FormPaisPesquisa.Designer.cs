namespace Apresentacao
{
    partial class FormPaisPesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaisPesquisa));
            this.cbxNome = new System.Windows.Forms.ComboBox();
            this.cbxCodigo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigoEntre = new System.Windows.Forms.TextBox();
            this.txtNomeEntre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvPais = new System.Windows.Forms.DataGridView();
            this.btnExportaExcel = new System.Windows.Forms.Button();
            this.btnDesmarcaTudo = new System.Windows.Forms.Button();
            this.btnInverteSelecao = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnMarcaTudo = new System.Windows.Forms.Button();
            this.btnCarregaFiltrado = new System.Windows.Forms.Button();
            this.toolTipPesquisaPais = new System.Windows.Forms.ToolTip(this.components);
            this.lblNomePesquisa = new System.Windows.Forms.Label();
            this.lblCodigoPesquisa = new System.Windows.Forms.Label();
            this.seleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPais)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxNome
            // 
            this.cbxNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNome.FormattingEnabled = true;
            this.cbxNome.Location = new System.Drawing.Point(47, 9);
            this.cbxNome.Name = "cbxNome";
            this.cbxNome.Size = new System.Drawing.Size(121, 21);
            this.cbxNome.TabIndex = 11;
            this.cbxNome.SelectionChangeCommitted += new System.EventHandler(this.cbxNome_SelectionChangeCommitted);
            // 
            // cbxCodigo
            // 
            this.cbxCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCodigo.FormattingEnabled = true;
            this.cbxCodigo.Location = new System.Drawing.Point(47, 37);
            this.cbxCodigo.Name = "cbxCodigo";
            this.cbxCodigo.Size = new System.Drawing.Size(121, 21);
            this.cbxCodigo.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(176, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtCodigoEntre
            // 
            this.txtCodigoEntre.Location = new System.Drawing.Point(369, 37);
            this.txtCodigoEntre.Name = "txtCodigoEntre";
            this.txtCodigoEntre.Size = new System.Drawing.Size(250, 20);
            this.txtCodigoEntre.TabIndex = 3;
            this.txtCodigoEntre.Visible = false;
            // 
            // txtNomeEntre
            // 
            this.txtNomeEntre.Location = new System.Drawing.Point(369, 9);
            this.txtNomeEntre.Name = "txtNomeEntre";
            this.txtNomeEntre.Size = new System.Drawing.Size(250, 20);
            this.txtNomeEntre.TabIndex = 1;
            this.txtNomeEntre.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(176, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(185, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // dgvPais
            // 
            this.dgvPais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleciona,
            this.Nome,
            this.codigo});
            this.dgvPais.Location = new System.Drawing.Point(12, 124);
            this.dgvPais.Name = "dgvPais";
            this.dgvPais.Size = new System.Drawing.Size(672, 314);
            this.dgvPais.TabIndex = 4;
            // 
            // btnExportaExcel
            // 
            this.btnExportaExcel.Image = global::Apresentacao.Properties.Resources.Microsoft_Excel_25px;
            this.btnExportaExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportaExcel.Location = new System.Drawing.Point(308, 65);
            this.btnExportaExcel.Name = "btnExportaExcel";
            this.btnExportaExcel.Size = new System.Drawing.Size(66, 53);
            this.btnExportaExcel.TabIndex = 9;
            this.btnExportaExcel.Text = "Exportar Excel";
            this.btnExportaExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportaExcel.UseVisualStyleBackColor = true;
            // 
            // btnDesmarcaTudo
            // 
            this.btnDesmarcaTudo.Image = global::Apresentacao.Properties.Resources.Unchecked_Checkbox_25px;
            this.btnDesmarcaTudo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDesmarcaTudo.Location = new System.Drawing.Point(160, 66);
            this.btnDesmarcaTudo.Name = "btnDesmarcaTudo";
            this.btnDesmarcaTudo.Size = new System.Drawing.Size(66, 53);
            this.btnDesmarcaTudo.TabIndex = 7;
            this.btnDesmarcaTudo.Text = "Desmarca Tudo";
            this.btnDesmarcaTudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesmarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnInverteSelecao
            // 
            this.btnInverteSelecao.Image = global::Apresentacao.Properties.Resources.Invert_Selection_25px;
            this.btnInverteSelecao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInverteSelecao.Location = new System.Drawing.Point(234, 66);
            this.btnInverteSelecao.Name = "btnInverteSelecao";
            this.btnInverteSelecao.Size = new System.Drawing.Size(66, 53);
            this.btnInverteSelecao.TabIndex = 8;
            this.btnInverteSelecao.Text = "Inverter Seleção";
            this.btnInverteSelecao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInverteSelecao.UseVisualStyleBackColor = true;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::Apresentacao.Properties.Resources.Binoculars_25px;
            this.btnPesquisa.Location = new System.Drawing.Point(625, 8);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(59, 49);
            this.btnPesquisa.TabIndex = 14;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnMarcaTudo
            // 
            this.btnMarcaTudo.Image = global::Apresentacao.Properties.Resources.Checklist_25px;
            this.btnMarcaTudo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMarcaTudo.Location = new System.Drawing.Point(86, 65);
            this.btnMarcaTudo.Name = "btnMarcaTudo";
            this.btnMarcaTudo.Size = new System.Drawing.Size(66, 53);
            this.btnMarcaTudo.TabIndex = 6;
            this.btnMarcaTudo.Text = "Marca Tudo";
            this.btnMarcaTudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnCarregaFiltrado
            // 
            this.btnCarregaFiltrado.Image = global::Apresentacao.Properties.Resources.Checked_Checkbox_25px;
            this.btnCarregaFiltrado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCarregaFiltrado.Location = new System.Drawing.Point(12, 65);
            this.btnCarregaFiltrado.Name = "btnCarregaFiltrado";
            this.btnCarregaFiltrado.Size = new System.Drawing.Size(66, 53);
            this.btnCarregaFiltrado.TabIndex = 5;
            this.btnCarregaFiltrado.Text = "Carrega Filtrados";
            this.btnCarregaFiltrado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarregaFiltrado.UseVisualStyleBackColor = true;
            // 
            // toolTipPesquisaPais
            // 
            this.toolTipPesquisaPais.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPesquisaPais.ToolTipTitle = "Dica";
            // 
            // lblNomePesquisa
            // 
            this.lblNomePesquisa.AutoSize = true;
            this.lblNomePesquisa.Location = new System.Drawing.Point(12, 13);
            this.lblNomePesquisa.Name = "lblNomePesquisa";
            this.lblNomePesquisa.Size = new System.Drawing.Size(35, 13);
            this.lblNomePesquisa.TabIndex = 13;
            this.lblNomePesquisa.Text = "Nome";
            // 
            // lblCodigoPesquisa
            // 
            this.lblCodigoPesquisa.AutoSize = true;
            this.lblCodigoPesquisa.Location = new System.Drawing.Point(7, 41);
            this.lblCodigoPesquisa.Name = "lblCodigoPesquisa";
            this.lblCodigoPesquisa.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoPesquisa.TabIndex = 12;
            this.lblCodigoPesquisa.Text = "Código";
            // 
            // seleciona
            // 
            this.seleciona.HeaderText = "SL";
            this.seleciona.Name = "seleciona";
            this.seleciona.Width = 50;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // FormPaisPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.lblCodigoPesquisa);
            this.Controls.Add(this.lblNomePesquisa);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnMarcaTudo);
            this.Controls.Add(this.btnInverteSelecao);
            this.Controls.Add(this.btnDesmarcaTudo);
            this.Controls.Add(this.btnExportaExcel);
            this.Controls.Add(this.btnCarregaFiltrado);
            this.Controls.Add(this.dgvPais);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNomeEntre);
            this.Controls.Add(this.txtCodigoEntre);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbxCodigo);
            this.Controls.Add(this.cbxNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPaisPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Pais";
            this.Load += new System.EventHandler(this.FormPaisPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxNome;
        private System.Windows.Forms.ComboBox cbxCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigoEntre;
        private System.Windows.Forms.TextBox txtNomeEntre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvPais;
        private System.Windows.Forms.Button btnCarregaFiltrado;
        private System.Windows.Forms.Button btnExportaExcel;
        private System.Windows.Forms.Button btnDesmarcaTudo;
        private System.Windows.Forms.Button btnInverteSelecao;
        private System.Windows.Forms.Button btnMarcaTudo;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ToolTip toolTipPesquisaPais;
        private System.Windows.Forms.Label lblNomePesquisa;
        private System.Windows.Forms.Label lblCodigoPesquisa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
    }
}