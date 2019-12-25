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
        private T[] _places;
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
            _places = new T[sizes];
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i] = null;
            }
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
            for (int i = 0; i < a._places.Length; i++)
            {
                if (a.CheckFreePlace(i))
                {
                    a._places[i] = fly;
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
            if (index < 0 || index > a._places.Length)
            {
                return null;
            }
            if (!a.CheckFreePlace(index))            
            {
                T fly = a._places[index];
                a._places[index] = null;
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
            return _places[index] == null;
        }
        /// <summary>
        /// Метод отрисовки ангара
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                if (!CheckFreePlace(i))
                {//если место не пустое
                    _places[i].DrawFly(g);
                }
            }
        }
        /// <summary>
        /// Метод отрисовки разметки мест в ангаре
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы ангара
            g.DrawRectangle(pen, 0, 0, (_places.Length / 5) * _placeSizeWidth, 580);
            for (int i = 0; i < _places.Length / 5; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия разметки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight + 50,
                    i * _placeSizeWidth + 150, j * _placeSizeHeight + 50);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 500);
            }
        }
    }
}
