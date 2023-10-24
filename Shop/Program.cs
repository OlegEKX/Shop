using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Store autoParts = new Store();

            Console.WriteLine($"Приветствуем Вас в складе магазина автомобильных запчастей \"Точно не Китай\"");
            Console.WriteLine($"Выберите действие по цифре");
            Console.WriteLine($"1. Показать ассортимент товаров");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number == 1)
            {
                autoParts.ShowTovar();
            }
            else
            {
                while (number != 1)
                {
                    Console.WriteLine($"Выберите действие");
                    Console.WriteLine($"1. Показать ассортимент товаров");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number == 1)
                    {
                        autoParts.ShowTovar();
                    }
                }
                
            }
            /*string part;*/
            /*int cena;*/
            Console.WriteLine($"Сколько товаров вы хотите добавить на склад сначала \"Название товара\", а потом \"Цена товара\"");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите название запчасти");
                string part = Console.ReadLine();
                Console.WriteLine($"Введите стоимость данной запчасти");
                int cena = Convert.ToInt32(Console.ReadLine());
                autoParts.AddToSklad(part, cena);
            }

            /*autoParts.AddToSklad(part = Console.ReadLine(), cena = Convert.ToInt32(Console.ReadLine()));*/
            Console.WriteLine($"Выберите действие по цифре");
            Console.WriteLine($"1. Показать ассортимент товаров");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
            {
                autoParts.ShowTovar();
            }
            else
            {
                while (number != 1)
                {
                    Console.WriteLine($"Выберите действие");
                    Console.WriteLine($"1. Показать ассортимент товаров");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number == 1)
                    {
                        autoParts.ShowTovar();
                    }
                }

            }
        }
    }
}
