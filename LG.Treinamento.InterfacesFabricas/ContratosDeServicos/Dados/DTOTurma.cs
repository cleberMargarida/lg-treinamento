using System.Collections.Generic;

namespace LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados
{
    public class DTOTurma
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IList<DTOEstagiario> Estagiarios { get; set; }
    }
}
