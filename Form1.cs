using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr1
{
    public partial class Form1 : Form
    {
        //создаем экземпляр магазина
        Shop shop = new Shop();
        Playlist playlist = new Playlist();

        //объявляем переменную для хранения текущего продукта
        Product product;

        public Form1()
        {
            InitializeComponent();
        }

        //добавление продукта
        private void addButton_Click(object sender, EventArgs e)
        {
            //проверяем, корректно ли введены цена и количество товара

            if (decimal.TryParse(priceNumericUpDown.Text, out decimal bbd) && int.TryParse(countNumericUpDown.Text, out int bbi) && bbi > 0)
            {
                //создаем новый продукт в магазине с заданным названием, ценой и количеством
                shop.CreateProduct($"{nameTextBox.Text}", decimal.Parse(priceNumericUpDown.Text), int.Parse(countNumericUpDown.Text));
                //обновляем список всех продуктов
                shop.WriteAllProducts(getProductsListBox);
            }
            else
            {
                //если некорректный ввод - ошибка
                MessageBox.Show("Данные введены не верно", "Ошоибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //добавление в корзину
        private void addBoxButton_Click(object sender, EventArgs e)
        {
            //ищем продукт по имени
            product = shop.FindByName($"{searchTextBox.Text}");
            //добавляем продукт в коробку и обновляем вывод суммы покупки
            shop.CreateProductBox(product, prices); 

            shop.WriteAllProductsBox(boxListBox);//обновляем список товаров в корзине на выводе
            shop.WriteAllProducts(getProductsListBox);//обновляем список всех продуктов на выводе
        }

        //очищение корзины
        private void clearButton_Click(object sender, EventArgs e)
        {
            //очищаем список товаров в коробке
            boxListBox.Items.Clear();
            //сбрасываем текст лейбл до 0
            prices.Text = "0";
            //очищаем содержимое коробки в магазине
            shop.ClearBox(); 
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            //очищаем список покупок перед новой покупкой
            historyListBox.Items.Clear();
            //ищем продукт по имени
            product = shop.FindByName($"{searchTextBox.Text}");
            //покупка товара
            shop.Sell(product, historyListBox);

            //обновляем список всех продуктов на выводе
            shop.WriteAllProducts(getProductsListBox);
            //обновляем информацию о прибыли
            shop.GetProfit(profit);

            //очищаем корзину после продажи
            shop.ClearBox();
            //очищаем список товаров в коробке
            boxListBox.Items.Clear();
            //сбрасываем текст метки цен до 0
            prices.Text = "0";
        }

        //добавление песни
        private void addSongButton_Click(object sender, EventArgs e)
        {
            if (authorTextBox.Text != "" && filenameTextBox.Text != "" && titleTextBox.Text != "")
            {
                //создаем новый песню в плейлисте с заданным автором, названием и путем до файла
                playlist.Add(authorTextBox.Text, titleTextBox.Text, filenameTextBox.Text);
                //обновляем песню в плейлисте
                authorLabel.Text = authorTextBox.Text;
                filenameLabel.Text = filenameTextBox.Text;
                titleLabel.Text = titleTextBox.Text;
            }
            else
            {
                //если некорректный ввод - ошибка
                MessageBox.Show("Данные введены не верно", "Ошоибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //переход к прошлой песне
        private void lastButton_Click(object sender, EventArgs e)
        {
            //если поля не пустые
            if (authorLabel.Text != "" && titleLabel.Text != "" && filenameLabel.Text != "")
            {
                Song song = new Song(authorLabel.Text, titleLabel.Text, filenameLabel.Text);
                //находим индекс текущей песни
                playlist.Number(song);
                //переход к прошлой песне
                song = playlist.Last();

                //обновляем песню в плейлисте
                authorLabel.Text = song.author;
                filenameLabel.Text = song.filename;
                titleLabel.Text = song.title;
            }
        }

        //переход к следующей песнe
        private void nextButton_Click(object sender, EventArgs e)
        {
            //если поля не пустые
            if (authorLabel.Text != "" && titleLabel.Text != "" && filenameLabel.Text != "")
            {
                Song song = new Song(authorLabel.Text, titleLabel.Text, filenameLabel.Text);
                //находим индекс текущей песни
                playlist.Number(song);
                //переход к следующей песни
                song = playlist.Next();

                //обновляем песню в плейлисте
                authorLabel.Text = song.author;
                filenameLabel.Text = song.filename;
                titleLabel.Text = song.title;
            }
        }

        //переход к песне по индексу
        private void indexButton_Click(object sender, EventArgs e)
        {
            //если индекс введен верно
            if (playlist.bbIndex(Convert.ToInt32(numericUpDown1.Text)) == true)
            {
                Song song = new Song();
                //переход к песне по индексу
                song = playlist.Index(Convert.ToInt32(numericUpDown1.Text));
                //обновляем песню в плейлисте
                authorLabel.Text = song.author;
                filenameLabel.Text = song.filename;
                titleLabel.Text = song.title;
            }
            //cообщение что индекс введен неверно
            else MessageBox.Show("Нет такого элемента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //если индекс введен верно
            if (playlist.bbIndex() == true)
            {
                Song song = new Song();
                song = playlist.Start();
                //обновляем песню в плейлисте
                authorLabel.Text = song.author;
                filenameLabel.Text = song.filename;
                titleLabel.Text = song.title;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Song song = new Song();
            playlist.Remove(Convert.ToInt32(numericUpDown1.Text));
            song = playlist.Start();
            //обновляем песню в плейлисте
            authorLabel.Text = song.author;
            filenameLabel.Text = song.filename;
            titleLabel.Text = song.title;
        }

        private void overloadRemoveButton_Click(object sender, EventArgs e)
        {
            Song song = new Song(authorTextBox.Text, titleTextBox.Text, filenameTextBox.Text);
            playlist.Remove(song);
            song = playlist.Start();
            //обновляем песню в плейлисте
            authorLabel.Text = song.author;
            filenameLabel.Text = song.filename;
            titleLabel.Text = song.title;
        }

        private void clearButton1_Click(object sender, EventArgs e)
        {
            Song song = new Song();
            playlist.Clear();
            song = playlist.Start();
            //обновляем песню в плейлисте
            authorLabel.Text = song.author;
            filenameLabel.Text = song.filename;
            titleLabel.Text = song.title;

        }
    }
}
