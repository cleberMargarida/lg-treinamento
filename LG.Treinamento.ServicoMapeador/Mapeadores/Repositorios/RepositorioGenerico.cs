using LG.Treinamento.Negocio.Interfaces;
using LG.Treinamento.Negocio.Objetos;
using LG.Treinamento.ServicoMapeador.Utilitarios;
using NHibernate;
using System;
using System.Collections.Generic;

namespace LG.Treinamento.ServicoMapeador.Mapeadores.Repositorios
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        private readonly ISession session;

        public RepositorioGenerico(ISession session)
        {
            this.session = session;
        }

        public void Create(T entidade) => Realizar(s => s.Save(entidade).ToVoid());
        
        public void Delete(T entidade) => Realizar(s => s.Delete(entidade));            
        
        public void Update(T entidade) => Realizar(s => s.Update(entidade));

        public T Get(int id) => Realizar(s => s.Get<T>(id));

        public IList<T> List()
        { 
            return session.CreateCriteria<T>().List<T>();
        }

        private void Realizar(Action<ISession> acao )
        {
            using (var transacao = session.BeginTransaction())
            {
                session.Clear();
                acao(session);
                transacao.Commit();
            }
        }

        private T Realizar(Func<ISession, T> func)
        {
            return func(session);
        }


 
    }
}