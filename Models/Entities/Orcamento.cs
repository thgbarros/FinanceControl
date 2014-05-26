
namespace Barros.FinanceControl.Models.Entities {
    
    public enum TipoOrcamento{
        MENSAL, ANUAL
    }

    public class Orcamento {

        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual TipoOrcamento TipoOrcamento { get; set; }
        public virtual int Mes { get; set; }
        public virtual int Ano { get; set; }
        public virtual double Valor { get; set; }

        public override string ToString() {
            return Descricao;
        }

        public override bool Equals(object obj) {
            if (GetType() != obj.GetType())
                return false;

            Orcamento other = (Orcamento)obj;
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
