using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Product
    {
        //свойство цены
        public decimal Price { get; set; }

        //свойство имени
        public string Name { get; set; }

        // конструктор присваивания
        public Product(string Name, decimal Price) 
        {
            this.Name = Name;
            this.Price = Price;
        }

        //вывод информации
        public string GetInfo()
        {
            return $"Наименование: {Name}; Цена: {Price} руб.";
        }
    }
}
