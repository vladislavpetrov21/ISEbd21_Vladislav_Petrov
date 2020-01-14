using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    public class ModifiedBombs : IAirplane
    {
        public float globalPosX;
        public float globalPosY;
        public ModifiedBombs(float posX, float posY)
        {
            globalPosX = posX;
            globalPosY = posY + 7;
        }
        private int CountToInt(BombsCount bombCount)
        {
            return (int)bombCount;
        }
        public void DrawBombs(BombsCount Count, Graphics g, Color SecondaryColor)
        {
            for (int i = 0; i < CountToInt(Count); i++)
            {               
                Brush brush = new SolidBrush(Color.Red);
                int X = i * 14;
                int Y = i * 14;
                g.FillEllipse(brush, globalPosX + 90 - X, globalPosY - 20 + Y, 30, 10);             
                g.FillEllipse(brush, globalPosX + 100 - X, globalPosY - 25 + Y, 10, 20);
                g.FillEllipse(brush, globalPosX + 90 - X, globalPosY + 90 + Y, 30, 10);
                g.FillEllipse(brush, globalPosX + 100 - X, globalPosY + 85 + Y, 10, 20);
                brush.Dispose();
                Pen pen = new Pen(Color.Black);                
                g.DrawEllipse(pen, globalPosX + 90 - X, globalPosY - 20 + Y, 30, 10);
                g.DrawEllipse(pen, globalPosX + 100 - X, globalPosY - 25 + Y, 10, 20);
                g.DrawEllipse(pen, globalPosX + 90 - X, globalPosY + 90 + Y, 30, 10);
                g.DrawEllipse(pen, globalPosX + 100 - X, globalPosY + 85 + Y, 10, 20);
                pen.Dispose();
            }
        }
    }
}
