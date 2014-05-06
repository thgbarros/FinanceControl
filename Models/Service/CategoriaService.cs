using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Daos;
using Barros.FinanceControl.Models.Repository.Interface;
using System;
using System.Collections.Generic;

namespace Barros.FinanceControl.Models.Service {
    
    public class CategoriaService : BaseCrudService<Categoria, int> {
        private CategoriaDao dao;

        public CategoriaService(CategoriaDao dao) {
            this.dao = dao;
        }

        protected override IBaseCrudDAO<Categoria, int> getDao() {
            return this.dao;
        }

        public override IList<Categoria> thisValue(string value) {
            if (string.IsNullOrEmpty(value))
                return base.getAllListOrderBy(field);

            return dao.findByHql("from Categoria c where c." + field + " like ?", "%" + value + "%");
        }

        protected override IList<Categoria> getAllListOrderBy(string field, string orderBy) {
            if (!propertyIsValid(field))
                throw new ArgumentException("Propriedade inválida!");

            return dao.findByHql("from Categoria order by " + field + " " + orderBy);
        }

    }
}
