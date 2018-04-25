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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPais)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxNome
            // 
            this.cbxNome.FormattingEnabled = true;
            this.cbxNome.Location = new System.Drawing.Point(12, 12);
            this.cbxNome.Name = "cbxNome";
            this.cbxNome.Size = new System.Drawing.Size(121, 21);
            this.cbxNome.TabIndex = 0;
            this.cbxNome.SelectionChangeCommitted += new System.EventHandler(this.cbxNome_SelectionChangeCommitted);
            // 
            // cbxCodigo
            // 
            this.cbxCodigo.FormattingEnabled = true;
            this.cbxCodigo.Location = new System.Drawing.Point(12, 39);
            this.cbxCodigo.Name = "cbxCodigo";
            this.cbxCodigo.Size = new System.Drawing.Size(121, 21);
            this.cbxCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(204, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtCodigoEntre
            // 
            this.txtCodigoEntre.Location = new System.Drawing.Point(395, 40);
            this.txtCodigoEntre.Name = "txtCodigoEntre";
            this.txtCodigoEntre.Size = new System.Drawing.Size(250, 20);
            this.txtCodigoEntre.TabIndex = 3;
            this.txtCodigoEntre.Visible = false;
            // 
            // txtNomeEntre
            // 
            this.txtNomeEntre.Location = new System.Drawing.Point(395, 13);
            this.txtNomeEntre.Name = "txtNomeEntre";
            this.txtNomeEntre.Size = new System.Drawing.Size(250, 20);
            this.txtNomeEntre.TabIndex = 4;
            this.txtNomeEntre.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(204, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(185, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // dgvPais
            // 
            this.dgvPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPais.Location = new System.Drawing.Point(12, 116);
            this.dgvPais.Name = "dgvPais";
            this.dgvPais.Size = new System.Drawing.Size(714, 322);
            this.dgvPais.TabIndex = 6;
            // 
            // btnExportaExcel
            // 
            this.btnExportaExcel.Image = global::Apresentacao.Properties.Resources.Microsoft_Excel_25px;
            this.btnExportaExcel.Location = new System.Drawing.Point(269, 65);
            this.btnExportaExcel.Name = "btnExportaExcel";
            this.btnExportaExcel.Size = new System.Drawing.Size(59, 49);
            this.btnExportaExcel.TabIndex = 9;
            this.btnExportaExcel.UseVisualStyleBackColor = true;
            // 
            // btnDesmarcaTudo
            // 
            this.btnDesmarcaTudo.Image = global::Apresentacao.Properties.Resources.Unchecked_Checkbox_25px;
            this.btnDesmarcaTudo.Location = new System.Drawing.Point(204, 65);
            this.btnDesmarcaTudo.Name = "btnDesmarcaTudo";
            this.btnDesmarcaTudo.Size = new System.Drawing.Size(59, 49);
            this.btnDesmarcaTudo.TabIndex = 10;
            this.btnDesmarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnInverteSelecao
            // 
            this.btnInverteSelecao.Image = global::Apresentacao.Properties.Resources.Invert_Selection_25px;
            this.btnInverteSelecao.Location = new System.Drawing.Point(139, 65);
            this.btnInverteSelecao.Name = "btnInverteSelecao";
            this.btnInverteSelecao.Size = new System.Drawing.Size(59, 49);
            this.btnInverteSelecao.TabIndex = 11;
            this.btnInverteSelecao.UseVisualStyleBackColor = true;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::Apresentacao.Properties.Resources.Binoculars_25px;
            this.btnPesquisa.Location = new System.Drawing.Point(664, 11);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(59, 49);
            this.btnPesquisa.TabIndex = 13;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnMarcaTudo
            // 
            this.btnMarcaTudo.Image = global::Apresentacao.Properties.Resources.Checklist_25px;
            this.btnMarcaTudo.Location = new System.Drawing.Point(77, 65);
            this.btnMarcaTudo.Name = "btnMarcaTudo";
            this.btnMarcaTudo.Size = new System.Drawing.Size(59, 49);
            this.btnMarcaTudo.TabIndex = 12;
            this.btnMarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnCarregaFiltrado
            // 
            this.btnCarregaFiltrado.Image = global::Apresentacao.Properties.Resources.Checked_Checkbox_25px;
            this.btnCarregaFiltrado.Location = new System.Drawing.Point(12, 65);
            this.btnCarregaFiltrado.Name = "btnCarregaFiltrado";
            this.btnCarregaFiltrado.Size = new System.Drawing.Size(59, 49);
            this.btnCarregaFiltrado.TabIndex = 7;
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
            this.lblNomePesquisa.Location = new System.Drawing.Point(163, 17);
            this.lblNomePesquisa.Name = "lblNomePesquisa";
            this.lblNomePesquisa.Size = new System.Drawing.Size(35, 13);
            this.lblNomePesquisa.TabIndex = 14;
            this.lblNomePesquisa.Text = "Nome";
            // 
            // lblCodigoPesquisa
            // 
            this.lblCodigoPesquisa.AutoSize = true;
            this.lblCodigoPesquisa.Location = new System.Drawing.Point(163, 42);
            this.lblCodigoPesquisa.Name = "lblCodigoPesquisa";
            this.lblCodigoPesquisa.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoPesquisa.TabIndex = 15;
            this.lblCodigoPesquisa.Text = "Código";
            // 
            // FormPaisPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
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
    }
}