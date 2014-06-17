using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Daos;
using Barros.FinanceControl.Models.Service;
using Barros.FinanceControl.Utils;
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

    public partial class FormOrcamento : Form {

        private OrcamentoService orcamentoService;
        private Orcamento orcamentoParaAlterar;

        public FormOrcamento(OrcamentoService orcamentoService, Orcamento orcamentoParaAlterar) : this(orcamentoService){
            this.orcamentoParaAlterar = orcamentoParaAlterar;

            txtId.Text = orcamentoParaAlterar.Id.ToString();
            txtDescricao.Text = orcamentoParaAlterar.Descricao;
            txtValor.Text = CurrencyFormat.doubleToString(orcamentoParaAlterar.Valor);
            if (orcamentoParaAlterar.Categoria != null)         
                cbxCategoria.SelectedItem = orcamentoParaAlterar.Categoria;            

            if (orcamentoParaAlterar.TipoOrcamento.Equals(TipoOrcamento.ANUAL))  {
                rbTipoAno.Checked = true;
            } else {
                cbxMesSelecionado.SelectedIndex = cbxMesSelecionado.Items.IndexOf(orcamentoParaAlterar.Mes);
            }


        }

        public FormOrcamento(OrcamentoService orcamentoService) {
            InitializeComponent();            
            this.orcamentoService = orcamentoService;            

            CategoriaService categoriaService = new CategoriaService(new CategoriaDao(
                                FluentlySessionFactory.getInstanceFor(UsuarioLogado.getInstance()
                                    .getUsuario()).Session));

            cbxCategoria.DataSource = categoriaService.getAll();
            categoriaService = null;
        }

        private Orcamento getOrcamento() {
            Orcamento orcamento = orcamentoParaAlterar;
            if (orcamentoParaAlterar == null)
                orcamento = new Orcamento();

            orcamento.Descricao = txtDescricao.Text;
            orcamento.Categoria = null;
            if (cbxCategoria.Items.Count > 0 && cbxCategoria.SelectedIndex >= 0) 
                orcamento.Categoria = ((IList<Categoria>)cbxCategoria.DataSource)[cbxCategoria.SelectedIndex];
            
            if (rbTipoMes.Checked) {
                orcamento.TipoOrcamento = TipoOrcamento.MENSAL;
                orcamento.Mes = cbxMesSelecionado.Items[cbxMesSelecionado.SelectedIndex].ToString();
                orcamento.Ano = DateTime.Now.Year;
            } else {
                orcamento.TipoOrcamento = TipoOrcamento.ANUAL;
                orcamento.Ano = DateTime.Now.Year;
            }

            orcamento.Valor = Convert.ToDouble(txtValor.Text);
            return orcamento;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, System.EventArgs e)
        {
            try {
                orcamentoService.save(getOrcamento());
                btnCancelar_Click(btnGravar, null);
            } catch (InvalidOperationException ioe) {
                MessageBox.Show(ioe.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void rbTipoAno_CheckedChanged(object sender, EventArgs e)
        {
            cbxMesSelecionado.Enabled = !rbTipoAno.Checked;
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (txtValor.Text.Length > 0)
                txtValor.Text = CurrencyFormat.doubleToString(Convert.ToDouble(txtValor.Text));   
        }
    }
}
