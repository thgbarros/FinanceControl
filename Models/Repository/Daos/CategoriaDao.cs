using NHibernate;
using Barros.FinanceControl.Models.Entities;

namespace Barros.FinanceControl.Models.Repository.Daos {

    public class CategoriaDao : BaseCrudDao<Categoria, int> {
        
        public CategoriaDao(ISession session) : base(session) { }

        public override int getKey(Categoria entity) {
            return entity.Id;
        }

    }
}
