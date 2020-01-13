using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    /// <summary>
    /// Класс-ошибка "Если не найден самолет по определенному месту"
    /// </summary>
    public class AngarNotFoundException : Exception
    {
        public AngarNotFoundException(int i) : base("Не найден самолет по месту "+ i)
        { }
    }
}
