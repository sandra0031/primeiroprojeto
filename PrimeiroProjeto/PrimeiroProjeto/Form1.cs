using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class Form1 : Form
    {  
      public static string NomeCadastrado = "";
      public static string EmailCadastrado = "sandramalta@teste.com";
      public static string SenhaCadastrada = "1234";

        public Form1()
        {
            InitializeComponent();

            this.Resize += (s, e) => CentralizarPainel();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlEntrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CentralizarPainel()
        {
            pnlEntrar.Left = (this.ClientSize.Width - pnlEntrar.Width) / 2;
            pnlEntrar.Top = (this.ClientSize.Height - pnlEntrar.Height) / 2;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            string senha = txtSenha.Text;

            if (email == "" || senha == "")
            {
                MessageBox.Show(
                    "Digite o email e a senha",
                    "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }


            if (email.ToLower() == EmailCadastrado
                && senha == SenhaCadastrada)
            {
                frmPrincipal principal = new frmPrincipal();
                principal.DefinirBoasVindas(NomeCadastrado);

                principal.Show();
                this.Hide();
            }


            else
            {
                MessageBox.Show(
                    "Email ou senha incorretos.",
                    "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtSenha.Clear();
                txtSenha.Focus();
            }
        }

        private void lnkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();

            this.Hide();
            cadastro.ShowDialog();
            this.Show();

        }
    }
}
