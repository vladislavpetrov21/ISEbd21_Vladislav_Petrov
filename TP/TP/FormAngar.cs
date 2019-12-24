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
    public partial class FormAngar : Form
    {
        /// <summary>
        /// Объект от класса-ангара
        /// </summary>
        Angar<ISturmovic> angar;
        public FormAngar()
        {
            InitializeComponent();
            angar = new Angar<ISturmovic>(20, pictureBoxAngar.Width,
            pictureBoxAngar.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки ангара
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAngar.Width, pictureBoxAngar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            angar.Draw(gr);
            pictureBoxAngar.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Загнать самолет"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetFlyClick(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fly = new Airplane(100, 1000, dialog.Color);
                int place = angar + fly;
                Draw();
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Загнать штурмовик"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetSturmovicClick(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var fly = new Sturmovic(100, 1000, dialog.Color, dialogDop.Color,
                   true, true, true);
                    int place = angar + fly;
                    Draw();
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeAirplaneClick(object sender, EventArgs e)
        {
            if (maskedTextBoxAngar.Text != "")
            {
                var fly = angar - Convert.ToInt32(maskedTextBoxAngar.Text);
                if (fly != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeFly.Width,
                   pictureBoxTakeFly.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    fly.SetPosition(5, 5, pictureBoxTakeFly.Width,
                   pictureBoxTakeFly.Height);
                    fly.DrawFly(gr);
                    pictureBoxTakeFly.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeFly.Width,
                   pictureBoxTakeFly.Height);
                    pictureBoxTakeFly.Image = bmp;
                }
                Draw();
            }
        }
    }
}
