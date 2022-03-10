using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados;
using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Servicos;
using LG.Treinamento.Negocio.Interfaces;
using LG.Treinamento.Negocio.Objetos;
using LG.Treinamento.ServicoMapeador.Servicos.Conversores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.ServicoMapeador.Servicos.ContratosImplementados
{
    public class ServiceTurma : IServiceTurma
    {
        private readonly IRepositorioGenerico<Turma> repositorio;
        private readonly ConversorTurma conversor;

        public ServiceTurma(IRepositorioGenerico<Turma> repositorio, ConversorTurma conversor)
        {
            this.repositorio = repositorio;
            this.conversor = conversor;
        }

        public void Create(DTOTurma turma) => Acao(x => x.Create(conversor.Converta(turma)));
        public void Delete(DTOTurma turma) => Acao(x => x.Delete(conversor.Converta(turma)));
        public void Update(DTOTurma turma) => Acao(x => x.Update(conversor.Converta(turma)));

        public IList<DTOTurma> GetAll()
        {
            var list = repositorio.List();
            return conversor.Converta(list);
        }

        public DTOTurma GetTurma(int id)
        {
            var resultado = repositorio.Get(id);
            return conversor.Converta(resultado);
        }

        private void Acao(Action<IRepositorioGenerico<Turma>> acao)
        {
            acao(repositorio);
        }
    }
}
