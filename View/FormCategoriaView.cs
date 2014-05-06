using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Barros.FinanceControl;
using Barros.FinanceControl.Models.Service;
using Barros.FinanceControl.Models.Repository.Daos;
using Tecnomotor.InjectorTestPC.Models.Repositories;
using Barros.FinanceControl.Models.Entities;

namespace Barros.FinanceControl.View {
    
    public partial class FormCategoriaView : Form {
        private CategoriaService categoriaService;

        public FormCategoriaView() {
            InitializeComponent();
            categoriaService = new CategoriaService(new CategoriaDao(
                    FluentlySessionFactory.getInstanceFor(
                        UsuarioLogado.getInstance().getUsuario()).Session));

            cbxCampoSelecionado.DataSource = categoriaService.getAllProperties();
            cbxCampoSelecionado.SelectedIndex = 0;
            atualizaGrid();
        }            

        private void atualizaGrid() {
            categoriaBindingSource.DataSource = categoriaService.getAllListOrderBy(cbxCampoSelecionado.Text);
        }

        private Categoria getCategoriaSelecionada() {
            int linhaSelecionada = categoriaDataGridView.CurrentRow.Index;
            return ((IList<Categoria>)categoriaBindingSource.DataSource)[linhaSelecionada];
        }  

        private void FormClienteView_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FormCategoria fu = new FormCategoria(categoriaService);
            fu.ShowDialog();
            atualizaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FormCategoria fu = new FormCategoria(categoriaService, getCategoriaSelecionada());
            fu.ShowDialog();
            atualizaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir a categoria selecionada?", "ATENÇÃO",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                categoriaService.delete(getCategoriaSelecionada());
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

            categoriaBindingSource.DataSource = categoriaService.searchByField(cbxCampoSelecionado.Text).thisValue(txtBusca.Text);
            categoriaDataGridView.Refresh();
        }
        
    }
}
