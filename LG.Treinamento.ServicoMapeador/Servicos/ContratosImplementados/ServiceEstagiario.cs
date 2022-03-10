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
    public class ServiceEstagiario : IServiceEstagiario
    {
        private readonly IRepositorioGenerico<Estagiario> repositorio;
        private readonly ConversorEstagiario conversor;

        public ServiceEstagiario(IRepositorioGenerico<Estagiario> repositorio, ConversorEstagiario conversor)
        {
            this.repositorio=repositorio;
            this.conversor=conversor;
        }
        public void Create(DTOEstagiario estagiario)
        {
            var objeto = conversor.Converta(estagiario);
            repositorio.Create(objeto);
        }

        public void Delete(DTOEstagiario estagiario)
        {
            var objeto = conversor.Converta(estagiario);
            repositorio.Delete(objeto);
        }

        public IList<DTOEstagiario> GetAll()
        {
            var list = repositorio.List();
            return conversor.Converta(list);
        }

        public DTOEstagiario GetEstagiario(int id)
        {
            var resultado = repositorio.Get(id);
            return conversor.Converta(resultado);
        }

        public void Update(DTOEstagiario estagiario)
        {
            var objeto = conversor.Converta(estagiario);
            repositorio.Update(objeto);
        }
    }
}
