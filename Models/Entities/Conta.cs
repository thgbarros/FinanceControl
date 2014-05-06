using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barros.FinanceControl.Models.Entities {
    
    public class Conta {
        public virtual int Id { get; set; }        
        public virtual string Descricao { get; set; }
        public virtual double SaldoInicial { get; set; }
        public virtual double Saldo { get; set; }

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
