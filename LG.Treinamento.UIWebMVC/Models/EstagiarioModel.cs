namespace LG.Treinamento.UIWebMVC.Models
{
    public class EstagiarioModel
    {
        public int Id { get; set; }
       
        public string Nome { get; set; }
        
        public TurmaModel IdTurma { get; set; }
    }
}
