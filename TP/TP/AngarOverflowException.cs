using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    /// <summary>
    /// Класс-ошибка "Если в ангаре уже заняты все места"
    /// </summary>
    public class AngarOverflowException : Exception
    {
        public AngarOverflowException() : base("В ангаре нет свободных мест")
        { }
    }
}
