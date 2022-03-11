using FluentNHibernate.Mapping;
using LG.Treinamento.Negocio.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.ServicoMapeador.Mapeadores.Mapeamentos
{
    public class TurmaMap : ClassMap<Turma>
    {
        public TurmaMap()
        {
            Table("Turma");
            Id(x => x.Id, "id").GeneratedBy.Increment();
            Map(x => x.Nome);
            HasMany(x => x.Estagiarios);
            HasMany(x => x.InformacoesComplementares)
                .KeyColumn("idTurma")
                .AsMap<string>("chave")
                .Element("valor");
            Join("Professor",
                x =>
                {
                    x.KeyColumn("idTurma");
                    x.Map(y => y.Professor, "nome");
                    x.Optional();
                });
        }
    }
}
