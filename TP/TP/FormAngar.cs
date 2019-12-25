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
        MultiLevelAngar angar;
        private const int countLevel = 5;
        public FormAngar()
        {
            InitializeComponent();
            angar = new MultiLevelAngar(countLevel, pictureBoxAngar.Width,
            pictureBoxAngar.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        /// <summary>
        /// Метод отрисовки ангара
        /// </summary>
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункте будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxAngar.Width,
                pictureBoxAngar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                angar[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxAngar.Image = bmp;
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Загнать самолет"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetFlyClick(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var fly = new Airplane(100, 1000, dialog.Color);
                    int place = angar[listBoxLevels.SelectedIndex] + fly;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Загнать штурмовик"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetSturmovicClick(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var fly = new Sturmovic(100, 1000, dialog.Color,
                       dialogDop.Color, true, true, true);
                        int place = angar[listBoxLevels.SelectedIndex] + fly;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
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
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (listBoxLevels.SelectedIndex > -1)
                {
                    if (maskedTextBoxAngar.Text != "")
                    {
                        var fly = angar[listBoxLevels.SelectedIndex] -
                       Convert.ToInt32(maskedTextBoxAngar.Text);
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
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }    
}
