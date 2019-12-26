using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    public class Airplane : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        protected const int carWidth = 100;
        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        protected const int carHeight = 60;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет</param>
        public Airplane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Airplane(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)       
                     {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawFly(Graphics g)
        {           
            Pen pen = new Pen(Color.Black);
            //отрисуем фюзеляж самолета
            //границы самолета
            g.DrawRectangle(pen, _startPosX, _startPosY + 40, 130, 20);
            g.DrawRectangle(pen, _startPosX + 75, _startPosY - 10, 25, 120);
            Brush brRed = new SolidBrush(MainColor);
            g.FillRectangle(brRed, _startPosX, _startPosY + 40, 130, 20);
            Brush brGreen = new SolidBrush(MainColor);
            g.FillRectangle(brGreen, _startPosX + 75, _startPosY - 10, 25, 120);
            g.DrawRectangle(pen, _startPosX + 5, _startPosY + 25, 15, 50);
            g.FillRectangle(brGreen, _startPosX + 5, _startPosY + 25, 15, 50);
            Brush brBrown = new SolidBrush(MainColor);
            g.FillEllipse(brBrown, _startPosX + 130, _startPosY + 35, 10, 30);
            g.DrawEllipse(pen, _startPosX + 130, _startPosY + 35, 10, 30);
            g.FillEllipse(brBrown, _startPosX + 95, _startPosY, 10, 30);
            g.DrawEllipse(pen, _startPosX + 95, _startPosY, 10, 30);
            g.FillEllipse(brBrown, _startPosX + 95, _startPosY + 70, 10, 30);
            g.DrawEllipse(pen, _startPosX + 95, _startPosY + 70, 10, 30);
            Brush brBlue = new SolidBrush(MainColor);
            g.FillEllipse(brBlue, _startPosX + 70, _startPosY + 42, 30, 15);
            g.DrawEllipse(pen, _startPosX + 70, _startPosY + 42, 30, 15);
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}
