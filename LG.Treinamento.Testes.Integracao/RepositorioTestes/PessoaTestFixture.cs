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
    public class PessoaTestFixture : DataBaseEmMemoria
    {

        public PessoaTestFixture() : base(typeof(PessoaMap).Assembly)
        {

        }

        [Test]
        public void PodeSalvarEConsultarPessoa()
        {
            using (var transacao = session.BeginTransaction())
            {
                var pessoa = new Pessoa
                {
                    Nome = "Joao"
                };

                session.Save(pessoa);

                transacao.Commit();
            }


        }
    }
}
