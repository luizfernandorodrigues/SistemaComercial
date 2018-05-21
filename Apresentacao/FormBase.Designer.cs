namespace Apresentacao
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.panelNavegacao = new System.Windows.Forms.Panel();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimeiroRegistro = new System.Windows.Forms.Button();
            this.btnUltimoRegistro = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.panelControles = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTipCadastro = new System.Windows.Forms.ToolTip(this.components);
            this.panelNavegacao.SuspendLayout();
            this.panelControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavegacao
            // 
            this.panelNavegacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavegacao.Controls.Add(this.btnProximo);
            this.panelNavegacao.Controls.Add(this.btnAnterior);
            this.panelNavegacao.Controls.Add(this.btnPrimeiroRegistro);
            this.panelNavegacao.Controls.Add(this.btnUltimoRegistro);
            this.panelNavegacao.Controls.Add(this.btnRelatorio);
            this.panelNavegacao.Controls.Add(this.btnPesquisa);
            this.panelNavegacao.Location = new System.Drawing.Point(12, 5);
            this.panelNavegacao.Name = "panelNavegacao";
            this.panelNavegacao.Size = new System.Drawing.Size(186, 80);
            this.panelNavegacao.TabIndex = 0;
            // 
            // btnProximo
            // 
            this.btnProximo.Enabled = false;
            this.btnProximo.Image = global::Apresentacao.Properties.Resources.Circled_Right_2_25px;
            this.btnProximo.Location = new System.Drawing.Point(121, 38);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(60, 35);
            this.btnProximo.TabIndex = 5;
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Image = global::Apresentacao.Properties.Resources.Circled_Left_2_25px;
            this.btnAnterior.Location = new System.Drawing.Point(62, 38);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(60, 35);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimeiroRegistro
            // 
            this.btnPrimeiroRegistro.Enabled = false;
            this.btnPrimeiroRegistro.Image = global::Apresentacao.Properties.Resources.skip_to_start_25px;
            this.btnPrimeiroRegistro.Location = new System.Drawing.Point(62, 4);
            this.btnPrimeiroRegistro.Name = "btnPrimeiroRegistro";
            this.btnPrimeiroRegistro.Size = new System.Drawing.Size(60, 35);
            this.btnPrimeiroRegistro.TabIndex = 3;
            this.btnPrimeiroRegistro.UseVisualStyleBackColor = true;
            // 
            // btnUltimoRegistro
            // 
            this.btnUltimoRegistro.Enabled = false;
            this.btnUltimoRegistro.Image = global::Apresentacao.Properties.Resources.end_25px;
            this.btnUltimoRegistro.Location = new System.Drawing.Point(121, 4);
            this.btnUltimoRegistro.Name = "btnUltimoRegistro";
            this.btnUltimoRegistro.Size = new System.Drawing.Size(60, 35);
            this.btnUltimoRegistro.TabIndex = 2;
            this.btnUltimoRegistro.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Image = global::Apresentacao.Properties.Resources.Report_Card_25px1;
            this.btnRelatorio.Location = new System.Drawing.Point(3, 38);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(60, 35);
            this.btnRelatorio.TabIndex = 1;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisa.Image = global::Apresentacao.Properties.Resources.Search_25px;
            this.btnPesquisa.Location = new System.Drawing.Point(3, 4);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(60, 35);
            this.btnPesquisa.TabIndex = 0;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // panelControles
            // 
            this.panelControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControles.Controls.Add(this.btnSair);
            this.panelControles.Controls.Add(this.btnDesfazer);
            this.panelControles.Controls.Add(this.btnExcluir);
            this.panelControles.Controls.Add(this.btnSalvar);
            this.panelControles.Controls.Add(this.btnEditar);
            this.panelControles.Controls.Add(this.btnNovo);
            this.panelControles.Location = new System.Drawing.Point(198, 5);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(391, 58);
            this.panelControles.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Apresentacao.Properties.Resources.Exit_25px;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(328, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(59, 49);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.Enabled = false;
            this.btnDesfazer.Image = global::Apresentacao.Properties.Resources.Rotate_Left_25px;
            this.btnDesfazer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDesfazer.Location = new System.Drawing.Point(263, 4);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(59, 49);
            this.btnDesfazer.TabIndex = 4;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::Apresentacao.Properties.Resources.Delete_25px;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(198, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(59, 49);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::Apresentacao.Properties.Resources.Save_25px;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(133, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 49);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::Apresentacao.Properties.Resources.Edit_25px;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(68, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(59, 49);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Apresentacao.Properties.Resources.Plus_25px;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(3, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(59, 49);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(198, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Controles";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolTipCadastro
            // 
            this.toolTipCadastro.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipCadastro.ToolTipTitle = "Dica";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 252);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelControles);
            this.Controls.Add(this.panelNavegacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBase";
            this.Text = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.panelNavegacao.ResumeLayout(false);
            this.panelControles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavegacao;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnProximo;
        public System.Windows.Forms.Button btnAnterior;
        public System.Windows.Forms.Button btnPrimeiroRegistro;
        public System.Windows.Forms.Button btnUltimoRegistro;
        public System.Windows.Forms.Button btnRelatorio;
        public System.Windows.Forms.Button btnPesquisa;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnDesfazer;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ToolTip toolTipCadastro;
    }
}