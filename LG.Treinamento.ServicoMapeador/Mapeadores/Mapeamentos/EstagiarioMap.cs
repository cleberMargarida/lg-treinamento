using FluentNHibernate.Mapping;
using LG.Treinamento.Negocio.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.ServicoMapeador.Mapeadores.Mapeamentos
{
    public class EstagiarioMap : ClassMap<Estagiario>
    {
        public EstagiarioMap()
        {
            Table("estagiario");
            Id(x => x.Id);
            Map(x => x.Nome);
            Component(x => x.Endereco, y => 
            {
                y.Map(end => end.Id, "enderecoid");
                y.Map(end => end.EnderecoCompleto, "enderecoCompleto");
            });
            References(x => x.Turma, "idTurma");

            //HasManyToMany();
            //HasOne

        }
    }
}
