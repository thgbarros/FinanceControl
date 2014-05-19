using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barros.FinanceControl.Models.Entities {
    
    public class Conta {
        private IList<Transacao> transacoes = new List<Transacao>();
        private double saldo;

        public virtual int Id { get; set; }        
        public virtual string Descricao { get; set; }
        public virtual double SaldoInicial { get; set; }
        public virtual DateTime DataSaldoInicial { get; set; }
        public virtual IList<Transacao> Transacoes { 
            get {return transacoes;}
            set { transacoes = value; }
        }

        public virtual double getSaldoDoDia(DateTime dia) {
            saldo = 0;
            List<Transacao> transacoesDoDia = getTransacaoList().FindAll(c => c.Data.Equals(dia));

            foreach (Transacao transacao in transacoesDoDia)
                saldo += transacao.Valor;
            
            return saldo;
        }

        public virtual double getSaldo() {
            saldo = 0;
            foreach (Transacao transacao in transacoes)
                saldo += transacao.Valor;

            return saldo;
        }

        public virtual double getSaldoAntesDaTransacao(Transacao transacao) {
            saldo = 0;
            List<Transacao> transacoesAntesDaTransacao = getTransacaoList().FindAll(c => c.Id < transacao.Id);

            foreach (Transacao t in transacoesAntesDaTransacao)
                saldo += t.Valor;

            return SaldoInicial + saldo;
        }

        public virtual double getSaldoAposATransacao(Transacao transacao) {            
            double antesDaTransacao = getSaldoAntesDaTransacao(transacao);
            return antesDaTransacao + transacao.Valor;
        }

        public virtual double getSaldoDoPeriodo(DateTime dataInicial, DateTime dataFinal) {
            saldo = 0;
            if (dataFinal < dataInicial)
                throw new ArgumentException("Data final não pode ser menor que data inicial.");

            List<Transacao> transacoesDoPerido = getTransacaoList().FindAll(c => c.Data >= dataInicial && c.Data <= dataFinal);

            foreach (Transacao t in transacoesDoPerido)
                saldo += t.Valor;

            return SaldoInicial + saldo;
        }

        private List<Transacao> getTransacaoList() {            
            return new List<Transacao>(transacoes);
        }

        public override string ToString(){
            return Descricao;// +" R$:" + String.Format("{0:0.00}", Saldo);
        }

        public override bool Equals(object obj) {
            if (GetType() != obj.GetType())
                return false;

            Conta other = (Conta)obj;
            if (other == null)
                return false;
            else if (other.Id != this.Id)
                return false;

            return true;
        }

        public override int GetHashCode() {
            int prime = 31;
            int result = 1;
            result = prime * result + this.Id.GetHashCode();
            return result;
        }      
    }
}
