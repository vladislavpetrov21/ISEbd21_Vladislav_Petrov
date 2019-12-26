using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    /// <summary>
    /// Класс-ошибка "Если на парковке уже есть самолет с такими же характеристиками"
    /// </summary>
    public class AngarAlreadyHaveException : Exception
    {
        public AngarAlreadyHaveException() : base("На парковке уже есть такой самолет")
        { }
    }
}
