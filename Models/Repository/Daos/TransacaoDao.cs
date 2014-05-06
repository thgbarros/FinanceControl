using NHibernate;
using Barros.FinanceControl.Models.Entities;

namespace Barros.FinanceControl.Models.Repository.Daos {
    
    public class TransacaoDao : BaseCrudDao<Transacao, int> {

        public TransacaoDao(ISession session) : base(session) { }

        public override int getKey(Transacao entity) {
            return entity.Id;
        }
    }
}
