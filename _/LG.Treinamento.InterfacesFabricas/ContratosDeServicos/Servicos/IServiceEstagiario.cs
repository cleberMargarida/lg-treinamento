using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Servicos
{
    public interface IServiceEstagiario
    {
        public DTOEstagiario GetEstagiario(int id);
        public void Create(DTOEstagiario turma);
        public void Update(DTOEstagiario turma);
        public void Delete(DTOEstagiario turma);
        public IList<DTOEstagiario> GetAll();
    }
}
