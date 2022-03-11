using LG.Treinamento.Negocio.Objetos;
using System.Collections.Generic;

namespace LG.Treinamento.Negocio.Interfaces
{
    public interface IRepositorioGenerico<T>
    {
        void Create(T entidade);
        void Delete(T entidade);
        T Get(int id);
        IList<T> List();
        void Update(T entidade);
    }
}