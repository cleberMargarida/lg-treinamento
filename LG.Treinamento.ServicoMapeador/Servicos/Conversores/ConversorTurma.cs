using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados;
using LG.Treinamento.Negocio.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                
            };
        }
        public Turma Converta(DTOTurma dto)
        {
            return new Turma
            {
                Id = dto.Id,
                Nome = dto.Nome,

            };
        }
    }
}
