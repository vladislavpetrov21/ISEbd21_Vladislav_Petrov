using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    /// <summary>
    /// Класс-ошибка "Если место, на которое хотим поставить самолет уже занято"
    /// </summary>
    class AngarOccupiedPlaceException : Exception
    {
        public AngarOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит самолет")
        { }
    }
}
