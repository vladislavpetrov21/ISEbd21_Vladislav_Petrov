using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class MultiLevelAngar
    {
        /// <summary>
        /// Список с уровнями ангара
        /// </summary>
        List<Angar<ISturmovic>> parkingStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>
        private const int countPlaces = 20;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>      
        private int pictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй ангара</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelAngar(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Angar<ISturmovic>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Angar<ISturmovic>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Angar<ISturmovic> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        /// <summary>
        /// Сохранение информации по самолетам в ангарах в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLevels:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var fly = level[i];
                        if (fly != null)
                        {
                            if (fly.GetType().Name == "Airplane")
                            {
                                sw.WriteLine(i + ":Airplane:" + fly);
                            }
                            if (fly.GetType().Name == "Sturmovic")
                            {
                                sw.WriteLine(i + ":Sturmovic:" + fly);
                            }
                        }
                    }
                }
            }
            return true;
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            int counter = -1;
            ISturmovic fly = null;
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                int count;
                bool isValid = line.Contains("CountLevels");
                if (isValid)
                {
                    count = Convert.ToInt32(line.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Angar<ISturmovic>>(count);
                }
                else
                {
                    return false;
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Angar<ISturmovic>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] splitLine = line.Split(':');
                    if (splitLine.Length > 2)
                    {
                        if (splitLine[1] == "Airplane")
                        {
                            fly = new Airplane(splitLine[2]);
                        }
                        else
                        {
                            fly = new Sturmovic(splitLine[2]);
                        }
                        parkingStages[counter][Convert.ToInt32(splitLine[0])] = fly;
                    }
                }
                return true;
            }
        }
    }
}
