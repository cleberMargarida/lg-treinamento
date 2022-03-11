using FluentAssertions;
using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados;
using LG.Treinamento.Negocio.Objetos;
using LG.Treinamento.ServicoMapeador.Servicos.Conversores;
using NUnit.Framework;
using System.Collections.Generic;

namespace LG.Treinamento.Testes.Unidade
{
    public class ConversorGenericoTestFixture
    {
        [Test]
        public void TestConvertaDtoEstagiarioParaObjEstagiario()
        {
            ConversorGenerico<Turma, DTOTurma> conversor = new();

            var turma = new Turma
            {
                Id = 1,
                Nome = "Cleber",
                InformacoesComplementares = new Dictionary<string, string>
                    {
                        {"DiaInicio", "07/03"}
                    }
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

            turma.Should().Be(conversor.Converta(turma));
        }
    }
}
