using System.Collections.Generic;

namespace LG.Treinamento.Negocio.Objetos
{
    public class Turma
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IList<Estagiario> Estagiarios { get; set; }
    }
}