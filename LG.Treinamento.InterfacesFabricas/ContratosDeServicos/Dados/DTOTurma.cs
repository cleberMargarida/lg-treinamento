using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados
{
    public class DTOTurma
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public IList<DTOEstagiario> Estagiarios { get; set; }
        public string Professor { get; set; }

        [NotMapped]
        public IDictionary<string, string> InformacoesComplementares { get; set; }
    }
}
