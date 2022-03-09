using FluentAssertions;
using LG.Treinamento.Negocio.Objetos;
using LG.Treinamento.ServicoMapeador.Mapeadores.Mapeamentos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.Testes.Integracao.RepositorioTestes
{
    public class EstagiarioTurmaTestFixture : DataBaseEmMemoria
    {
        public EstagiarioTurmaTestFixture() : base(typeof(EstagiarioMap).Assembly)
        {

        }

        [Test]
        public void PodeSalvarEObterEstagiarioETurma()
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
                    Turma = turma,
                    Endereco = new Endereco
                    {
                        Lote = 1,
                        Quadra = 1,
                        Numero = "1",
                        Rua = "1",
                    }
                };

                turma.Estagiarios = new List<Estagiario> { estagiario };

                session.Save(turma);
                session.Save(estagiario);

                var estagiarioSalvo = session.Get<Estagiario>(estagiario.Id);

                estagiario.Should().Be(estagiarioSalvo);

                transacao.Commit();
            }
        }
    }
}
