using System.Collections.Generic;

namespace LG.Treinamento.Negocio.Objetos
{
    public class Turma
    {
        public virtual int Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Professor { get; set; }

        public virtual IList<Estagiario> Estagiarios { get; set; }

        public virtual IDictionary<string, string> InformacoesComplementares { get; set; }
    }
}