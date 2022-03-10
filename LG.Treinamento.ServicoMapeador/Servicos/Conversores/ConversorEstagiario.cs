using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados;
using LG.Treinamento.Negocio.Objetos;
using System.Collections.Generic;
using System.Linq;

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
                    Lote = objeto.Endereco.Lote,
                    Quadra = objeto.Endereco.Quadra,
                    Rua = objeto.Endereco.Rua,
                    Numero = objeto.Endereco.Numero
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
                    Lote = dto.Endereco.Lote,
                    Quadra = dto.Endereco.Quadra,
                    Rua = dto.Endereco.Rua,
                    Numero = dto.Endereco.Numero
                }
            };
        }

        public IList<Estagiario> Converta(IList<DTOEstagiario> estagiarios)
        {
            return estagiarios.Select(estagiario => new Estagiario
            {
                Nome = estagiario.Nome,
                Id = estagiario.Id,
                Endereco = new Endereco
                {
                    Lote = estagiario.Endereco.Lote,
                    Numero = estagiario.Endereco.Numero,
                    Quadra = estagiario.Endereco.Quadra,
                    Rua = estagiario.Endereco.Rua
                },
                Turma = new Turma
                {
                    Id = estagiario.Turma.Id,
                    Nome = estagiario.Turma.Nome
                }
            }).ToList();
        }

        public IList<DTOEstagiario> Converta(IList<Estagiario> estagiarios)
        {
            return estagiarios.Select(estagiario => new DTOEstagiario
            {
                Nome = estagiario.Nome,
                Id = estagiario.Id,
                Endereco = new DTOEndereco
                {
                    Lote = estagiario.Endereco.Lote,
                    Numero = estagiario.Endereco.Numero,
                    Quadra = estagiario.Endereco.Quadra,
                    Rua = estagiario.Endereco.Rua
                },
                Turma = new DTOTurma
                {
                    Id = estagiario.Turma.Id,
                    Nome = estagiario.Turma.Nome
                }
            }).ToList();
        }
    }
}
