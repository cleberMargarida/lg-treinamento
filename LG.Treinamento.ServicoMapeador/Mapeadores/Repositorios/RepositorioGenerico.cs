using LG.Treinamento.Negocio.Interfaces;
using LG.Treinamento.Negocio.Objetos;
using NHibernate;
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

        public void Create(T entidade)
        {
            session.Save(entidade);
        }

        public void Delete(T entidade)
        {
            session.Delete(entidade);
        }

        public T Get(int id)
        {
            return session.Get<T>(id);
        }

        public IList<T> List()
        { 
            return session.CreateCriteria<T>().List<T>();
        }

        public void Update(T entidade)
        {
            session.Update(entidade);
        }
    }
}