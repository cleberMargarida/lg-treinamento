using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.Negocio.Objetos
{
    public class Estagiario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Turma Turma { get; set; }
    }
}
