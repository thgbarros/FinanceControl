using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Daos;
using Barros.FinanceControl.Models.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tecnomotor.InjectorTestPC.Models.Repositories;

namespace Barros.FinanceControl.View
{
    public partial class FormTransacao : Form {
        private TransacaoService service;
        private Transacao transacao;

        public FormTransacao(TransacaoService service) {
            InitializeComponent();
            maskedData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.service = service;

            //ContaService contaService = new ContaService(new ContaDao(
            //                    FluentlySessionFactory.getInstanceFor(UsuarioLogado.getInstance()
            //                        .getUsuario()).Session));

            //CategoriaService categoriaService = new CategoriaService(new CategoriaDao(
            //                    FluentlySessionFactory.getInstanceFor(UsuarioLogado.getInstance()
            //                        .getUsuario()).Session));

            //cbxCategoria.DataSource = categoriaService.getAll();
            //cbxConta.DataSource = contaService.getAll();
            //categoriaService = null;
            //contaService = null;
        }

        public FormTransacao(TransacaoService service, Transacao transacao) : this(service) {            
            cbxCategoria.SelectedItem = transacao.Categoria;
            cbxConta.SelectedItem = transacao.Conta;
            maskedData.Text = transacao.Data.ToString("dd/MM/yyyy");
            txtDescricao.Text = transacao.Descricao;            
            txtValor.Text = formatValor(transacao.Valor);
            this.transacao = transacao;
        }

        private String formatValor(double valor){
            try {
                return String.Format("{0:n}", valor);
            } catch (FormatException fe) {
                MessageBox.Show("Valor do saldo incial inválido!", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "0,00";
            }
        }

        private Transacao getTransacao() {
            Transacao trasacao = this.transacao;
            if (this.transacao == null)
                transacao = new Transacao();

            transacao.Data = Convert.ToDateTime(maskedData.Text);
            if (cbxConta.SelectedIndex < 0)
                throw new ArgumentException("Conta não selecionada!");
            transacao.Conta = ((IList<Conta>)cbxConta.DataSource)[cbxConta.SelectedIndex];
            if (cbxCategoria.SelectedIndex < 0)
                throw new ArgumentException("Categoria não selecionada!");
            transacao.Categoria = ((IList<Categoria>)cbxCategoria.DataSource)[cbxCategoria.SelectedIndex];                
            transacao.Descricao = txtDescricao.Text;
            transacao.Valor = Convert.ToDouble(txtValor.Text);

            return transacao;
        }
 
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, System.EventArgs e)
        {
            try {
                service.save(getTransacao());
                btnCancelar_Click(null, null);
            }catch (ArgumentException ae) {
                MessageBox.Show(ae.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnCancelar_Click(btnGravar, null);
        }

        private void txtValor_Leave(object sender, System.EventArgs e)
        {
            txtValor.Text = formatValor(Convert.ToDouble(txtValor.Text));   
        }
    }
}
