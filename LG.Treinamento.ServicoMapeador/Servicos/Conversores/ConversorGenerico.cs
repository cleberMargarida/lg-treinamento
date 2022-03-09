using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LG.Treinamento.ServicoMapeador.Servicos.Conversores
{
    public class ConversorGenerico<Tobj, Tdto>
    {
        public Tdto Converta(Tobj obj)
        {
           return JsonConvert.DeserializeObject<Tdto>(JsonConvert.SerializeObject(obj));
            
        }

        public Tobj Converta(Tdto dto )
        {
            return JsonConvert.DeserializeObject<Tobj>(JsonConvert.SerializeObject(dto));
        }
    }
}
