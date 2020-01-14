using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    public interface IAirplane
    {
        void DrawBombs(BombsCount Count, Graphics g, Color color);
    }
}
