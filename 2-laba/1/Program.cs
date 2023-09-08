class Program
{
    static void Main(string[] args)

    {

        Console.WriteLine("а-------------------------");

        Random rnd = new Random();
        int a = rnd.Next(1, 10);
        int[] b = new int[a];
        int[] c = new int[a];
        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < a; i++)
        {
            b[i] = rnd.Next(1, 30);
        }

        for (int j = 0; j < a; j++)
        {
            c[j] = b[j] * 78;
        }
        Console.WriteLine("б-------------------------");
        for (int j = 0; j < a; j++)
        {
            Console.Write(b[j] + " ");
            sum1 += b[j];
        }

        Console.WriteLine();

        for (int j = 0; j < a; j++)
        {
            Console.Write(c[j] + " ");
            sum2 += c[j];
        }

        Console.WriteLine();
        Console.WriteLine("в-------------------------");

        Console.WriteLine(sum1);
        Console.WriteLine(sum2);

        Console.WriteLine("г-------------------------");


        Console.WriteLine($"max first: {b.Max()}, min first: {b.Min()}");
        Console.WriteLine($"max second: {c.Max()}, min second: {c.Min()}");

        Console.WriteLine("д-------------------------");


        int p = Convert.ToInt32(Console.ReadLine());

        if (b.Contains(p))
        {
            Console.WriteLine("First true");
        }
        else
        {
            Console.WriteLine("First false");
        }

        if (c.Contains(p))
        {
            Console.WriteLine("Second true");
        }
        else
        {
            Console.WriteLine("Second false");
        }

        Console.WriteLine("е-------------------------");

        var b50 = from elem in b
                  where elem > 1 && elem < 50
                  select elem;

        var c40 = from elem in c
                  where elem > 70 && elem < 500
                  select elem;

        Console.WriteLine("Элементы 1 массива, которые меньше 50 и больше 1");
        foreach (var element in b50)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine("");
        Console.WriteLine("Элементы 2 массива, которые меньше 500 и больше 70");

        foreach (var element in b50)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine("");
        Console.WriteLine("ж-------------------------");


        int[] all = b.Where(element => c.Contains(element)).ToArray();
        if (all.Length == 0)
        {
            Console.WriteLine("Таких элементов нет");
        }
        else
        {
            foreach (var element in all)
            {
                Console.WriteLine(element);
            }
        }

        Console.WriteLine("з-------------------------");

        int[] combinedArray = b.Concat(c).ToArray();

        Console.WriteLine("Объединенный массив:");
        foreach (var element in combinedArray)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine("");
        Console.WriteLine("и-------------------------");


        if (all.Length == 0)
        {
            Console.WriteLine("Пересечения нет");
        }
        else
        {
            foreach (var element in all)
            {
                Console.WriteLine(element);
            }
        }

        Console.WriteLine("");
        Console.WriteLine("к-------------------------");

        var result1 = combinedArray.OrderBy(t => t);
         Console.WriteLine("По возрастанию");
        foreach (int t in result1)
            Console.Write($"{t} ");

        Console.WriteLine("");
        Console.WriteLine("к.1-------------------------");

        var result2 = combinedArray.OrderByDescending(t => t);
        Console.WriteLine("По убыванию");
        foreach (int t in result2)
            Console.Write($"{t} ");

        Console.WriteLine("");
        Console.WriteLine("к.2-------------------------");

    }










}




