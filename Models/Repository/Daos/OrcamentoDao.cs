using Barros.FinanceControl.Models.Entities;
using NHibernate;

namespace Barros.FinanceControl.Models.Repository.Daos {
    
    public class OrcamentoDao : BaseCrudDao<Orcamento, int> {
        public OrcamentoDao(ISession session) : base(session) { }

        public override int getKey(Orcamento entity) {
            return entity.Id;
        }
    }
}
