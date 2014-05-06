using System;
using System.Windows.Forms;
using Barros.FinanceControl.Models.Service;
using Barros.FinanceControl.Models.Repository.Daos;
using Tecnomotor.InjectorTestPC.Models.Repositories;
using Barros.FinanceControl.Models.Entities;
using System.Collections.Generic;
using Barros.FinanceControl.Utils;

namespace Barros.FinanceControl.View {
    
    public partial class FormTransacaoView : Form {
        private TransacaoService transacaoService;        

        public FormTransacaoView() {
            InitializeComponent();
            transacaoService = new TransacaoService(new TransacaoDao(
                            FluentlySessionFactory.getInstanceFor(
                                UsuarioLogado.getInstance().getUsuario()).Session));
            
            cbxCampoSelecionado.DataSource = transacaoService.getAllPropertiesWithoutType(
                        typeof(Conta), typeof(Categoria));

            loadCheckedListBoxConta();
            loadCheckedListBoxCategoria();                   
            transacaoBindingSource.DataSource = transacaoService.getAllListOrderBy("Data");                        
        }

        private void FormClienteView_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
       
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FormTransacao fu = new FormTransacao();
            fu.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {            

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
  
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
                                  
                 case Keys.Escape:
                    btnFechar_Click(btnFechar, null);
                    break;
            }
        }

        private void cbxCampoSelecionado_SelectedValueChanged(object sender, EventArgs e)
        {            

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormTransacaoView_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrincipal.getInstance().enablePanelBotoes();
        }        
        
    }
}
