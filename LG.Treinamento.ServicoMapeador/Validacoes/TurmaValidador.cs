using FluentValidation;
using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados;
using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Servicos;
using LG.Treinamento.ServicoMapeador.Servicos.ContratosImplementados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.ServicoMapeador.Validacoes
{
    public class TurmaValidador : AbstractValidator<DTOTurma>
    {
        private readonly IServiceTurma serviceTurma;

        public TurmaValidador(IServiceTurma serviceTurma)
        {
            this.serviceTurma = serviceTurma;

            RuleFor(x => x.Nome)
                .NotNull()
                .WithMessage("Nome deve ser preenchido.")
                .NotEmpty()
                .WithMessage("Nome deve ser preenchido.")
                .Length(3, 100)
                .WithMessage("O tamanho do nome deve ser entre 3 e 100")
                .Must(y => EhNovo(y))
                .WithMessage("Este nome já existe.");
        }

        private bool EhNovo(string nome)
        {
            return !serviceTurma.GetAll().Any(x => x.Nome == nome);
        }

    }
}
