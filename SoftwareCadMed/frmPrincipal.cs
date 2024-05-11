using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediCadastro
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            AtualizarDataHora();
        }

        private void timerAtualizarHora_Tick(object sender, EventArgs e)
        {
            AtualizarDataHora();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - Versão: " + Application.ProductVersion.ToString();

            toolTipAtalhos.SetToolTip(this.btnCadastro, "Cadastro de Medicamentos.");
            toolTipAtalhos.SetToolTip(this.btnVisualizar, "Visualização dos Medicamentos cadastrados.");
            toolTipAtalhos.SetToolTip(this.btnSair, "Sair do Sistema.");
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?",
               "Atenção",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button2
               ) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AtualizarDataHora()
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelData.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            sairToolStripMenuItem.PerformClick();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            cadastroToolStripMenuItem.PerformClick();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            visuToolStripMenuItem.PerformClick();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadMedicamentos frm = new frmCadMedicamentos();

            frm.ShowDialog();
        }

        private void visuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizarMedicamentos frm = new frmVisualizarMedicamentos();

            frm.ShowDialog();
        }
    }
}
