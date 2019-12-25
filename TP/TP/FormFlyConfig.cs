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
    public partial class FormFlyConfig : Form
    {
        /// <summary>
        /// Переменная-выбранный самолет
        /// </summary>
        ISturmovic fly = null;
        /// <summary>
        /// Событие
        /// </summary>
        private event flyDelegate eventAddFly;
        public FormFlyConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelNavy.MouseDown += panelColor_MouseDown;
            panelPurple.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelAqua.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (fly != null)
            {
                fly.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawFly();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (fly != null)
            {
                if (fly is Sturmovic)
                {
                    (fly as
                   Sturmovic).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawFly();
                }
            }
        }
        /// <summary>
        /// Отрисовать самолет
        /// </summary>
        private void DrawFly()
        {
            if (fly != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAirplane.Width, pictureBoxAirplane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                fly.SetPosition(5, 5, pictureBoxAirplane.Width, pictureBoxAirplane.Height);
                fly.DrawFly(gr);
                pictureBoxAirplane.Image = bmp;
            }
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(flyDelegate ev)
        {
            if (eventAddFly == null)
            {
                eventAddFly = new flyDelegate(ev);
            }
            else
            {
                eventAddFly += ev;
            }
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAirplane_MouseDown(object sender, MouseEventArgs e)
        {
            labelAirplane.DoDragDrop(labelAirplane.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelSturmovicr_MouseDown(object sender, MouseEventArgs e)
        {
            labelSturmovic.DoDragDrop(labelSturmovic.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelFly_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelFly_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный самолет":
                    fly = new Airplane(100, 500, Color.White);
                    break;
                case "Штурмовик":
                    fly = new Sturmovic(100, 500, Color.White, Color.Black, true, true, true);
                    break;
            }
            DrawFly();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddFly?.Invoke(fly);
            Close();
        }
    }
}
