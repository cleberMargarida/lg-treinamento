using System.ComponentModel.DataAnnotations;

namespace LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados
{
    public class DTOEndereco
    {
        [Key]
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Quadra { get; set; }
        public int Lote { get; set; }
        public string Numero { get; set; }
    }
}
