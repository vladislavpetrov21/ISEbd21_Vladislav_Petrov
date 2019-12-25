using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class MultiLevelAngar
    {
        /// <summary>
        /// Список с уровнями ангара
        /// </summary>
        List<Angar<ISturmovic>> angarStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>
        private const int countPlaces = 20;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй ангара</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelAngar(int countStages, int pictureWidth, int pictureHeight)
        {
            angarStages = new List<Angar<ISturmovic>>();
            for (int i = 0; i < countStages; ++i)
            {
                angarStages.Add(new Angar<ISturmovic>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Angar<ISturmovic> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < angarStages.Count)
                {
                    return angarStages[ind];
                }
                return null;
            }
        }
    }
}
