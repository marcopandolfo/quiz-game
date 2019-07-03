using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.services
{
    public class RandomNumbers
    {
        /// <summary>
        /// Retorna um numero aleatório
        /// </summary>
        /// <param name="max">Numero máximo a ser gerado</param>
        /// <returns></returns>
        public static int Random(int max)
        {
            return new Random().Next(max);
        }
    }
}
