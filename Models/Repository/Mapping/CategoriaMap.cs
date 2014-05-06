﻿using FluentNHibernate.Mapping;
using Barros.FinanceControl.Models.Entities;

namespace Barros.FinanceControl.Models.Repository.Mapping {
    
    public class CategoriaMap : ClassMap<Categoria> {

        public CategoriaMap(){
            Table("categoria");

            Id(c => c.Id, "id").GeneratedBy.Sequence("SEQ_CAT_ID");
            Map(c => c.Descricao).Column("descricao").Length(100).Not.Nullable();
            References(c => c.CategoriaPai).Column("categoria_pai").Cascade.SaveUpdate();
        }

    }
}
