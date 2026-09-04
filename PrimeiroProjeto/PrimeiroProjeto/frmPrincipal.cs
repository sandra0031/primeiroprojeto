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
    }
}
