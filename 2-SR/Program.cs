using System;
using System.Linq;

namespace gg
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] price = { 200, 500, 378, 333, 1000, 453 };
            string[] name = { "Мишка", "Кукла", "Кубик", "Замок", "Поезд", "Машинка" };

            Console.WriteLine("№1-------------------------");

            Console.WriteLine($"SUM: {price.Sum()}, MAX: {price.Max()}, MIN: {price.Min()}");

            double targetNumber = Convert.ToDouble(Console.ReadLine());
            int count = price.Count(n => n > targetNumber);
            Console.WriteLine($"Количество чисел больших числа {targetNumber} = {count}");

            string targetLetter = Convert.ToString(Console.ReadLine());
            count = name.Count(n => n.StartsWith(targetLetter));
            Console.WriteLine($"Количество строк начинающихся на {targetLetter} = {count}");

            Console.WriteLine("№2-------------------------");

            List<ChildrenProduct> product = new List<ChildrenProduct>
            {
                new ChildrenProduct {price = 200, name = "Мишка"},
                new ChildrenProduct {price = 500, name = "Кукла"},
                new ChildrenProduct {price = 378, name = "Кубик"},
                new ChildrenProduct {price = 333, name = "Замок"},
                new ChildrenProduct {price = 1000, name = "Поезд"},
                new ChildrenProduct {price = 453, name = "Машинка"}

            };

            Console.WriteLine($"Сортировка по имени -------------------------");
            var sotrV = product.OrderBy(args => args.name);
            foreach (var a in sotrV)
            {
                Console.WriteLine($"Цена: {a.price}");
                Console.WriteLine($"Название: {a.name}");
                Console.WriteLine();
            }

            Console.WriteLine($"Сортировка по цене-------------------------");
            var sotrN = product.OrderByDescending(args => args.price);
            foreach (var a in sotrN)
            {
                Console.WriteLine($"Цена: {a.price}");
                Console.WriteLine($"Название: {a.name}");
                Console.WriteLine();
            }

            double MaxPrice = product.Max(args => args.price);
            double MinPrice = product.Min(args => args.price);
            double AvgPrice = product.Average(args => args.price);
            Console.WriteLine($"MAX = {MaxPrice}");
            Console.WriteLine($"MIN = {MinPrice}");
            Console.WriteLine($"Average = {AvgPrice:0,00}");

            var NOTAVG = product.Select(p => new { p.price });
            double AVGNT = 0;
            int countt = 0;
            foreach (var a in NOTAVG)
            {
                AVGNT += a.price;
                countt++;
            }
            Console.WriteLine($"Average без метода = {AVGNT / countt:0.00}");

            string targetLetter2 = Convert.ToString(Console.ReadLine());
            count = product.Count(n => n.name.StartsWith(targetLetter2));
            Console.WriteLine($"Количество строк начинающихся на {targetLetter2} в List = {count}");

            string targetLetter3 = Convert.ToString(Console.ReadLine());
            count = product.Count(n => n.name == (targetLetter3));

            if (count == 0)
            {
                Console.WriteLine($"{targetLetter3} in list = false");
            }
            else
            {
                Console.WriteLine($"{targetLetter3} in list = true");
            }

            double PriceIn = Convert.ToDouble(Console.ReadLine());
            var countMore = product.Count(n => n.price > (PriceIn));
            var countLess = product.Count(n => n.price < (PriceIn));
            var countEqually = product.Count(n => n.price == (PriceIn));

            Console.WriteLine($"Количество чисел больше {PriceIn} = {countMore}");
            Console.WriteLine($"Количество чисел меньше {PriceIn} = {countLess}");
            Console.WriteLine($"Количество чисел равных {PriceIn} = {countEqually}");


        }
    }
}