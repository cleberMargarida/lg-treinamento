using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados;
using LG.Treinamento.Negocio.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.ServicoMapeador.Servicos.Conversores
{
    public class ConversorEstagiario
    {
        private ConversorTurma conversorTurma;

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
                Turma = conversorTurma.Converta(objeto.Turma)
            };
        }

        public Estagiario Converta(DTOEstagiario dto)
        {
            return new Estagiario
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Turma = conversorTurma.Converta(dto.Turma)
            };
        }
    }
}
