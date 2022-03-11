using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados
{
    public class DTOEstagiario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        [NotMapped]
        public DTOEndereco Endereco { get; set; }
        public DTOTurma Turma { get; set; }
    }
}
