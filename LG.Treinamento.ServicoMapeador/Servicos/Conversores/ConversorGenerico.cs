using System.Collections;
using System.Linq;

namespace LG.Treinamento.ServicoMapeador.Servicos.Conversores
{
    public class ConversorGenerico<TIn, TResult>
        where TIn : class, new()
        where TResult : class, new()
    {
        public TResult Converta(TIn entry)
        {
            TResult result = new();
            var entryProperties = entry.GetType().GetProperties().ToList();
            var resultProperties = result.GetType().GetProperties().ToList();

            foreach (var propertyOfEntry in entryProperties)
            {
                foreach (var propertyOfResult in resultProperties)
                {
                    if (propertyOfEntry.Name == propertyOfResult.Name &&
                        propertyOfEntry.PropertyType == propertyOfResult.PropertyType &&
                        propertyOfResult.CanWrite)
                    {
                        propertyOfResult.SetValue(result, propertyOfEntry.GetValue(entry));
                        resultProperties.Remove(propertyOfResult);
                        entryProperties.Remove(propertyOfEntry);
                        continue;
                    }

                    if (propertyOfResult.PropertyType.IsAssignableTo(typeof(IEnumerable)) &&
                        propertyOfEntry.PropertyType.IsAssignableTo(typeof(IEnumerable)))
                    {
                    }
                }
            }

            return default;
        }
    }
}
