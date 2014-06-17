using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Daos;
using Barros.FinanceControl.Models.Service;
using Barros.FinanceControl.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecnomotor.InjectorTestPC.Models.Repositories;

namespace Barros.FinanceControl.View {
    public partial class FormOrcamentoView : Form  {
        private OrcamentoService service;
        
        public FormOrcamentoView()  {
            InitializeComponent();

            service = new OrcamentoService(new OrcamentoDao(
                    FluentlySessionFactory.getInstanceFor(
                        UsuarioLogado.getInstance().getUsuario()).Session));

            cbxCampoSelecionado.DataSource = service.getAllProperties();
            cbxCampoSelecionado.SelectedIndex = 0;
            atualizaGrid();
        }

        private void atualizaGrid() {
            orcamentoBindingSource.DataSource = service.getAllListOrderBy(cbxCampoSelecionado.Text);
            
        }

        private Orcamento getOrcamentoSelecionado() {
            int linhaSelecionada = orcamentoDataGridView.CurrentRow.Index;
            return ((IList<Orcamento>)orcamentoBindingSource.DataSource)[linhaSelecionada];
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FormOrcamento fo = new FormOrcamento(service);
            fo.ShowDialog();
            atualizaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FormOrcamento fo = new FormOrcamento(service, getOrcamentoSelecionado());            
            fo.ShowDialog();
            atualizaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o orçamento selecionado?", "ATENÇÃO",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                service.delete(getOrcamentoSelecionado());
                atualizaGrid();
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void FormClienteView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
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
            if (txtBusca.Text.Length == 0)
            {
                atualizaGrid();
                return;
            }

            orcamentoBindingSource.DataSource = service.searchByField(cbxCampoSelecionado.Text).thisValue(txtBusca.Text);
            orcamentoDataGridView.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOrcamentoReport report = new FormOrcamentoReport(service.getOrcamentoVOList(
                                                    (IList<Orcamento>)orcamentoBindingSource.DataSource));
            report.Show();
        }

    }
}
