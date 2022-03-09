using FluentNHibernate.Mapping;
using LG.Treinamento.Negocio.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.ServicoMapeador.Mapeadores.Mapeamentos
{
    public class PessoaMap : ClassMap<Pessoa>
    {
        public PessoaMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
        }
    }
}
