using Barros.FinanceControl.Models.Entities;
using FluentNHibernate.Mapping;

namespace Barros.FinanceControl.Models.Repository.Mapping {
  
    public class ContaMap: ClassMap<Conta> {

        public ContaMap(){
            Table("conta");

            Id(c => c.Id, "id").GeneratedBy.Sequence("SEQ_CONTA_ID");
            Map(c => c.Descricao).Column("descricao").Length(100).Not.Nullable();
            Map(c => c.SaldoInicial).Column("saldoInicial");
            Map(c => c.DataSaldoInicial).Column("dataSaldoInicial");

            HasMany(x => x.Transacoes)
                    .LazyLoad()                    
                    .KeyColumn("conta_id")
            //        .Cascade.SaveUpdate()                    
                    .AsBag();
        }
    }   
}
