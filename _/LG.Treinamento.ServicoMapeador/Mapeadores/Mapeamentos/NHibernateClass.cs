using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Cfg;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg.Db;

namespace LG.Treinamento.ServicoMapeador.Mapeadores.Mapeamentos
{
    public class NHibernateClass
    {
        private static ISession session;
        private static ISessionFactory sessionFactory;
        private readonly string connectionString;

        public NHibernateClass(string stringConnection)
        {
            this.connectionString = stringConnection;
        }

        private ISessionFactory SessionFactory
        {
            get
            {
                return sessionFactory ?? (sessionFactory = Fluently.Configure()
                               .Database(MsSqlConfiguration.MsSql2012
                                                           .ConnectionString(connectionString)
                               )
                               .Mappings(
                                    m => m
                                    .FluentMappings
                                    .AddFromAssembly(Assembly.GetExecutingAssembly()
                                    ))
                               .BuildSessionFactory());
            }
        }

        public ISession Session
        {
            get
            {
                if(session == null || !session.IsOpen || !session.IsConnected)
                { 
                    session = SessionFactory.OpenSession();
                }
                return session;
            }
        }
    }
}
