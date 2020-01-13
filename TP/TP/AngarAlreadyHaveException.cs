using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    /// <summary>
    /// Класс-ошибка "Если в ангаре уже есть самолет с такими же характеристиками"
    /// </summary>
    public class AngarAlreadyHaveException : Exception
    {
        public AngarAlreadyHaveException() : base("В ангаре уже есть такой самолет")
        { }
    }
}
