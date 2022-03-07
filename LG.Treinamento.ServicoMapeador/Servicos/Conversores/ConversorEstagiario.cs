using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados;
using LG.Treinamento.Negocio.Objetos;
using LG.Treinamento.ServicoMapeador.Utilitarios;

namespace LG.Treinamento.ServicoMapeador.Servicos.Conversores
{
    public class ConversorEstagiario
    {
        private readonly ConversorTurma conversorTurma;

        public ConversorEstagiario(ConversorTurma conversorTurma)
        {
            this.conversorTurma = conversorTurma;
        }

        public DTOEstagiario Converta(Estagiario objeto)
        {
            return new DTOEstagiario
            {
                Id = objeto.Id,
                Nome = objeto.Nome,
            };
        }

        public Estagiario Converta(DTOEstagiario dto)
        {
            return new Estagiario
            {
                Id = dto.Id,
                Nome = dto.
            };
        }
    }
}
