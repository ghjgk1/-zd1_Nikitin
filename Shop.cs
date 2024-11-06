using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr1
{
    internal class Shop
    {
        //словарь товаров магазина
        private Dictionary<Product, int> products;
        
        //словарь добавленного в коробку
        private Dictionary<Product, int> box;

        //список истории покупок
        private List<string> buyHistory = new List<string>();

        //вспомогательныые переменные
        private decimal profit = 0;
        private decimal fullProfit = 0;

        //конструктор
        public Shop()
        {
            //инициализация словаря продуктов
            products = new Dictionary<Product, int>();

            //инициализация словаря для коробки
            box = new Dictionary<Product, int>(); 
        }

        //вывод всего списка
        public void WriteAllProducts(ListBox listBox) 
        {
            //чистим листбокс перед каждым новым заполнением
            listBox.Items.Clear();

            //идем по списку
            foreach (var product in products)
            {
                listBox.Items.Add(product.Key.GetInfo() + "; Количество: " + product.Value);//добавляем в листбокс из списка по ключу

            }
        }

        //вывод всего списка в коробке
        public void WriteAllProductsBox(ListBox listBox) 
        {
            //чистим листбокс перед каждым новым заполнением
            listBox.Items.Clear();

            //идем по коробке
            foreach (var product in box)
            {
                //добавляем в листбокс из списка по ключу
                listBox.Items.Add(product.Key.GetInfo() + "; Количество: " + product.Value);
            }
        }
        //добавляем товар в общий список
        public void CreateProduct(string name, decimal price, int count)
        {
            //linq-запрос для проверки есть ли уже созданный товар с таким именем
            if (!products.Keys.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                //добавление товара в магазин
                products.Add(new Product(name, price), count);
            }
            else
            {
                //сообщение об ошибке
                MessageBox.Show("Товар с таким именем уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //добавляем товар в коробку
        public void CreateProductBox(Product product, Label label)
        {
            //проверка, найден ли товар
            if (product != null)
            {
                //"Нет в наличии!"
                if (products[product] <= 0)
                {
                    MessageBox.Show("Нет в наличии!");
                }
                else
                {
                    //счетчик товаров из коробки
                    fullProfit += product.Price;

                    //если словать коробки содержит ключ типа Product, добавляем к количеству 1
                    if (box.ContainsKey(product))
                    {
                        box[product]++;
                        products[product]--;
                    }
                    //иначе создаем новый элемент
                    else
                    {
                        box.Add(product, 1);
                        products[product]--;
                    }
                }
            }
            else
            {
                MessageBox.Show("Товар не найден", "Всё ещё Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //вывод суммы цен товаров в вашей коробке на данный момент
            label.Text = fullProfit.ToString();
        }

        //покупаем товар
        public void Sell(Product product, ListBox listBox)
        {
            //при новом вызове обновляет счетчик вспомогательной переменной для накопления общей прибыли от продажи
            decimal totalProfit = 0;

            //проходимся по всем элементам словаря-коробки
            foreach (var item in box)
            {
                //получаем продукт из ключа словаря
                product = item.Key;

                //получаем количество продукта из значения словаря
                int quantity = item.Value;

                //увеличиваем общую прибыль, умножая цену на количество

                totalProfit += product.Price * quantity;

                //добавляем запись о покупке в историю покупок
                string record = $"{DateTime.Now}: {product.Name}, {quantity} шт.";
                buyHistory.Add(record);

            }
            //проходим по всем записям в истории покупок
            foreach (var sp in buyHistory)
            {
                //добавляем каждую запись в листбокс
                listBox.Items.Add(sp); 
            }
            //обновляем общую прибыль магазина, не забывая прибавить прошлую прибыль
            profit += totalProfit; 
        }

        //поиск по имени товара
        public Product FindByName(string name)
        {
            //проходим по всем ключам в словаре товаров магазина
            foreach (var product in products.Keys){
                //если совпадает возвращаем найденное
                if (product.Name == name)
                {
                    return product;
                }
            }
            //продукт не найден, возвращаем null
            return null; 
        }

        //получение прибыли магазина
        public void GetProfit(Label label)
        {
            //устанавливаем общую прибыль в лейбел
            label.Text = profit.ToString();
        }

        //метод очищения списка коробки
        public void ClearBox()
        {
            //сбрасываем прибыль до нуля, обновляем ее
            fullProfit = 0;

            //очищаем словарь-коробку, удаляя все товары
            box.Clear();
        }
    }
}
