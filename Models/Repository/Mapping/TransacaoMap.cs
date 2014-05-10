using Barros.FinanceControl.Models.Entities;
using FluentNHibernate.Mapping;

namespace Barros.FinanceControl.Models.Repository.Mapping {

    public class TransacaoMap : ClassMap<Transacao> {

        public TransacaoMap() {
            Table("transacao");

            Id(c => c.Id, "id").GeneratedBy.Sequence("SEQ_TRANS_ID");
            Map(c => c.Descricao).Column("descricao").Length(100).Not.Nullable();
            Map(c => c.Data).Column("data_transacao");
            Map(c => c.Valor).Column("valor");            
            References(c => c.Categoria).Column("categoria_id").Cascade.Merge();
            References(c => c.Conta).Column("conta_id").Cascade.Merge();
        }
    }
}
