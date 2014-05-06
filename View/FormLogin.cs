using System;
using System.Windows.Forms;
using Barros.FinanceControl.Models.Entities;
using Tecnomotor.InjectorTestPC.Models.Repositories;
using System.Threading;

namespace Barros.FinanceControl.View {
    public partial class FormLogin : Form {        

        public FormLogin() {        
            InitializeComponent();                              
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e) {            
            Usuario usuario = new Usuario(txtLogin.Text, txtSenha.Text);
            try{
                FormAguarde formAguarde = new FormAguarde();
                UsuarioLogado.getInstance().login(usuario);
                Close();
                formAguarde.Close();
            }catch(Exception ex){
                MessageBox.Show("Usuário e/ou senha inválido!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }        

        private void FormLogin_Activated(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }

    }
}
