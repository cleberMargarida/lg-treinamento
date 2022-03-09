using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.ByteCode.Castle;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Tool.hbm2ddl;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.Testes.Integracao.RepositorioTestes
{
    public class DataBaseEmMemoria : System.IDisposable
    {
        protected ISession session;
        private ISessionFactory sessionFactory;
        private Configuration configurationHibernate;

        public DataBaseEmMemoria(Assembly assemblyContendoMapeamento)
        {
            configurationHibernate = new Configuration()
                    .SetProperty(Environment.ReleaseConnections, "on_close")
                    .SetProperty(Environment.Dialect, typeof(SQLiteDialect).AssemblyQualifiedName)
                    .SetProperty(Environment.ConnectionDriver, typeof(SQLite20Driver).AssemblyQualifiedName)
                    .SetProperty(Environment.ConnectionString, "data source=:memory:")
                    .SetProperty(Environment.ProxyFactoryFactoryClass, typeof(ProxyFactoryFactory).AssemblyQualifiedName);

            sessionFactory = sessionFactory = Fluently.Configure(configurationHibernate)
                            .Mappings(m => m.FluentMappings
                                            .AddFromAssembly(assemblyContendoMapeamento))
                                            .BuildSessionFactory();

            session = sessionFactory.OpenSession();

            new SchemaExport(configurationHibernate).Execute(true, true, false, session.Connection, System.Console.Out);
        }

        public void Dispose()
        {
            session.Dispose();
        }
    }
}
