using NHibernate;
using Barros.FinanceControl.Models.Entities;

namespace Barros.FinanceControl.Models.Repository.Daos {

    public class ContaDao : BaseCrudDao<Conta, int> {

        public ContaDao(ISession session) : base(session) { }

        public override int getKey(Conta entity) {
            return entity.Id;
        }
    }
}
