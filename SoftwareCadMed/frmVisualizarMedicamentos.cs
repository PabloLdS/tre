using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediCadastro
{
    public partial class frmVisualizarMedicamentos : Form
    {
        public frmVisualizarMedicamentos()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = folderBrowserDialog.ShowDialog();

            if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                txtCaminho.Text = folderBrowserDialog.SelectedPath;
            }
        }

        bool ValidarDiretorio()
        {

            string diretorio = txtCaminho.Text;
            string nomeArquivo = txtCodigo.Text;

            if (string.IsNullOrEmpty(diretorio) ||
                string.IsNullOrEmpty(nomeArquivo))
            {
                MessageBox.Show(
                    "Pro favor, selecione um diretório e o código de barras.");

                return false;
            }

            if (!Directory.Exists(diretorio))
            {
                MessageBox.Show(
                    "O diretório especificado não existe.");

                return false;
            }

            return true;
        }

        string GetDiretorioCompleto()
        {
            return Path.Combine(
                txtCaminho.Text,
                txtCodigo.Text + ".txt");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (!ValidarDiretorio())
                return;

            string caminhoCompleto = GetDiretorioCompleto();

            if (File.Exists(caminhoCompleto))
            {
                rtbConteudo.Text =
                    File.ReadAllText(caminhoCompleto);
                MessageBox.Show("Conteúdo carregado com sucesso!");
            }
            else
            {
                MessageBox.Show("O arquivo não existe.");
            }
        }
    }
}
