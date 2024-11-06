using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pr1
{
    class Playlist
    {
        //список песен
        private List<Song> list;
        //номер текущей песни
        private int currentIndex;

        //конструктор
        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }

        // для получения текущей аудиозаписи
        public Song CurrentSong()
        {
            //если есть песни 
            if (list.Count > 0)
                //возвращаеми текущую
                return list[currentIndex];
            else
                //вывод информации что плейлист пустой
                throw new IndexOutOfRangeException(
                    "Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }

        //метод для добавления песни
        public void Add(string author, string title, string filename)
        {
            //linq-запрос для проверки есть ли уже такая песня
            if (!list.Any(p => p.title.Equals(title, StringComparison.OrdinalIgnoreCase) && p.author.Equals(author, StringComparison.OrdinalIgnoreCase)))
            {
                //добавление песни в плейлист
                list.Add(new Song(author, title, filename));
            }
            else
            {
                //сообщение об ошибке
                MessageBox.Show("Такая песня уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //перегрузка для добавления песни
        public void Add(Song song)
        {
            //linq-запрос для проверки есть ли уже такая песня
            if (!list.Any(p => p.title.Equals(song.title, StringComparison.OrdinalIgnoreCase) && p.author.Equals(song.author, StringComparison.OrdinalIgnoreCase)))
            {
                //добавление песни в плейлист
                list.Add(song);
            }
            else
            {
                //сообщение об ошибке
                MessageBox.Show("Такая песня уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //функция для перехода к следующей песне
        public Song Next()
        {
            //если номер текущего элемента меньше индекса последнего элемента списка
            if (list.Count - 1 > currentIndex)
                //возвращаем песню
                return list[currentIndex + 1];
            else
                //возвращаем первый элемент
                return list[0];
        }

        //функция для перехода к предыдущей песне
        public Song Last()
        {
            //если номер текущего элемента больше индекса первого элемента списка
            if (currentIndex > 0)
                //возвращаем песню
                return list[currentIndex - 1];
            else
                //возвращаем последний элемент
                return list[list.Count - 1];
        }

        //метод поиска индекса песни
        public void Number(Song song)
        {
            currentIndex = list.IndexOf(song);
        }

        //функция для перехода к песне по индексу
        public Song Index(int index)
        {
            //возвращаем песню
            return list[index];
        }

        //функция для перехода к начaлу
        public Song Start()
        {
            //возвращаем первый элемент
            return list[0];
        }


        //метод для удаления песни по индексу
        public void Remove(int index)
        {
            //если номер текущего элемента больше индекса первого элемента списка и индекса последнего элемента списка
            if (list.Count > index && index >= 0)
                //удаляем песню
                list.RemoveAt(index);
            else
                //сообщение что такой песни нет
                MessageBox.Show("Такой песни нет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //метод для удаления песни по индексу
        public void Remove(Song song)
        {
            //если номер текущего элемента больше индекса первого элемента списка и индекса последнего элемента списка
            if (list.Contains(song))
                //удаляем песню
                list.Remove(song);
            else
                //сообщение что такой песни нет
                MessageBox.Show("Такой песни нет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //метод для очистки
        public void Clear()
        {
           list.Clear();
        }

        //функция для проверки имеется такойц элемент
        public bool bbIndex(int index)
        {
            if (list.Count > index && index >= 0) return true;
            else return false;
        }

        //функция для проверки имеется такойц элемент
        public bool bbIndex()
        {
            if (list.Count == 0) return false;
            else return true;
        }
    }

}
