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
                Turma = conversorTurma.Converta(objeto.Turma),
                Endereco = new DTOEndereco
                {
                    Id = objeto.Endereco.Id,
                    EnderecoCompleto = objeto.Endereco.EnderecoCompleto
                }
            };
        }

        public Estagiario Converta(DTOEstagiario dto)
        {
            return new Estagiario
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Endereco = new Endereco
                {
                    Id = dto.Endereco.Id,
                    EnderecoCompleto = dto.Endereco.EnderecoCompleto
                }
            };
        }
    }
}
