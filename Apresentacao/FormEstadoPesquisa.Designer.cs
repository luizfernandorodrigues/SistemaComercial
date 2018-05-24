namespace Apresentacao
{
    partial class FormEstadoPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadoPesquisa));
            this.lblSiglaPesquisa = new System.Windows.Forms.Label();
            this.toolTipPesquisaEstado = new System.Windows.Forms.ToolTip(this.components);
            this.lblNomePesquisa = new System.Windows.Forms.Label();
            this.dgvEstado = new System.Windows.Forms.DataGridView();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtNomeEntre = new System.Windows.Forms.TextBox();
            this.txtSiglaEntre = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbxSigla = new System.Windows.Forms.ComboBox();
            this.cbxNome = new System.Windows.Forms.ComboBox();
            this.lblPaisPesquisa = new System.Windows.Forms.Label();
            this.txtPaisNome = new System.Windows.Forms.TextBox();
            this.txtPaisNomeEntre = new System.Windows.Forms.TextBox();
            this.cbxNomePais = new System.Windows.Forms.ComboBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnMarcaTudo = new System.Windows.Forms.Button();
            this.btnInverteSelecao = new System.Windows.Forms.Button();
            this.btnDesmarcaTudo = new System.Windows.Forms.Button();
            this.btnExportaExcel = new System.Windows.Forms.Button();
            this.btnCarregaFiltrado = new System.Windows.Forms.Button();
            this.seleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSiglaPesquisa
            // 
            this.lblSiglaPesquisa.AutoSize = true;
            this.lblSiglaPesquisa.Location = new System.Drawing.Point(5, 43);
            this.lblSiglaPesquisa.Name = "lblSiglaPesquisa";
            this.lblSiglaPesquisa.Size = new System.Drawing.Size(30, 13);
            this.lblSiglaPesquisa.TabIndex = 27;
            this.lblSiglaPesquisa.Text = "Sigla";
            // 
            // toolTipPesquisaEstado
            // 
            this.toolTipPesquisaEstado.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPesquisaEstado.ToolTipTitle = "Dica";
            // 
            // lblNomePesquisa
            // 
            this.lblNomePesquisa.AutoSize = true;
            this.lblNomePesquisa.Location = new System.Drawing.Point(10, 15);
            this.lblNomePesquisa.Name = "lblNomePesquisa";
            this.lblNomePesquisa.Size = new System.Drawing.Size(35, 13);
            this.lblNomePesquisa.TabIndex = 28;
            this.lblNomePesquisa.Text = "Nome";
            // 
            // dgvEstado
            // 
            this.dgvEstado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleciona,
            this.Nome,
            this.codigo,
            this.Pais});
            this.dgvEstado.Location = new System.Drawing.Point(10, 151);
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.Size = new System.Drawing.Size(672, 287);
            this.dgvEstado.TabIndex = 19;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(174, 39);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(185, 20);
            this.txtSigla.TabIndex = 17;
            // 
            // txtNomeEntre
            // 
            this.txtNomeEntre.Location = new System.Drawing.Point(367, 11);
            this.txtNomeEntre.Name = "txtNomeEntre";
            this.txtNomeEntre.Size = new System.Drawing.Size(250, 20);
            this.txtNomeEntre.TabIndex = 16;
            this.txtNomeEntre.Visible = false;
            // 
            // txtSiglaEntre
            // 
            this.txtSiglaEntre.Location = new System.Drawing.Point(367, 39);
            this.txtSiglaEntre.Name = "txtSiglaEntre";
            this.txtSiglaEntre.Size = new System.Drawing.Size(250, 20);
            this.txtSiglaEntre.TabIndex = 18;
            this.txtSiglaEntre.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(174, 11);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 20);
            this.txtNome.TabIndex = 15;
            // 
            // cbxSigla
            // 
            this.cbxSigla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSigla.FormattingEnabled = true;
            this.cbxSigla.Location = new System.Drawing.Point(45, 39);
            this.cbxSigla.Name = "cbxSigla";
            this.cbxSigla.Size = new System.Drawing.Size(121, 21);
            this.cbxSigla.TabIndex = 25;
            // 
            // cbxNome
            // 
            this.cbxNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNome.FormattingEnabled = true;
            this.cbxNome.Location = new System.Drawing.Point(45, 11);
            this.cbxNome.Name = "cbxNome";
            this.cbxNome.Size = new System.Drawing.Size(121, 21);
            this.cbxNome.TabIndex = 26;
            // 
            // lblPaisPesquisa
            // 
            this.lblPaisPesquisa.AutoSize = true;
            this.lblPaisPesquisa.Location = new System.Drawing.Point(5, 70);
            this.lblPaisPesquisa.Name = "lblPaisPesquisa";
            this.lblPaisPesquisa.Size = new System.Drawing.Size(27, 13);
            this.lblPaisPesquisa.TabIndex = 33;
            this.lblPaisPesquisa.Text = "Pais";
            // 
            // txtPaisNome
            // 
            this.txtPaisNome.Location = new System.Drawing.Point(174, 66);
            this.txtPaisNome.Name = "txtPaisNome";
            this.txtPaisNome.Size = new System.Drawing.Size(185, 20);
            this.txtPaisNome.TabIndex = 30;
            // 
            // txtPaisNomeEntre
            // 
            this.txtPaisNomeEntre.Location = new System.Drawing.Point(367, 66);
            this.txtPaisNomeEntre.Name = "txtPaisNomeEntre";
            this.txtPaisNomeEntre.Size = new System.Drawing.Size(250, 20);
            this.txtPaisNomeEntre.TabIndex = 31;
            this.txtPaisNomeEntre.Visible = false;
            // 
            // cbxNomePais
            // 
            this.cbxNomePais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNomePais.FormattingEnabled = true;
            this.cbxNomePais.Location = new System.Drawing.Point(45, 66);
            this.cbxNomePais.Name = "cbxNomePais";
            this.cbxNomePais.Size = new System.Drawing.Size(121, 21);
            this.cbxNomePais.TabIndex = 32;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::Apresentacao.Properties.Resources.Binoculars_25px;
            this.btnPesquisa.Location = new System.Drawing.Point(623, 10);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(59, 49);
            this.btnPesquisa.TabIndex = 29;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnMarcaTudo
            // 
            this.btnMarcaTudo.Image = global::Apresentacao.Properties.Resources.Checklist_25px;
            this.btnMarcaTudo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMarcaTudo.Location = new System.Drawing.Point(84, 92);
            this.btnMarcaTudo.Name = "btnMarcaTudo";
            this.btnMarcaTudo.Size = new System.Drawing.Size(66, 53);
            this.btnMarcaTudo.TabIndex = 21;
            this.btnMarcaTudo.Text = "Marca Tudo";
            this.btnMarcaTudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnInverteSelecao
            // 
            this.btnInverteSelecao.Image = global::Apresentacao.Properties.Resources.Invert_Selection_25px;
            this.btnInverteSelecao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInverteSelecao.Location = new System.Drawing.Point(232, 93);
            this.btnInverteSelecao.Name = "btnInverteSelecao";
            this.btnInverteSelecao.Size = new System.Drawing.Size(66, 53);
            this.btnInverteSelecao.TabIndex = 23;
            this.btnInverteSelecao.Text = "Inverter Seleção";
            this.btnInverteSelecao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInverteSelecao.UseVisualStyleBackColor = true;
            // 
            // btnDesmarcaTudo
            // 
            this.btnDesmarcaTudo.Image = global::Apresentacao.Properties.Resources.Unchecked_Checkbox_25px;
            this.btnDesmarcaTudo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDesmarcaTudo.Location = new System.Drawing.Point(158, 93);
            this.btnDesmarcaTudo.Name = "btnDesmarcaTudo";
            this.btnDesmarcaTudo.Size = new System.Drawing.Size(66, 53);
            this.btnDesmarcaTudo.TabIndex = 22;
            this.btnDesmarcaTudo.Text = "Desmarca Tudo";
            this.btnDesmarcaTudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesmarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnExportaExcel
            // 
            this.btnExportaExcel.Image = global::Apresentacao.Properties.Resources.Microsoft_Excel_25px;
            this.btnExportaExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportaExcel.Location = new System.Drawing.Point(306, 92);
            this.btnExportaExcel.Name = "btnExportaExcel";
            this.btnExportaExcel.Size = new System.Drawing.Size(66, 53);
            this.btnExportaExcel.TabIndex = 24;
            this.btnExportaExcel.Text = "Exportar Excel";
            this.btnExportaExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportaExcel.UseVisualStyleBackColor = true;
            // 
            // btnCarregaFiltrado
            // 
            this.btnCarregaFiltrado.Image = global::Apresentacao.Properties.Resources.Checked_Checkbox_25px;
            this.btnCarregaFiltrado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCarregaFiltrado.Location = new System.Drawing.Point(10, 92);
            this.btnCarregaFiltrado.Name = "btnCarregaFiltrado";
            this.btnCarregaFiltrado.Size = new System.Drawing.Size(66, 53);
            this.btnCarregaFiltrado.TabIndex = 20;
            this.btnCarregaFiltrado.Text = "Carrega Filtrados";
            this.btnCarregaFiltrado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarregaFiltrado.UseVisualStyleBackColor = true;
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
            this.Nome.FillWeight = 98.97959F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "siglaEstado";
            this.codigo.FillWeight = 102.0408F;
            this.codigo.HeaderText = "Sigla";
            this.codigo.Name = "codigo";
            this.codigo.Width = 50;
            // 
            // Pais
            // 
            this.Pais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pais.FillWeight = 98.97959F;
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            // 
            // FormEstadoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.lblPaisPesquisa);
            this.Controls.Add(this.txtPaisNome);
            this.Controls.Add(this.txtPaisNomeEntre);
            this.Controls.Add(this.cbxNomePais);
            this.Controls.Add(this.lblSiglaPesquisa);
            this.Controls.Add(this.lblNomePesquisa);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnMarcaTudo);
            this.Controls.Add(this.btnInverteSelecao);
            this.Controls.Add(this.btnDesmarcaTudo);
            this.Controls.Add(this.btnExportaExcel);
            this.Controls.Add(this.btnCarregaFiltrado);
            this.Controls.Add(this.dgvEstado);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtNomeEntre);
            this.Controls.Add(this.txtSiglaEntre);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbxSigla);
            this.Controls.Add(this.cbxNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEstadoPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Estado";
            this.Load += new System.EventHandler(this.FormEstadoPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSiglaPesquisa;
        private System.Windows.Forms.ToolTip toolTipPesquisaEstado;
        private System.Windows.Forms.Label lblNomePesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnMarcaTudo;
        private System.Windows.Forms.Button btnInverteSelecao;
        private System.Windows.Forms.Button btnDesmarcaTudo;
        private System.Windows.Forms.Button btnExportaExcel;
        private System.Windows.Forms.Button btnCarregaFiltrado;
        private System.Windows.Forms.DataGridView dgvEstado;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtNomeEntre;
        private System.Windows.Forms.TextBox txtSiglaEntre;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbxSigla;
        private System.Windows.Forms.ComboBox cbxNome;
        private System.Windows.Forms.Label lblPaisPesquisa;
        private System.Windows.Forms.TextBox txtPaisNome;
        private System.Windows.Forms.TextBox txtPaisNomeEntre;
        private System.Windows.Forms.ComboBox cbxNomePais;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
    }
}