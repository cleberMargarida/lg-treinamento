using LG.Treinamento.ServicoMapeador.Mapeadores.Mapeamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.Testes.Integracao.Repositorio.Testes
{
    public class EstagiarioTesteFixture : DataBaseEmMemoria
    {
        public EstagiarioTesteFixture() : base(typeof(EstagiarioMap).Assembly)
        {
            
        }


    }
}
