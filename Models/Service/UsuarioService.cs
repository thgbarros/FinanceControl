using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Daos;
using Barros.FinanceControl.Models.Repository.Interface;
using System.Collections.Generic;
using System;

namespace Barros.FinanceControl.Models.Service {
    
    public class UsuarioService : BaseCrudService<Usuario, int>  {

        private UsuarioDao dao;

        public UsuarioService(UsuarioDao dao) {
            this.dao = dao;
        }

        protected override IBaseCrudDAO<Usuario, int> getDao() {
            return this.dao;
        }

        public IList<Usuario> getAllUserFinanceControl(){            
            return getAllListOrderBy("Login");            
        }

        public void lockUser(Usuario usuario) {
            dao.lockUser(usuario);            
        }

        public void unlock(Usuario usuario) {
            dao.unLockUser(usuario);
        }        

        public override IList<Usuario> thisValue(string value) {
            DateTime b = new DateTime(2014, 01, 01);
            return dao.findByHql("from Usuario u where u.DataCriacao >= ? and "+field+" like ? order by "+field, 
                    b, "%" + value.ToUpper() + "%");
        }

        protected override IList<Usuario> getAllListOrderBy(string field, string orderBy) {
            if (!propertyIsValid(field))
                throw new ArgumentException("Propriedade inválida!");

            DateTime b = new DateTime(2014, 01, 01);
            return dao.findByHql("from Usuario u where u.DataCriacao >=? order by " + field + " " + orderBy, b);
        }
    }
}
