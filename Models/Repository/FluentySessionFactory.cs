using System;
using NHibernate;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using System.Windows.Forms;
using Barros.FinanceControl.Models.Repository.Mapping;
using Barros.FinanceControl.Models.Entities;


namespace Tecnomotor.InjectorTestPC.Models.Repositories {

    public class FluentlySessionFactory {
        private static FluentlySessionFactory factory;

        private ISessionFactory session;

        private FluentlySessionFactory(Usuario usuario)  {            
            string config = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)
                                (HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)
                                (SERVICE_NAME=xe)));User Id="+usuario.Login+";Password="+usuario.Senha+";";
            
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

        public static FluentlySessionFactory getInstanceFor(Usuario usuario) {           
            if (factory != null)
                return factory;

            if (usuario == null)
                throw new ArgumentNullException("Usuário não pode ser nulo.");

            factory = new FluentlySessionFactory(usuario);
            return factory;            
        }

        public static void setNullInstance() {
            factory = null;
        }
    }
}
