using LG.Treinamento.Negocio.Objetos;
using LG.Treinamento.ServicoMapeador.Mapeadores.Mapeamentos;
using NUnit.Framework;
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

        [Test]
        public void PodeSalvarEstagiario()
        {
            using (var transacao = session.BeginTransaction())
            {
                var turma = new Turma
                {
                    Id = 1,
                    Nome = "Cleber",
                };
                var estagiario = new Estagiario
                {
                    Id = 1,
                    Nome = "Marcos",
                    Turma = turma
                };

                turma.Estagiarios = new List<Estagiario> { estagiario };

                session.Save(turma);
                session.Save(estagiario);
                transacao.Commit();

            }
        }


    }
}
