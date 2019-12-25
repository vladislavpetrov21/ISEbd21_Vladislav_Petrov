using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    /// <summary>
    /// Параметризованны класс для хранения набора объектов от интерфейса ISturmovic
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Angar<T> where T : class, ISturmovic
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private Dictionary<int, T> _places;
        /// <summary>
        /// Максимальное количество мест в ангаре
        /// </summary>
        private int _maxCount;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int PictureWidth { get; set; }
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int PictureHeight { get; set; }
        /// <summary>
        /// Размер места в ангаре(ширина)
        /// </summary>
        private const int _placeSizeWidth = 210;
        /// <summary>
        /// Размер места в ангаре(высота)
        /// </summary>
        private const int _placeSizeHeight = 80;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sizes">Количество мест в ангаре</param>
        /// <param name="pictureWidth">Размер ангара - ширина</param>
        /// <param name="pictureHeight">Размер ангара - высота</param>
        public Angar(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
           
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: в ангар добавляется самолет
        /// </summary>
        /// <param name="a">Ангар</param>
        /// <param name="fly">Добавляемый самолет</param>
        /// <returns></returns>
        public static int operator + (Angar<T> a, T fly)
        {
            if (a._places.Count == a._maxCount)
            {
                return -1;
            }
            for (int i = 0; i < a._maxCount; i++)
            {
                if (a.CheckFreePlace(i))
                {
                    a._places.Add(i, fly);
                    a._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5,
                     i % 5 * _placeSizeHeight + 15, a.PictureWidth,
                    a.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: из ангара забираем самолет
        /// </summary>
        /// <param name="a">Ангар</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator - (Angar<T> a, int index)
        {
            if (!a.CheckFreePlace(index))
            {
                T fly = a._places[index];
                a._places.Remove(index);
                return fly;
            }
            return null;
        }
        /// <summary>
        /// Метод проверки заполнености места в ангаре(ячейки массива)
        /// </summary>
        /// <param name="index">Номер места в ангаре(порядковый номер в массиве)</param>
        /// <returns></returns>
        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }
        /// <summary>
        /// Метод отрисовки ангара
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].DrawFly(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки мест в ангаре
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
    }
}
