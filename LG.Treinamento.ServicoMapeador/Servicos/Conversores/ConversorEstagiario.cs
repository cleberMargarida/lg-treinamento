using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados;
using LG.Treinamento.Negocio.Objetos;
using System.Collections.Generic;
using System.Linq;

namespace LG.Treinamento.ServicoMapeador.Servicos.Conversores
{
    public class ConversorEstagiario
    {
        public DTOEstagiario Converta(Estagiario objeto)
        {
            if (objeto == null || objeto.Count == 0)
            {
                return null;
            }

            return new DTOEstagiario
            {
                Id = objeto.Id,
                Nome = objeto.Nome,
                Turma = ConversorTurma.ConvertaTurmaSemEstagiarios(objeto.Turma),
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
            if (dto == null || dto.Count == 0)
            {
                return null;
            }

            return new Estagiario
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Turma = ConversorTurma.ConvertaTurmaSemEstagiarios(dto.Turma),
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
            if (estagiarios == null || estagiarios.Count == 0)
            {
                return null;
            }

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
            if(estagiarios == null || estagiarios.Count == 0)
            {
                return null;
            }

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
