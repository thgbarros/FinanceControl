using FluentNHibernate.Mapping;
using Barros.FinanceControl.Models.Entities;

namespace Barros.FinanceControl.Models.Repository.Mapping {
    
    public class OrcamentoMap : ClassMap<Orcamento> {

        public OrcamentoMap() {
            Table("orcamento");

            Id(c => c.Id, "id").GeneratedBy.Sequence("SEQ_ORC_ID");
            Map(c => c.Descricao).Column("descricao").Length(100).Not.Nullable();
            Map(c => c.TipoOrcamento).Column("tipo_orcamento").Not.Nullable().CustomType<int>();
            Map(c => c.Valor).Column("valor").Not.Nullable();
            Map(c => c.Mes).Column("mes");
            Map(c => c.Ano).Column("ano");
            References(c => c.Categoria)
                    .LazyLoad()
                    .Column("categoria_id")
                    .Not.Nullable()
                    .Cascade.None();                                   
        }

    }
}
