using Barros.FinanceControl.Models.Entities;
using System;

namespace Barros.FinanceControl.Models.Entities {
    
    public class Transacao {
        private double valor;

        public virtual int Id { get; set; }
        public virtual DateTime Data { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Conta Conta { get; set; }
        public virtual double Valor { 
            get { return valor;}
            set{
                valor = value;
                if (Categoria != null  && Categoria.TipoCategoria.Equals(TipoCategoria.DESPESA))
                    valor *= -1;
            } 
        }   

        public override string ToString(){
            return String.Format("dd/MM/yyyy", this.Data) +
                        " " + this.Descricao + " -Valor: R$" + 
                            String.Format("{0:0.00}", this.Valor);
        }

        public override bool Equals(object obj) {
            if (GetType() != obj.GetType())
                return false;

            Transacao other = (Transacao)obj;
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
