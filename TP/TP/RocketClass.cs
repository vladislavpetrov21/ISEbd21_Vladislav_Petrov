using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class RocketClass
    {
        public RocketCount Count { private set; get; }
        public Color PrimaryColor { private set; get; }
        public Color SecondaryColor { private set; get; }
        public float globalPosX;
        public float globalPosY;
        public RocketClass(RocketCount rocketCount, Color primaryColor, Color secondaryColor,
            float posX, float posY)
        {
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
            Count = rocketCount;
            globalPosX = posX;
            globalPosY = posY + 7;
        }      
        private int CountToInt(RocketCount rocketCount)
        {
            return (int)rocketCount + 4;
        }
        public void DrawRocket(Graphics g)
        {
            for (int i = 0; i < CountToInt(Count); i++)
            {
                Brush brush = new SolidBrush(Color.Black);
                int X = i * 10;
                int Y = i * 12;
                g.FillRectangle(brush, globalPosX + 100 - X, globalPosY - 10 + Y, 20, 10);
                g.FillRectangle(brush, globalPosX + 100 - X, globalPosY - 10 + Y, 40, 5);
                g.FillRectangle(brush, globalPosX + 100 - X, globalPosY + 100 + Y, 20, 10);
                g.FillRectangle(brush, globalPosX + 100 - X, globalPosY + 100 + Y, 40, 5);
                brush.Dispose();
            }
        }
    }
}
