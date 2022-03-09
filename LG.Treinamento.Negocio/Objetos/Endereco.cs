using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.Treinamento.Negocio.Objetos
{
    public class Endereco
    {
        public virtual string Rua { get; set; }
        public virtual int Quadra { get; set; }
        public virtual int Lote { get; set; }
        public virtual string Numero { get; set; }
    }
}
