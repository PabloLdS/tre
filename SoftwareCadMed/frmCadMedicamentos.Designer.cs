namespace AppMediCadastro
{
    partial class frmCadMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadMedicamentos));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbMedicamento = new System.Windows.Forms.GroupBox();
            this.txtPrincipio = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblPrincipio = new System.Windows.Forms.Label();
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbFabricante = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbMedicamento.SuspendLayout();
            this.gbProduto.SuspendLayout();
            this.gbFabricante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(301, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(247, 247);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(48, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 247);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(50, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbMedicamento
            // 
            this.gbMedicamento.BackColor = System.Drawing.Color.Transparent;
            this.gbMedicamento.Controls.Add(this.txtPrincipio);
            this.gbMedicamento.Controls.Add(this.txtQuantidade);
            this.gbMedicamento.Controls.Add(this.lblIdade);
            this.gbMedicamento.Controls.Add(this.lblPrincipio);
            this.gbMedicamento.Location = new System.Drawing.Point(12, 164);
            this.gbMedicamento.Name = "gbMedicamento";
            this.gbMedicamento.Size = new System.Drawing.Size(395, 77);
            this.gbMedicamento.TabIndex = 8;
            this.gbMedicamento.TabStop = false;
            this.gbMedicamento.Text = "Medicamento";
            // 
            // txtPrincipio
            // 
            this.txtPrincipio.Location = new System.Drawing.Point(10, 42);
            this.txtPrincipio.Name = "txtPrincipio";
            this.txtPrincipio.Size = new System.Drawing.Size(120, 20);
            this.txtPrincipio.TabIndex = 6;
            this.txtPrincipio.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrincipio_Validating);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(136, 42);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            this.txtQuantidade.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantidade_Validating);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(133, 25);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(62, 13);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Quantidade";
            // 
            // lblPrincipio
            // 
            this.lblPrincipio.AutoSize = true;
            this.lblPrincipio.Location = new System.Drawing.Point(7, 26);
            this.lblPrincipio.Name = "lblPrincipio";
            this.lblPrincipio.Size = new System.Drawing.Size(75, 13);
            this.lblPrincipio.TabIndex = 0;
            this.lblPrincipio.Text = "Princípio ativo";
            // 
            // gbProduto
            // 
            this.gbProduto.BackColor = System.Drawing.Color.Transparent;
            this.gbProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbProduto.Controls.Add(this.txtPreco);
            this.gbProduto.Controls.Add(this.lblPreco);
            this.gbProduto.Controls.Add(this.txtDescricao);
            this.gbProduto.Controls.Add(this.lblDescricao);
            this.gbProduto.Controls.Add(this.txtCodigo);
            this.gbProduto.Controls.Add(this.lblCodigo);
            this.gbProduto.Location = new System.Drawing.Point(12, 60);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(395, 104);
            this.gbProduto.TabIndex = 7;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Produtos";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(165, 37);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(71, 20);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            this.txtPreco.Validating += new System.ComponentModel.CancelEventHandler(this.txtPreco_Validating);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(162, 21);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(13, 78);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(223, 20);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescricao_Validating);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(10, 62);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(13, 37);
            this.txtCodigo.MaxLength = 13;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(146, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(10, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(87, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código de barras";
            // 
            // gbFabricante
            // 
            this.gbFabricante.BackColor = System.Drawing.Color.Transparent;
            this.gbFabricante.Controls.Add(this.txtNome);
            this.gbFabricante.Controls.Add(this.txtCNPJ);
            this.gbFabricante.Controls.Add(this.lblNome);
            this.gbFabricante.Controls.Add(this.lblCNPJ);
            this.gbFabricante.Location = new System.Drawing.Point(12, 1);
            this.gbFabricante.Name = "gbFabricante";
            this.gbFabricante.Size = new System.Drawing.Size(395, 59);
            this.gbFabricante.TabIndex = 6;
            this.gbFabricante.TabStop = false;
            this.gbFabricante.Text = "Fabricante";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(10, 33);
            this.txtCNPJ.MaxLength = 14;
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(120, 20);
            this.txtCNPJ.TabIndex = 2;
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJ_KeyPress);
            this.txtCNPJ.Validating += new System.ComponentModel.CancelEventHandler(this.txtCNPJ_Validating);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(133, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(7, 16);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 0;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmCadMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppMediCadastro.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(410, 278);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbMedicamento);
            this.Controls.Add(this.gbProduto);
            this.Controls.Add(this.gbFabricante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Medicamentos";
            this.gbMedicamento.ResumeLayout(false);
            this.gbMedicamento.PerformLayout();
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            this.gbFabricante.ResumeLayout(false);
            this.gbFabricante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbMedicamento;
        private System.Windows.Forms.TextBox txtPrincipio;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblPrincipio;
        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gbFabricante;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}