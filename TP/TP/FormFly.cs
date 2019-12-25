using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class FormFly : Form
    {
        private Sturmovic fly;
        public FormFly()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxFly.Width, pictureBoxFly.Height);
            Graphics gr = Graphics.FromImage(bmp);
            fly.DrawFly(gr);
            pictureBoxFly.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            RocketCount count = RocketCount.FIVE;
            fly = new Sturmovic(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
           Color.Yellow, true, true, true,count);
            fly.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxFly.Width,
           pictureBoxFly.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    fly.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    fly.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    fly.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    fly.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
