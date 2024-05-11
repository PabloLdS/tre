namespace AppMediCadastro
{
    partial class frmVisualizarMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarMedicamentos));
            this.btnCarregar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.rtbConteudo = new System.Windows.Forms.RichTextBox();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(256, 242);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 16;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(102, 72);
            this.txtCodigo.MaxLength = 13;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(143, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Location = new System.Drawing.Point(9, 75);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(87, 13);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Código de barras";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(256, 30);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 13;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.BackColor = System.Drawing.Color.Transparent;
            this.lblConteudo.Location = new System.Drawing.Point(9, 100);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(53, 13);
            this.lblConteudo.TabIndex = 12;
            this.lblConteudo.Text = "Conteúdo";
            // 
            // rtbConteudo
            // 
            this.rtbConteudo.Enabled = false;
            this.rtbConteudo.Location = new System.Drawing.Point(12, 116);
            this.rtbConteudo.Name = "rtbConteudo";
            this.rtbConteudo.Size = new System.Drawing.Size(319, 120);
            this.rtbConteudo.TabIndex = 11;
            this.rtbConteudo.Text = "";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(12, 33);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(238, 20);
            this.txtCaminho.TabIndex = 10;
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.BackColor = System.Drawing.Color.Transparent;
            this.lblCaminho.Location = new System.Drawing.Point(9, 16);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(101, 13);
            this.lblCaminho.TabIndex = 9;
            this.lblCaminho.Text = "Caminho do arquivo";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmVisualizarMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppMediCadastro.Properties.Resources.medicamen;
            this.ClientSize = new System.Drawing.Size(350, 274);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.rtbConteudo);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.lblCaminho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVisualizarMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualização de Medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.RichTextBox rtbConteudo;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}