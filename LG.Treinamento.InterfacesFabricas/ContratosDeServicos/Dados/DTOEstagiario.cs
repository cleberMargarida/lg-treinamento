namespace LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados
{
    public class DTOEstagiario
    {
        public int Id { get; set; }

        public DTOEndereco Endereco { get; set; }
        public string Nome { get; set; }
        
        public DTOTurma Turma { get; set; }
    }
}
