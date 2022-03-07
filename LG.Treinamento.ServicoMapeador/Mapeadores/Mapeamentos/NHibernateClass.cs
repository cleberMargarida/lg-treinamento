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

        private ISessionFactory SessionFactory
        {
            get
            {
                return sessionFactory ?? (sessionFactory = Fluently.Configure()
                               .Database(MsSqlConfiguration.MsSql2012
                                                           .ConnectionString(
                                                                connection =>
                                                                {
                                                                    connection.Server("localhost");
                                                                    connection.Database("Treinamento");
                                                                    connection.Username("sa");
                                                                    connection.Password("123");
                                                                })
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
                return session ?? (session = SessionFactory.OpenSession());
            }
        }
    }
}
