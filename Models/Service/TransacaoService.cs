using System;
using System.Collections.Generic;
using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Daos;
using Barros.FinanceControl.Models.Repository.Interface;


namespace Barros.FinanceControl.Models.Service {
    
    public class TransacaoService : BaseCrudService<Transacao, int> {
        private TransacaoDao dao;

        public TransacaoService(TransacaoDao dao) {
            this.dao = dao;
        }

        protected override IBaseCrudDAO<Transacao, int> getDao() {
            return this.dao;
        }

        public override IList<Transacao> thisValue(string value) {
            if (string.IsNullOrEmpty(value))
                return base.getAllListOrderBy(field);

            return dao.findByHql("from Transacao c where c." + field + " like ?", "%" + value + "%");
        }

        protected override IList<Transacao> getAllListOrderBy(string field, string orderBy) {
            if (!propertyIsValid(field))
                throw new ArgumentException("Propriedade inválida!");

            return dao.findByHql("from Transacao order by " + field + " " + orderBy);
        }

        public IList<Transacao> getAllListUntilDate(DateTime date) {
            return dao.findByHql("from Transacao t where t.Data <= ? order by t.Data", date);
        }
    }
}
