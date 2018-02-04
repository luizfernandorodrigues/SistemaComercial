namespace Apresentacao
{
    partial class FormCepPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCepPesquisa));
            this.dataGridViewCep = new System.Windows.Forms.DataGridView();
            this.Seleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCepPesquisa = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.comboBoxCep = new System.Windows.Forms.ComboBox();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.textBoxCep = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxCepEntre = new System.Windows.Forms.TextBox();
            this.textBoxCidadeEntre = new System.Windows.Forms.TextBox();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonDesmarcaTudo = new System.Windows.Forms.Button();
            this.buttonMarcarTudo = new System.Windows.Forms.Button();
            this.buttonCarregaSelecionado = new System.Windows.Forms.Button();
            this.buttonPesquisaCep = new System.Windows.Forms.Button();
            this.toolTipPesquisaCep = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCep)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCep
            // 
            this.dataGridViewCep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleciona,
            this.Cep,
            this.Cidade,
            this.Estado});
            this.dataGridViewCep.Location = new System.Drawing.Point(12, 102);
            this.dataGridViewCep.Name = "dataGridViewCep";
            this.dataGridViewCep.Size = new System.Drawing.Size(466, 292);
            this.dataGridViewCep.TabIndex = 0;
            // 
            // Seleciona
            // 
            this.Seleciona.HeaderText = "SL";
            this.Seleciona.Name = "Seleciona";
            this.Seleciona.Width = 50;
            // 
            // Cep
            // 
            this.Cep.HeaderText = "Cep";
            this.Cep.Name = "Cep";
            // 
            // Cidade
            // 
            this.Cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // labelCepPesquisa
            // 
            this.labelCepPesquisa.AutoSize = true;
            this.labelCepPesquisa.Location = new System.Drawing.Point(12, 9);
            this.labelCepPesquisa.Name = "labelCepPesquisa";
            this.labelCepPesquisa.Size = new System.Drawing.Size(26, 13);
            this.labelCepPesquisa.TabIndex = 1;
            this.labelCepPesquisa.Text = "Cep";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(-2, 39);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(40, 13);
            this.labelCidade.TabIndex = 2;
            this.labelCidade.Text = "Cidade";
            // 
            // comboBoxCep
            // 
            this.comboBoxCep.FormattingEnabled = true;
            this.comboBoxCep.Location = new System.Drawing.Point(38, 6);
            this.comboBoxCep.Name = "comboBoxCep";
            this.comboBoxCep.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCep.TabIndex = 3;
            this.comboBoxCep.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCep_SelectionChangeCommitted);
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Location = new System.Drawing.Point(38, 35);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCidade.TabIndex = 4;
            this.comboBoxCidade.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCidade_SelectionChangeCommitted);
            // 
            // textBoxCep
            // 
            this.textBoxCep.Location = new System.Drawing.Point(167, 6);
            this.textBoxCep.Name = "textBoxCep";
            this.textBoxCep.Size = new System.Drawing.Size(100, 20);
            this.textBoxCep.TabIndex = 5;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(167, 35);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxCidade.TabIndex = 6;
            // 
            // textBoxCepEntre
            // 
            this.textBoxCepEntre.Location = new System.Drawing.Point(275, 6);
            this.textBoxCepEntre.Name = "textBoxCepEntre";
            this.textBoxCepEntre.Size = new System.Drawing.Size(100, 20);
            this.textBoxCepEntre.TabIndex = 8;
            this.textBoxCepEntre.Visible = false;
            // 
            // textBoxCidadeEntre
            // 
            this.textBoxCidadeEntre.Location = new System.Drawing.Point(275, 35);
            this.textBoxCidadeEntre.Name = "textBoxCidadeEntre";
            this.textBoxCidadeEntre.Size = new System.Drawing.Size(100, 20);
            this.textBoxCidadeEntre.TabIndex = 9;
            this.textBoxCidadeEntre.Visible = false;
            // 
            // buttonExcel
            // 
            this.buttonExcel.Image = global::Apresentacao.Properties.Resources.Microsoft_Excel_25px;
            this.buttonExcel.Location = new System.Drawing.Point(135, 64);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(34, 32);
            this.buttonExcel.TabIndex = 13;
            this.buttonExcel.UseVisualStyleBackColor = true;
            // 
            // buttonDesmarcaTudo
            // 
            this.buttonDesmarcaTudo.Image = global::Apresentacao.Properties.Resources.Unchecked_Checkbox_25px;
            this.buttonDesmarcaTudo.Location = new System.Drawing.Point(95, 64);
            this.buttonDesmarcaTudo.Name = "buttonDesmarcaTudo";
            this.buttonDesmarcaTudo.Size = new System.Drawing.Size(34, 32);
            this.buttonDesmarcaTudo.TabIndex = 12;
            this.buttonDesmarcaTudo.UseVisualStyleBackColor = true;
            // 
            // buttonMarcarTudo
            // 
            this.buttonMarcarTudo.Image = global::Apresentacao.Properties.Resources.Checked_25px;
            this.buttonMarcarTudo.Location = new System.Drawing.Point(55, 64);
            this.buttonMarcarTudo.Name = "buttonMarcarTudo";
            this.buttonMarcarTudo.Size = new System.Drawing.Size(34, 32);
            this.buttonMarcarTudo.TabIndex = 11;
            this.buttonMarcarTudo.UseVisualStyleBackColor = true;
            // 
            // buttonCarregaSelecionado
            // 
            this.buttonCarregaSelecionado.Image = global::Apresentacao.Properties.Resources.Upload_25px;
            this.buttonCarregaSelecionado.Location = new System.Drawing.Point(15, 64);
            this.buttonCarregaSelecionado.Name = "buttonCarregaSelecionado";
            this.buttonCarregaSelecionado.Size = new System.Drawing.Size(34, 32);
            this.buttonCarregaSelecionado.TabIndex = 10;
            this.buttonCarregaSelecionado.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisaCep
            // 
            this.buttonPesquisaCep.Image = global::Apresentacao.Properties.Resources.Binoculars_25px;
            this.buttonPesquisaCep.Location = new System.Drawing.Point(403, 6);
            this.buttonPesquisaCep.Name = "buttonPesquisaCep";
            this.buttonPesquisaCep.Size = new System.Drawing.Size(75, 46);
            this.buttonPesquisaCep.TabIndex = 7;
            this.buttonPesquisaCep.UseVisualStyleBackColor = true;
            this.buttonPesquisaCep.Click += new System.EventHandler(this.buttonPesquisaCep_Click);
            // 
            // FormCepPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 406);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonDesmarcaTudo);
            this.Controls.Add(this.buttonMarcarTudo);
            this.Controls.Add(this.buttonCarregaSelecionado);
            this.Controls.Add(this.textBoxCidadeEntre);
            this.Controls.Add(this.textBoxCepEntre);
            this.Controls.Add(this.buttonPesquisaCep);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxCep);
            this.Controls.Add(this.comboBoxCidade);
            this.Controls.Add(this.comboBoxCep);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.labelCepPesquisa);
            this.Controls.Add(this.dataGridViewCep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCepPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Cep";
            this.Load += new System.EventHandler(this.FormCepPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCep;
        private System.Windows.Forms.Label labelCepPesquisa;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.ComboBox comboBoxCep;
        private System.Windows.Forms.ComboBox comboBoxCidade;
        private System.Windows.Forms.TextBox textBoxCep;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Button buttonPesquisaCep;
        private System.Windows.Forms.TextBox textBoxCepEntre;
        private System.Windows.Forms.TextBox textBoxCidadeEntre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button buttonCarregaSelecionado;
        private System.Windows.Forms.Button buttonMarcarTudo;
        private System.Windows.Forms.Button buttonDesmarcaTudo;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.ToolTip toolTipPesquisaCep;
    }
}