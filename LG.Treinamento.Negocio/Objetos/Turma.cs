using System.Collections.Generic;

namespace LG.Treinamento.Negocio.Objetos
{
    public class Turma
    {
        public virtual int Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual IList<Estagiario> Estagiarios { get; set; }
    }
}