using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void DefinirBoasVindas(string nome)
        {
            lblboasvindas.Text =
            "Bem-vindo, " + nome + "!";
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
      

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(
"Preencha todos os campos.",
"Atencao",
MessageBoxButtons.OK,
MessageBoxIcon.Warning);
            return;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
