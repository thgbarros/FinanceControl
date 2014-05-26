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

            contaBindingSource.DataSource = contaService.getAllListOrderByAsc("Descricao");
            contaService = null;
        }

        /// <summary>
        /// Atualiza o saldo no dataGrid ContasSelecionadas.
        /// </summary>
        private void atualizaSaldoContasSelecionadas() {
            double saldoTotal = 0;
            foreach (DataGridViewRow dgvr in dataGridViewContaSaldo.Rows) {
                IList<Conta> contas = ((IList<Conta>)contaBindingSource.DataSource);

                if (dgvr.Index < contas.Count) {
                    Conta conta = contas[dgvr.Index];
                    double saldoConta = conta.getSaldoDesdeOInicioAteDataAtual();                    
                    saldoTotal += saldoConta;
                }                
            }

            lblSaldoTotal.Text = CurrencyFormat.doubleToString(saldoTotal);
        }

        private void atualizaListaDeContasSelecionadas(){            
            int totalContasSelecionada = checkedListBoxConta.CheckedItems.Count;
            if (totalContasSelecionada == 0) {
                totalContasSelecionada = checkedListBoxConta.Items.Count;

                contaBindingSource.Clear();
                controller.removeTodosOsFiltrosConta();
                for (int i = 0; i < totalContasSelecionada; i++) {
                    Conta contaSelecionada = (Conta)(checkedListBoxConta.CheckedItems.Count != 0 ?
                                                        checkedListBoxConta.CheckedItems[i] :
                                                            checkedListBoxConta.Items[i]);
                    contaBindingSource.Add(contaSelecionada);
                    controller.addFiltro(contaSelecionada);
                }

            }
            
            atualizaGrid();            
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
            atualizaSaldoContasSelecionadas();           
        }

        private Transacao getTransacaoSelecionada() {
            int linhaSelecionada = transacaoDataGridView.CurrentRow.Index;
            return ((IList<Transacao>)transacaoBindingSource.DataSource)[linhaSelecionada];
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

        private void button1_Click(object sender, EventArgs e)
        {
            atualizaGrid();
        }        

        private void checkedListBoxConta_Click(object sender, EventArgs e)
        {
            atualizaListaDeContasSelecionadas();  
        }       
    }
}
