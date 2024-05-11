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
    public partial class frmCadMedicamentos : Form
    {
        public frmCadMedicamentos()
        {
            InitializeComponent();

            AutoValidate = AutoValidate.Disable;

            txtCNPJ.Focus();
        }

        bool ValidateFileName()
        {
            string BarCode = txtCodigo.Text;

            if (string.IsNullOrEmpty(BarCode))
            {
                MessageBox.Show("Por favor, insira o código de barras para o nome do arquivo.");

                return false;
            }

            return true;
        }

        string GetFullPath()
        {
            return Path.Combine(
                "C:/",
                txtCodigo.Text + ".txt");
        }

        #region Click
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Por favor, corrija os erros nos campos antes de continuar.");
                return;
            }

            if (!ValidateFileName())
            {
                return;
            }

            string FullPath = GetFullPath();

            if (File.Exists(FullPath))
            {
                if (MessageBox.Show("O arquivo já existe. Deseja substituir?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    File.WriteAllText(FullPath, "CNPJ: " + txtCNPJ.Text + Environment.NewLine
                        + "Nome: " + txtNome.Text + Environment.NewLine
                        + "Código de barras: " + txtCodigo.Text + Environment.NewLine
                        + "Descrição: " + txtDescricao.Text + Environment.NewLine
                        + "Preço: " + txtPreco.Text + Environment.NewLine
                        + "Princípio ativo: " + txtPrincipio.Text + Environment.NewLine
                        + "Quantidade: " + txtQuantidade.Text + Environment.NewLine
                        );
                }
                else
                {
                    MessageBox.Show("Não foi feita nenhuma alteração no arquivo.");
                }
            }
            else
            {
                File.WriteAllText(FullPath, "CNPJ: " + txtCNPJ.Text + Environment.NewLine
                    + "Nome: " + txtNome.Text + Environment.NewLine
                    + "Código de barras: " + txtCodigo.Text + Environment.NewLine
                    + "Descrição: " + txtDescricao.Text + Environment.NewLine
                    + "Preço: " + txtPreco.Text + Environment.NewLine
                    + "Princípio ativo: " + txtPrincipio.Text + Environment.NewLine
                    + "Quantidade: " + txtQuantidade.Text + Environment.NewLine
                    );

                MessageBox.Show("Arquivo criado com sucesso!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCNPJ.Clear();
            txtNome.Clear();
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtPrincipio.Clear();
            txtQuantidade.Clear();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente descartar todas as alterações?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

        #region Validating
        private void txtCNPJ_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCNPJ.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(
                    txtCNPJ,
                    "Informe o CNPJ.");
            }
            else
            {
                if (txtCNPJ.Text.Count() != 14)
                {
                    e.Cancel = true;
                    errorProvider.SetError(
                        txtCNPJ,
                        "Informe o CNPJ com 14 dígitos.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(
                        txtCNPJ, "");
                }
            }
        }

        private void txtPrincipio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrincipio.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(
                    txtPrincipio,
                    "Digite o princípio ativo do medicamento.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(
                    txtPrincipio, "");
            }
        }

        private void txtDescricao_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(
                    txtDescricao,
                    "Informe a descrição do medicamento.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(
                    txtDescricao, "");
            }
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(
                    txtCodigo,
                    "Informe o código de barras.");
            }
            else
            {
                if (txtCodigo.Text.Count() != 13)
                {
                    e.Cancel = true;
                    errorProvider.SetError(
                        txtCodigo,
                        "Informe o código de barras com 13 dígitos.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(
                        txtCodigo, "");
                }
            }
        }
        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(
                    txtNome,
                    "Informe o nome do medicamento.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(
                    txtNome, "");
            }
        }

        private void txtQuantidade_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantidade.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(
                    txtQuantidade,
                    "Informe a quantidade do medicamento.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(
                    txtQuantidade, "");
            }
        }

        private void txtPreco_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPreco.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(
                    txtPreco,
                    "Informe o preço.");
            }
            else
            {
                float valor = float.Parse(txtPreco.Text);

                if (valor <= 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(
                        txtPreco,
                        "O preço deve ser maior que zero.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(
                        txtPreco, "");
                }
            }
        }
        #endregion

        #region KeyPress
        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) &&
                ch != 8 &&
                ch != 13)
            {

                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) &&
                ch != 8 &&
                ch != 13)
            {

                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) &&
                ch != 8 &&
                ch != 13 &&
                ch != ',')
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números e vírgulas.",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) &&
                ch != 8 &&
                ch != 13)
            {

                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        #endregion
    }
}