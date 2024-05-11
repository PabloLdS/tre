namespace AppMediCadastro
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNomes = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.brqdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipAtalhos = new System.Windows.Forms.ToolTip(this.components);
            this.timerAtualizarHora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnVisualizar);
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(674, 52);
            this.panel1.TabIndex = 2;
            // 
            // labelNomes
            // 
            this.labelNomes.AutoSize = true;
            this.labelNomes.BackColor = System.Drawing.Color.Transparent;
            this.labelNomes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNomes.Location = new System.Drawing.Point(12, 375);
            this.labelNomes.Name = "labelNomes";
            this.labelNomes.Size = new System.Drawing.Size(109, 13);
            this.labelNomes.TabIndex = 2;
            this.labelNomes.Text = "Pablo Lemes da Silva";
            this.labelNomes.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelData
            // 
            this.labelData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelData.Location = new System.Drawing.Point(573, 368);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(89, 20);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "00/00/0000";
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelHora.Location = new System.Drawing.Point(566, 343);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(96, 25);
            this.labelHora.TabIndex = 10;
            this.labelHora.Text = "00:00:00";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(624, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(47, 45);
            this.btnSair.TabIndex = 9;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(65, 4);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(47, 45);
            this.btnVisualizar.TabIndex = 1;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastro.Image")));
            this.btnCadastro.Location = new System.Drawing.Point(12, 4);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(47, 45);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brqdToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // brqdToolStripMenuItem
            // 
            this.brqdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.visuToolStripMenuItem});
            this.brqdToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.brqdToolStripMenuItem.Name = "brqdToolStripMenuItem";
            this.brqdToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.brqdToolStripMenuItem.Text = "Medicamentos";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // visuToolStripMenuItem
            // 
            this.visuToolStripMenuItem.Name = "visuToolStripMenuItem";
            this.visuToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.visuToolStripMenuItem.Text = "Visualizar";
            this.visuToolStripMenuItem.Click += new System.EventHandler(this.visuToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // timerAtualizarHora
            // 
            this.timerAtualizarHora.Enabled = true;
            this.timerAtualizarHora.Interval = 1000;
            this.timerAtualizarHora.Tick += new System.EventHandler(this.timerAtualizarHora_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(674, 397);
            this.Controls.Add(this.labelNomes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelHora);
            this.DoubleBuffered = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pablo Lemes da Silva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNomes;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem brqdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipAtalhos;
        private System.Windows.Forms.Timer timerAtualizarHora;
    }
}

