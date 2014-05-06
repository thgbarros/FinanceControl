using System;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Mapping;

namespace Tecnomotor.InjectorTestPC.Models.Repositories {

    public class FluentlySysSessionFactory {
        private static FluentlySysSessionFactory factory;

        private ISessionFactory session;

        private FluentlySysSessionFactory(Usuario usuario) {
            string config = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)
                                (HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)
                                (SERVICE_NAME=xe)));User Id=" + usuario.Login + ";Password=" + usuario.Senha
                                                             +";DBA Privilege=SYSDBA";

            IPersistenceConfigurer configDB = OracleDataClientConfiguration.Oracle10
                //.ConnectionString(x => x.FromConnectionStringWithKey("sysSchema"))    
                                                  .ConnectionString(config)
                                                  .DefaultSchema(usuario.Login);

            var configMap = Fluently.Configure().Database(configDB)
                        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<UsuarioMap>());

            session = configMap.BuildSessionFactory();    
        }

        public ISession Session {
            get {
                return session.OpenSession();
            }
        }

        public static FluentlySysSessionFactory getInstance(Usuario usuario) {           
            if (factory != null)
                return factory;

            if (usuario == null)
                throw new ArgumentNullException("Usuário não pode ser nulo.");

            factory = new FluentlySysSessionFactory(usuario);
            return factory;           
        }

        public static void setNullInstance() {
            factory = null;
        }
    }
}
