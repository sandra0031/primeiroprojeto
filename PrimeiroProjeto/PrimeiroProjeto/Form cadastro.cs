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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email= txtEmail.Text.Trim();
            string senha= txtsenha.Text.Trim();
            if (nome == "" || email == "" || senha == "")

            {  MessageBox.Show(
                    "Preencha todos os campos.",
                    "Atencao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)
                    return;
,            

            }


        }
    }
}
