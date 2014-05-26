using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Barros.FinanceControl.Models.Service;
using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Daos;
using Tecnomotor.InjectorTestPC.Models.Repositories;

namespace Barros.FinanceControl.View {
    
    public partial class FormContaView : Form {
        private ContaService contaService;

        public FormContaView() {
            InitializeComponent();
            contaService = new ContaService(new ContaDao(
                    FluentlySessionFactory.getInstanceFor(
                        UsuarioLogado.getInstance().getUsuario()).Session));
            
            cbxCampoSelecionado.DataSource = contaService
                            .getAllPropertiesWithout("Transacoes");
            cbxCampoSelecionado.SelectedIndex = 0;
//            atualizaGrid();
        }            

        private void atualizaGrid() {
            contaBindingSource.DataSource = contaService.getAllListOrderBy(cbxCampoSelecionado.Text);
        }

        private Conta getContaSelecionada() {
            int linhaSelecionada = contaDataGridView.CurrentRow.Index;
            return ((IList<Conta>)contaBindingSource.DataSource)[linhaSelecionada];            
        }

        private void FormClienteView_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FormConta fu = new FormConta(contaService);
            fu.ShowDialog();
            atualizaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FormConta fc = new FormConta(contaService, getContaSelecionada());
            fc.ShowDialog();
            atualizaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir a conta selecionada?", "ATENÇÃO", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)  {
                 contaService.delete(getContaSelecionada());
                 atualizaGrid();
            }                
                
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
       
        }

        private void FormClienteView_KeyDown(object sender, KeyEventArgs e)
        {
             switch (e.KeyCode){
                //case Keys.F1:
                 case Keys.F5:
                    btnIncluir_Click(btnIncluir, null);
                     break;
                 case Keys.F6:
                    btnAlterar_Click(btnAlterar, null);
                    break;
                 case Keys.F7:
                    btnExcluir_Click(btnExcluir, null);
                    break;
                 case Keys.F12:
                    btnVeiculos_Click(btnTransacoes, null);
                    break;
                 case Keys.Escape:
                    btnFechar_Click(btnFechar, null);
                    break;
            }
        }

        private void cbxCampoSelecionado_SelectedValueChanged(object sender, EventArgs e)
        {            
            atualizaGrid();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length == 0) {
                atualizaGrid();
                return;
            }

            contaBindingSource.DataSource = contaService.searchByField(cbxCampoSelecionado.Text).thisValue(txtBusca.Text);
            contaDataGridView.Refresh();
        }
        
    }
}
