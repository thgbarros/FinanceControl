using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Barros.FinanceControl.Utils;
using Barros.FinanceControl.Controller;
using Barros.FinanceControl.Models.Service;
using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Daos;
using Tecnomotor.InjectorTestPC.Models.Repositories;
using Barros.FinanceControl.Report;

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
            DateTime primeiroDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            maskedDataInicial.Text = primeiroDia.ToString("dd/MM/yyyy");
            maskedDataFinal.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbxCampoSelecionado.DataSource = transacaoService
                        .getAllPropertiesWithout("Id", "Conta", "Categoria");            
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

            lblSaldoTotal.ForeColor = Color.ForestGreen;
            if (saldoTotal < 0)
                lblSaldoTotal.ForeColor = Color.Red;

            lblSaldoTotal.Text = "R$ " + CurrencyFormat.doubleToString(saldoTotal);
        }

        private void atualizaListaDeContasSelecionadas(){
            //loadCheckedListBoxConta();
            int totalContasSelecionada = checkedListBoxConta.CheckedItems.Count;
            if (totalContasSelecionada == 0) 
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

        private void atualizaListaDeCategoriasSelecionadas() {
            //loadCheckedListBoxCategoria();
            int totalCategoriasSelecionada = checkedListBoxCategoria.CheckedItems.Count;
            if (totalCategoriasSelecionada == 0)
                totalCategoriasSelecionada = checkedListBoxCategoria.Items.Count;            
            
            controller.removeTodosOsFiltrosCategoria();
            for (int i = 0; i < totalCategoriasSelecionada; i++) {
                Categoria categoriaSelecionada = 
                                (Categoria)(checkedListBoxCategoria.CheckedItems.Count != 0 ?
                                              checkedListBoxCategoria.CheckedItems[i] :
                                                 checkedListBoxCategoria.Items[i]);
                controller.addFiltro(categoriaSelecionada);
            }
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

        private void loadCheckedListBoxCategoria() {
            CategoriaService categoriaService = new CategoriaService(new CategoriaDao(
                                FluentlySessionFactory.getInstanceFor(UsuarioLogado.getInstance()
                                    .getUsuario()).Session));            
            checkedListBoxCategoria.Items.Clear();
            checkedListBoxCategoria.Items.AddRange(
                    IListConverter<Categoria>.toList(categoriaService
                            .getAllListOrderBy("Descricao")).ToArray());            
            categoriaService = null;
        }

        private void atualizaGrid() {
            atualizaListaDeContasSelecionadas();
            atualizaListaDeCategoriasSelecionadas();
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
            loadCheckedListBoxConta();
            loadCheckedListBoxCategoria();
            atualizaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FormTransacao fu = new FormTransacao(transacaoService, getTransacaoSelecionada());
            fu.ShowDialog();
            loadCheckedListBoxConta();
            loadCheckedListBoxCategoria();
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

        private void FormTransacaoView_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrincipal.getInstance().enablePanelBotoes();
        }

        private void checkedListBoxConta_MouseUp(object sender, MouseEventArgs e)
        {
            atualizaGrid();
        }

        private void checkedListBoxCategoria_MouseUp(object sender, MouseEventArgs e)
        {
            atualizaGrid();
        }        

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length == 0) {
                atualizaGrid();
                return;
            }

            transacaoBindingSource.DataSource = transacaoService.
                        searchByField(cbxCampoSelecionado.Text).thisValue(txtBusca.Text);
            transacaoDataGridView.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            FormTransacaoReport report = new FormTransacaoReport(transacaoService.getTransacaoVOList(
                                                    (IList<Transacao>)transacaoBindingSource.DataSource));
            report.Show();
        }   
 
    }
}
