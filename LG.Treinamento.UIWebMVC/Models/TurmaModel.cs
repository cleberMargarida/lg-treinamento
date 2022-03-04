using System.Collections.Generic;

namespace LG.Treinamento.UIWebMVC.Models
{
    public class TurmaModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IList<EstagiarioModel> Estagiarios { get; set; }
    }
}
