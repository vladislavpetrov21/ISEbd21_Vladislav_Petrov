using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    public class RocketsClass : IAirplane
    {       
       
        public float globalPosX;
        public float globalPosY;
        public RocketsClass(float posX, float posY)
        {                      
            globalPosX = posX;
            globalPosY = posY + 7;
        }
        private int CountToInt(BombsCount bombCount)
        {
            return (int)bombCount + 1;
        }
        public void DrawBombs(BombsCount Count, Graphics g, Color SecondaryColor)
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
