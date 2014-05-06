using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barros.FinanceControl.Models.Entities {
    
    [Serializable]
    public class Categoria {

        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Categoria CategoriaPai { get; set; }        

        public override string ToString(){                 
            return (CategoriaPai != null ? 
                        CategoriaPai.ToString() +"->" +  this.Descricao : 
                            this.Descricao);     
        }

        public override bool Equals(object obj) {
            if (GetType() != obj.GetType())
                return false;

            Categoria other = (Categoria)obj;
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
