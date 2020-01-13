﻿using NLog;
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
        /// <summary>
        /// Форма для добавления
        /// </summary>
        FormFlyConfig form;
        /// <summary>
        /// Количество уровней-ангаров
        /// </summary>
        private const int countLevel = 5;
        /// <summary>
        /// Логгеры
        /// </summary>
        private Logger logger;
        private Logger error;
        public FormAngar()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            error = LogManager.GetCurrentClassLogger();
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
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeAirplaneClick(object sender, EventArgs e)
        {       
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBoxAngar.Text != "")
                {
                    try
                    {
                        var fly = angar[listBoxLevels.SelectedIndex] -
                        Convert.ToInt32(maskedTextBoxAngar.Text);                        
                        Bitmap bmp = new Bitmap(pictureBoxTakeFly.Width,
                        pictureBoxTakeFly.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        fly.SetPosition(5, 5, pictureBoxTakeFly.Width,
                        pictureBoxTakeFly.Height);
                        fly.DrawFly(gr);
                        pictureBoxTakeFly.Image = bmp;                       
                        logger.Info("Изъят самолет " + fly.ToString() + " с места "+ maskedTextBoxAngar.Text);
                        Draw();
                    }
                    catch (AngarNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakeFly.Width,
                        pictureBoxTakeFly.Height);
                        pictureBoxTakeFly.Image = bmp;
                        error.Error(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error.Error(ex.Message);
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
        /// <summary>
        /// Обработка нажатия кнопки "Добавить самолет"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetFly_Click(object sender, EventArgs e)
        {
            form = new FormFlyConfig();
            form.AddEvent(AddFly);
            form.Show();
        }
        private void AddFly(ISturmovic fly)
        {
            if (fly != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = angar[listBoxLevels.SelectedIndex] + fly;
                    if (place > -1)
                    {
                    Draw();
                    }
                    else
                    {
                    MessageBox.Show("Самолет не удалось поставить");
                    }
                }
                catch (AngarOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogAngar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {                   
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialogAngar.FileName);                   
                    MessageBox.Show("Не сохранилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
            }
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogAngar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (angar.LoadData(openFileDialogAngar.FileName))
                    {                    
                        MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }               
                }
                catch (AngarOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
                Draw();
            }
        }
    }    
}
