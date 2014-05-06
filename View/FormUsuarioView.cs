using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Daos;
using Barros.FinanceControl.Models.Service;
using System;
using System.Windows.Forms;
using Tecnomotor.InjectorTestPC.Models.Repositories;

namespace Barros.FinanceControl.View{
    
    public partial class FormUsuarioView : Form {
        private UsuarioService service;
        private FluentlySysSessionFactory factory;

        public FormUsuarioView() {
            InitializeComponent();
            cbxCampoSelecionado.SelectedIndex = 0;
            try {
                factory = FluentlySysSessionFactory.getInstance(UsuarioLogado.getInstance().getUsuario());
                service = new UsuarioService(new UsuarioDao(factory.Session));
                atualizaGrid();
            } catch (Exception e) {
                MessageBox.Show("Você não tem permissão de acesso a esse cadastro!", 
                            "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw e;
            }           
        }

        private Usuario getUsuarioSelecionado() {
            Usuario usuario = new Usuario();
            usuario.Login = usuarioDataGridView.CurrentRow.Cells[0].Value.ToString();
            return usuario;
        }

        private void atualizaGrid() {
            service = null;
            usuarioBindingSource.DataSource = null;
            service = new UsuarioService(new UsuarioDao(factory.Session));            
            usuarioBindingSource.DataSource = service.getAllUserFinanceControl();
            usuarioDataGridView.Refresh();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FormUsuario fu = new FormUsuario(service);
            fu.ShowDialog();
            atualizaGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClienteView_KeyDown(object sender, KeyEventArgs e)
        {
             switch (e.KeyCode){
                //case Keys.F1:
                 case Keys.F5:
                    btnIncluir_Click(btnIncluir, null);
                     break;
                 case Keys.F6:
                    btnBloquear_Click(btnBloquear, null);
                    break;
                 case Keys.F7:
                    btnDesbloquear_Click(btnDesbloquear, null);
                    break;
                 case Keys.F12:                    
                    break;
                 case Keys.Escape:
                    btnFechar_Click(btnFechar, null);
                    break;
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length == 0) {
                atualizaGrid();
                return;
            }


            usuarioBindingSource.DataSource = service.searchByField(cbxCampoSelecionado.Text).thisValue(txtBusca.Text);
            usuarioDataGridView.Refresh();
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            service.lockUser(getUsuarioSelecionado());
            MessageBox.Show("Usuário bloqueado com sucesso!", "INFORMAÇÃO", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            atualizaGrid();
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            service.unlock(getUsuarioSelecionado());
            MessageBox.Show("Usuário desbloqueado com sucesso!", "INFORMAÇÃO", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            atualizaGrid();
        }
        
    }
}
