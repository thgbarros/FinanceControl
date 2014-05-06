using System;
using System.Collections.Generic;
using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Daos;
using Barros.FinanceControl.Models.Repository.Interface;

namespace Barros.FinanceControl.Models.Service {
    
    public class ContaService : BaseCrudService<Conta, int> {
        private ContaDao dao;

        public ContaService(ContaDao dao) {
            this.dao = dao;
        }

        protected override IBaseCrudDAO<Conta, int> getDao() {
            return this.dao;
        }

        public override IList<Conta> thisValue(string value) {
            if (string.IsNullOrEmpty(value))
                return base.getAllListOrderBy(field);

            return dao.findByHql("from Conta c where c." + field + " like ?", "%" + value + "%");
        }

        protected override IList<Conta> getAllListOrderBy(string field, string orderBy) {
            if (!propertyIsValid(field))
                throw new ArgumentException("Propriedade inválida!");

            return dao.findByHql("from Conta order by " + field +" "+ orderBy);
        }
    }
}
