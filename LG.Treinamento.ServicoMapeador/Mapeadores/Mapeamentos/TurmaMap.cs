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
            Id(x => x.Id);
            Map(x => x.Nome);
            HasMany(x => x.Estagiarios).Inverse();
        }
    }
}
