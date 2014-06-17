using System;

namespace Barros.FinanceControl.Models.Entities.VOs {
    public class TransacaoVO {        
        public virtual int Id { get; set; }
        public virtual DateTime Data { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string Categoria { get; set; }
        public virtual string Conta { get; set; }
        public virtual double ContaSaldoInicial { get; set; }
        public virtual double ContaSaldoAtual { get; set; }
        public virtual double Valor { get; set; }

        public TransacaoVO(int id, DateTime data, string descricao, string categoria, 
                string conta, double contaSaldoInicial, double contaSaldoAtual,  double valor)
        {
            this.Id = id;
            this.Data = data;
            this.Descricao = descricao;
            this.Categoria = categoria;
            this.Conta = conta;
            this.ContaSaldoInicial = contaSaldoInicial;
            this.ContaSaldoAtual = contaSaldoAtual;
            this.Valor = valor;
        }

    }
}
