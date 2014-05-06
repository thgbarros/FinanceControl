using System;
using System.Windows.Forms;
using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Service;
using System.Text.RegularExpressions;

namespace Barros.FinanceControl.View
{
    public partial class FormConta : Form {
        private ContaService contaService;
        private Conta contaParaAlterar;

        public FormConta(ContaService contaService, Conta conta) : this(contaService){
            this.contaParaAlterar = conta;

            txtId.Text = conta.Id.ToString();
            txtDescricao.Text = conta.Descricao;
            txtSaldo.Text = formatSaldo(conta.SaldoInicial);
        }

        private String formatSaldo(double saldo) { 
            try {
                return String.Format("{0:n}", saldo);
            } catch (FormatException fe) {
                MessageBox.Show("Valor do saldo incial inválido!", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "0,00";
            }
        }

        public FormConta(ContaService contaService){
            InitializeComponent();
            this.contaService = contaService;
        }

        private Conta getConta() {
            Conta conta = contaParaAlterar;
            if (contaParaAlterar == null)
                conta = new Conta();

            conta.Descricao = txtDescricao.Text;
            conta.SaldoInicial = Convert.ToDouble(txtSaldo.Text);
            
            return conta;            
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try {
                contaService.save(getConta());
                btnCancelar_Click(null, null);
            } catch (FormatException fe) {
                MessageBox.Show("Saldo incial não informado!", "ERROR", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSaldo_Leave(object sender, EventArgs e)
        {
            txtSaldo.Text = formatSaldo(Convert.ToDouble(txtSaldo.Text));           
        }

    }
}
