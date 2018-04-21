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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaisPesquisa));
            this.cbxNome = new System.Windows.Forms.ComboBox();
            this.cbxCodigo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigoEntre = new System.Windows.Forms.TextBox();
            this.txtNomeEntre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvPais = new System.Windows.Forms.DataGridView();
            this.btnCarregaFiltrado = new System.Windows.Forms.Button();
            this.btnExportaExcel = new System.Windows.Forms.Button();
            this.btnInverteSelecao = new System.Windows.Forms.Button();
            this.btnDesmarcaTudo = new System.Windows.Forms.Button();
            this.btnMarcaTudo = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
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
            this.txtNome.Location = new System.Drawing.Point(139, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 20);
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
            this.txtCodigo.Location = new System.Drawing.Point(139, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(250, 20);
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
            // btnCarregaFiltrado
            // 
            this.btnCarregaFiltrado.Location = new System.Drawing.Point(12, 87);
            this.btnCarregaFiltrado.Name = "btnCarregaFiltrado";
            this.btnCarregaFiltrado.Size = new System.Drawing.Size(75, 23);
            this.btnCarregaFiltrado.TabIndex = 7;
            this.btnCarregaFiltrado.Text = "button1";
            this.btnCarregaFiltrado.UseVisualStyleBackColor = true;
            // 
            // btnExportaExcel
            // 
            this.btnExportaExcel.Location = new System.Drawing.Point(336, 87);
            this.btnExportaExcel.Name = "btnExportaExcel";
            this.btnExportaExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExportaExcel.TabIndex = 9;
            this.btnExportaExcel.Text = "button3";
            this.btnExportaExcel.UseVisualStyleBackColor = true;
            // 
            // btnInverteSelecao
            // 
            this.btnInverteSelecao.Location = new System.Drawing.Point(255, 87);
            this.btnInverteSelecao.Name = "btnInverteSelecao";
            this.btnInverteSelecao.Size = new System.Drawing.Size(75, 23);
            this.btnInverteSelecao.TabIndex = 10;
            this.btnInverteSelecao.Text = "button4";
            this.btnInverteSelecao.UseVisualStyleBackColor = true;
            // 
            // btnDesmarcaTudo
            // 
            this.btnDesmarcaTudo.Location = new System.Drawing.Point(174, 87);
            this.btnDesmarcaTudo.Name = "btnDesmarcaTudo";
            this.btnDesmarcaTudo.Size = new System.Drawing.Size(75, 23);
            this.btnDesmarcaTudo.TabIndex = 11;
            this.btnDesmarcaTudo.Text = "button5";
            this.btnDesmarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnMarcaTudo
            // 
            this.btnMarcaTudo.Location = new System.Drawing.Point(93, 87);
            this.btnMarcaTudo.Name = "btnMarcaTudo";
            this.btnMarcaTudo.Size = new System.Drawing.Size(75, 23);
            this.btnMarcaTudo.TabIndex = 12;
            this.btnMarcaTudo.Text = "button6";
            this.btnMarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(651, 27);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 13;
            this.btnPesquisa.Text = "button7";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // FormPaisPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnMarcaTudo);
            this.Controls.Add(this.btnDesmarcaTudo);
            this.Controls.Add(this.btnInverteSelecao);
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
        private System.Windows.Forms.Button btnInverteSelecao;
        private System.Windows.Forms.Button btnDesmarcaTudo;
        private System.Windows.Forms.Button btnMarcaTudo;
        private System.Windows.Forms.Button btnPesquisa;
    }
}