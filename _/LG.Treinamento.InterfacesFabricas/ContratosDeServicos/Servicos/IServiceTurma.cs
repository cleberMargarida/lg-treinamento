using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Servicos
{
    public interface IServiceTurma
    {
        public DTOTurma GetTurma(int id);
        public void Create(DTOTurma turma);
        public void Update(DTOTurma turma);
        public void Delete(DTOTurma turma);
        public IList<DTOTurma> GetAll();

    }
}
