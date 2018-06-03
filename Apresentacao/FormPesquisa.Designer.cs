namespace Apresentacao
{
    partial class FormPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisa));
            this.dgvPesquisas = new System.Windows.Forms.DataGridView();
            this.btnPesquisaRegistros = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFiltraPesquisas = new System.Windows.Forms.Button();
            this.bsPesquisa = new System.Windows.Forms.BindingSource(this.components);
            this.Pesquisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPesquisas
            // 
            this.dgvPesquisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pesquisa});
            this.dgvPesquisas.Location = new System.Drawing.Point(5, 37);
            this.dgvPesquisas.Name = "dgvPesquisas";
            this.dgvPesquisas.RowHeadersVisible = false;
            this.dgvPesquisas.Size = new System.Drawing.Size(240, 411);
            this.dgvPesquisas.TabIndex = 0;
            // 
            // btnPesquisaRegistros
            // 
            this.btnPesquisaRegistros.Location = new System.Drawing.Point(272, 37);
            this.btnPesquisaRegistros.Name = "btnPesquisaRegistros";
            this.btnPesquisaRegistros.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaRegistros.TabIndex = 1;
            this.btnPesquisaRegistros.Text = "Pesquisa";
            this.btnPesquisaRegistros.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnFiltraPesquisas
            // 
            this.btnFiltraPesquisas.Image = global::Apresentacao.Properties.Resources.search_15px;
            this.btnFiltraPesquisas.Location = new System.Drawing.Point(217, 10);
            this.btnFiltraPesquisas.Name = "btnFiltraPesquisas";
            this.btnFiltraPesquisas.Size = new System.Drawing.Size(28, 22);
            this.btnFiltraPesquisas.TabIndex = 3;
            this.btnFiltraPesquisas.UseVisualStyleBackColor = true;
            // 
            // Pesquisa
            // 
            this.Pesquisa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pesquisa.DataPropertyName = "nomePesquisa";
            this.Pesquisa.HeaderText = "Nome";
            this.Pesquisa.Name = "Pesquisa";
            // 
            // FormPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltraPesquisas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPesquisaRegistros);
            this.Controls.Add(this.dgvPesquisas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.FormPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPesquisas;
        private System.Windows.Forms.Button btnPesquisaRegistros;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFiltraPesquisas;
        private System.Windows.Forms.BindingSource bsPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pesquisa;
    }
}