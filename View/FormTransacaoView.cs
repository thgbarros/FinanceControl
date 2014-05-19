using System;
using System.Windows.Forms;
using Barros.FinanceControl.Models.Service;
using Barros.FinanceControl.Models.Repository.Daos;
using Tecnomotor.InjectorTestPC.Models.Repositories;
using Barros.FinanceControl.Models.Entities;
using System.Collections.Generic;
using Barros.FinanceControl.Utils;
using Barros.FinanceControl.Controller;

namespace Barros.FinanceControl.View {
    
    public partial class FormTransacaoView : Form {
        private TransacaoService transacaoService;
        private TransacaoController controller;
        private int indexAux = 0;

        public FormTransacaoView() {
            InitializeComponent();
            transacaoService = new TransacaoService(new TransacaoDao(
                            FluentlySessionFactory.getInstanceFor(
                                UsuarioLogado.getInstance().getUsuario()).Session));

            controller = new TransacaoController(transacaoService);                      
            loadCheckedListBoxConta();            
            loadCheckedListBoxCategoria();
            maskedDataInicial.Text = DateTime.Now.ToString("dd/MM/yyyy");
            maskedDataFinal.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbxCampoSelecionado.DataSource = transacaoService.getAllPropertiesWithoutType(
                       typeof(Conta), typeof(Categoria));
        }

        private void loadCheckedListBoxConta() {
            ContaService contaService = new ContaService(new ContaDao(
                                FluentlySessionFactory.getInstanceFor(UsuarioLogado.getInstance()
                                    .getUsuario()).Session));
            checkedListBoxConta.Items.Clear();
            checkedListBoxConta.Items.AddRange(
                    IListConverter<Conta>.toList(contaService
                            .getAllListOrderByAsc("Descricao")).ToArray());
            contaService = null;
            
        }

        private void atualizaSaldo() {
            loadCheckedListBoxConta();
            int totalContasSelecionada = checkedListBoxConta.SelectedItems.Count;
            double saldoTotal = 0;
            if (totalContasSelecionada != 0) {
                for (int i = 0; i < totalContasSelecionada; i++)
                    saldoTotal += ((Conta)checkedListBoxConta.SelectedItems[i]).getSaldo();
            } else {
                totalContasSelecionada = checkedListBoxConta.Items.Count;
                for (int i = 0; i < totalContasSelecionada; i++)
                    saldoTotal += ((Conta)checkedListBoxConta.Items[i]).getSaldo();
            }
            lblSaldoTotal.Text = CurrencyFormat.doubleToString(saldoTotal);
        }

        private void loadCheckedListBoxCategoria() {
            CategoriaService categoriaService = new CategoriaService(new CategoriaDao(
                                FluentlySessionFactory.getInstanceFor(UsuarioLogado.getInstance()
                                    .getUsuario()).Session));
            checkedListBoxCategoria.Items.AddRange(
                    IListConverter<Categoria>.toList(categoriaService
                            .getAllListOrderBy("Descricao")).ToArray());            
            categoriaService = null;
        }

        private void atualizaGrid() {
            controller.DataInicial = DateTime.Parse(maskedDataInicial.Text);
            controller.DataFinal = DateTime.Parse(maskedDataFinal.Text);
            transacaoBindingSource.DataSource = controller.getTodasTransacao();
            atualizaSaldo();
           
        }

        private Transacao getTransacaoSelecionada() {
            int linhaSelecionada = transacaoDataGridView.CurrentRow.Index;
            return ((IList<Transacao>)transacaoBindingSource.DataSource)[linhaSelecionada];
        }


        private void FormClienteView_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
       
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FormTransacao fu = new FormTransacao(transacaoService);
            fu.ShowDialog();
            atualizaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FormTransacao fu = new FormTransacao(transacaoService, getTransacaoSelecionada());
            fu.ShowDialog();
            atualizaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir a transação selecionada?", "ATENÇÃO",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                transacaoService.delete(getTransacaoSelecionada());
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

            transacaoBindingSource.DataSource = transacaoService.searchByField(cbxCampoSelecionado.Text).thisValue(txtBusca.Text);
            transacaoDataGridView.Refresh();
        }

        private void FormTransacaoView_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrincipal.getInstance().enablePanelBotoes();
        }

        private void checkedListBoxConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxConta.GetItemChecked(checkedListBoxConta.SelectedIndex) ) {
                foreach (Conta itemChecked in checkedListBoxConta.CheckedItems) {
                    controller.addFiltro(itemChecked);
                    atualizaGrid();
                }
            }
        }    
        
    }
}
