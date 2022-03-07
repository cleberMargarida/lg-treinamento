using System;
using System.Collections.Generic;

namespace LG.Treinamento.ServicoMapeador.Utilitarios
{
    public static class Util
    {
        ///Metodos auxiliares

        public static int ToInt(this string param)
        {
           return int.Parse(param);
        }

        /// <summary>
        /// Itera em um objeto IEnumerable.
        /// </summary>
        /// <typeparam name="T">Tipo do Enumerable.</typeparam>
        /// <param name="source">Objeto que será iterado.</param>
        /// <param name="acao">Ação executado em cada item do Enumerable.</param>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> acao)
        {
            foreach (var item in source)
            {
                acao(item);
            }
        }
    }
}
