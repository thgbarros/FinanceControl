using Barros.FinanceControl.Models.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barros.FinanceControl.Models.Repository.Mapping {
    
    
    public class UsuarioMap : ClassMap<Usuario> {

        public UsuarioMap() {
            Table("dba_users");
            Id(u => u.Id).Column("user_id");
            Map(u => u.Login).Column("userName");
            Map(u => u.DataCriacao).Column("created");
            Map(u => u.DataBloqueio).Column("lock_date");
        }

    }
}
