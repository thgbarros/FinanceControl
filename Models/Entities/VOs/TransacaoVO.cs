using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barros.FinanceControl.Models.Entities.VOs {
    public class TransacaoVO {        
        public virtual int Id { get; set; }
        public virtual DateTime Data { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string Categoria { get; set; }
        public virtual string Conta { get; set; }
        public virtual double Valor { get; set; }

        public TransacaoVO(int id, DateTime data, string descricao, string categoria, string conta, double valor)
        {
            this.Id = id;
            this.Data = data;
            this.Descricao = descricao;
            this.Categoria = categoria;
            this.Conta = conta;
            this.Valor = valor;
        }

    }
}
