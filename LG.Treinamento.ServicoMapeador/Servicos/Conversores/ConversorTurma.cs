using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados;
using LG.Treinamento.Negocio.Objetos;
using System.Linq;

namespace LG.Treinamento.ServicoMapeador.Servicos.Conversores
{
    public class ConversorTurma
    {
        public DTOTurma Converta(Turma objeto)
        {
            return new DTOTurma
            {
                Id = objeto.Id,
                Nome = objeto.Nome,
                Estagiarios = objeto.Estagiarios.Select(dto => new DTOEstagiario { Id = dto.Id, Nome = dto.Nome })
                                             .ToList()
            };
        }
        public Turma Converta(DTOTurma dto)
        {
            return new Turma
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Estagiarios = dto.Estagiarios.Select(dto => new Estagiario { Id = dto.Id, Nome = dto.Nome})
                                             .ToList()
            };
        }
    }
}
