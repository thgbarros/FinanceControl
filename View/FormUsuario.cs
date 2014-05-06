using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Service;
using System.Windows.Forms;

namespace Barros.FinanceControl.View
{
    public partial class FormUsuario : Form {
        private UsuarioService service;

        public FormUsuario(UsuarioService service) {
            InitializeComponent();
            this.service = service;
        }

        private Usuario getUsuario() {
            Usuario usuario = new Usuario(txtLogin.Text, txtSenha.Text);           
            return usuario;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, System.EventArgs e)
        {           
            btnCancelar_Click(btnGravar, null);
        }

        private void btnGravar_Click_1(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtSenha.Text))
                MessageBox.Show("Login e/ou senha não informado", "ERROR", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            service.save(getUsuario());            
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
