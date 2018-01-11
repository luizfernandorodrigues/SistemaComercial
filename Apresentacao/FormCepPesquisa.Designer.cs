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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCepPesquisa));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCepPesquisa = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.comboBoxCep = new System.Windows.Forms.ComboBox();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.textBoxCep = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.buttonPesquisaCep = new System.Windows.Forms.Button();
            this.textBoxCepEntre = new System.Windows.Forms.TextBox();
            this.textBoxCidadeEntre = new System.Windows.Forms.TextBox();
            this.Seleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleciona,
            this.Cep,
            this.Cidade,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 327);
            this.dataGridView1.TabIndex = 0;
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
            // buttonPesquisaCep
            // 
            this.buttonPesquisaCep.Location = new System.Drawing.Point(403, 6);
            this.buttonPesquisaCep.Name = "buttonPesquisaCep";
            this.buttonPesquisaCep.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisaCep.TabIndex = 7;
            this.buttonPesquisaCep.Text = "Pesquisa";
            this.buttonPesquisaCep.UseVisualStyleBackColor = true;
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
            // FormCepPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 420);
            this.Controls.Add(this.textBoxCidadeEntre);
            this.Controls.Add(this.textBoxCepEntre);
            this.Controls.Add(this.buttonPesquisaCep);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxCep);
            this.Controls.Add(this.comboBoxCidade);
            this.Controls.Add(this.comboBoxCep);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.labelCepPesquisa);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCepPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Cep";
            this.Load += new System.EventHandler(this.FormCepPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}