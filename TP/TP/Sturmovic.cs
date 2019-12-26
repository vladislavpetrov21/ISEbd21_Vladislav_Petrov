using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class Sturmovic: Airplane
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия звезды
        /// </summary>
        public bool Star { private set; get; }
        /// <summary>
        /// Признак наличия бомб
        /// </summary>
        public bool Bomb { private set; get; }
        /// <summary>
        /// Признак наличия ракет
        /// </summary>
        public bool Rocket { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="star">Признак наличия звезды</param>
        /// <param name="bomb">Признак наличия бомб</param>
        /// <param name="rocket">Признак наличия ракет</param>
        public Sturmovic(int maxSpeed, float weight, Color mainColor, Color dopColor,
            bool star, bool bomb, bool rocket):
            base (maxSpeed, weight, mainColor)
        {         
            DopColor = dopColor;
            Star = star;
            Bomb = bomb;
            Rocket = rocket;
        }            
        /// <summary>
        /// Отрисовка самолета
        /// </summary>
        /// <param name="g"></param>
        public override void DrawFly(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            //рисуем звезду
            if (Star)
            {
                Point point1 = new Point((int)_startPosX + 85, (int)_startPosY + 60);
                Point point2 = new Point((int)_startPosX + 90, (int)_startPosY + 65);
                Point point3 = new Point((int)_startPosX + 95, (int)_startPosY + 60);
                Point point4 = new Point((int)_startPosX + 95, (int)_startPosY + 90);
                Point point5 = new Point((int)_startPosX + 90, (int)_startPosY + 85);
                Point point6 = new Point((int)_startPosX + 85, (int)_startPosY + 90);
                Point[] board = { point1, point2, point3, point4, point5, point6 };
                g.DrawPolygon(pen, board);
                Point point7 = new Point((int)_startPosX + 85, (int)_startPosY + 10);
                Point point8 = new Point((int)_startPosX + 90, (int)_startPosY + 15);
                Point point9 = new Point((int)_startPosX + 95, (int)_startPosY + 10);
                Point point10 = new Point((int)_startPosX + 95, (int)_startPosY + 40);
                Point point11 = new Point((int)_startPosX + 90, (int)_startPosY + 35);
                Point point12 = new Point((int)_startPosX + 85, (int)_startPosY + 40);
                Point[] board1 = { point7, point8, point9, point10, point11, point12 };
                g.DrawPolygon(pen, board1);
            }
            //рисуем бомбы
            if (Bomb)
            {
                g.DrawEllipse(pen, _startPosX + 90, _startPosY, 30, 10);
                Brush spoiler = new SolidBrush(DopColor);
                g.FillEllipse(spoiler, _startPosX + 90, _startPosY, 30, 10);
                g.DrawEllipse(pen, _startPosX + 90, _startPosY + 90, 30, 10);
                g.FillEllipse(spoiler, _startPosX + 90, _startPosY + 90, 30, 10);
            }
            base.DrawFly(g);
            // рисуем ракеты
            if (Rocket)
            {
                g.DrawRectangle(pen, _startPosX + 80, _startPosY + 10, 40, 10);
                Brush spoiler = new SolidBrush(DopColor);
                g.FillRectangle(spoiler, _startPosX + 80, _startPosY + 10, 40, 10);
                g.DrawRectangle(pen, _startPosX + 80, _startPosY + 80, 40, 10);
                g.FillRectangle(spoiler, _startPosX + 80, _startPosY + 80, 40, 10);
            }
        }
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;         
        }
    }
}
