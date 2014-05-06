using System;
using Barros.FinanceControl.Utils;

namespace Barros.FinanceControl.Models.Entities {

    [Serializable]        
    public class Usuario {        
        public Usuario() { }
        public Usuario(string login, string senha) {
            this.Login = login;
            this.Senha = senha;
            this.Id = 0;
        }

        public virtual int Id { get; set; }
        public virtual DateTime DataCriacao { get; set; }
        public virtual DateTime DataBloqueio { get; set; }
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }               

        public override string ToString() {
            return this.Login;
        }

        public override bool Equals(object obj)  {
            if (GetType() != obj.GetType())
                return false;

            Usuario other = (Usuario)obj;            
            if (other == null)
                return false;          
              
            else if (other.Id != this.Id)
                return false;

            return true;
        }

        public override int GetHashCode() {
            int prime = 31;
            int result = 1;
            result = prime * result + this.Id.GetHashCode() + this.Id.GetHashCode();
            return result;
        }      

    }
}
