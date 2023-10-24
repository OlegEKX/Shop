using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Store
    {
        public List<AutoParts> autoParts;
        public Store()
        {
            autoParts = new List<AutoParts>
            {
                new AutoParts("Турбина", 20000),
                new AutoParts("Двигатель", 200000),
                new AutoParts("Фара", 5000),
                new AutoParts("Фильтр", 1000),
                new AutoParts("Коленвал", 15000),
                new AutoParts("ГБЦ", 80000),
                new AutoParts("Выхлоп STT", 40000)
            };
        }

        public void ShowTovar()
        {
            for (int i = 0; i < autoParts.Count; i++)
            {
                autoParts[i].Vivod(i + 1);
            }
        }

        public void AddToSklad(string name, int price)
        {
            
            autoParts.Add(new AutoParts(name, price));
        }
    }

    class AutoParts
    {
        
        public string Tovar;
        public int Price;
        public AutoParts(string name, int price)
        {
            Tovar = name;
            Price = price;
        }

        public void Vivod(int number)
        {
            Console.WriteLine($"{number}. {Tovar} {Price}");
        }
    }
}
