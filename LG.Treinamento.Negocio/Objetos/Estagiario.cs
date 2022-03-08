using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.Negocio.Objetos
{
    public class Estagiario
    {
        public virtual int Id { get; set; }

        public virtual string Nome { get; set; }
        public virtual Endereco Endereco { get; set; }

        public virtual Turma Turma { get; set; }
    }
}
