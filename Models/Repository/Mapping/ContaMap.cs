using Barros.FinanceControl.Models.Entities;
using FluentNHibernate.Mapping;

namespace Barros.FinanceControl.Models.Repository.Mapping {
  
    public class ContaMap: ClassMap<Conta> {

        public ContaMap(){
            Table("conta");

            Id(c => c.Id, "id").GeneratedBy.Sequence("SEQ_CONTA_ID");
            Map(c => c.Descricao).Column("descricao").Length(100).Not.Nullable();
            Map(c => c.SaldoInicial).Column("saldoInicial");            

            //HasMany(x => x.Veiculos)
            //        .LazyLoad()
            //        .Inverse()
            //        .KeyColumn("cliente_id")
            //        .Cascade.SaveUpdate()
            //        .Fetch.Subselect()
            //        .AsList();
        }
    }   
}
