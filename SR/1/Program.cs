using System;
using static System.Console;

namespace gg;


class Program
{
    static void Main(string[] args)
    {
        Jam jam1 = new Jam("Strawberry Jam", -8, 0.5);
        Jam jam2 = new Jam();
        Jam jam3 = new Jam("Raspberry Jam", 6, 0.65);
        Jam jam4 = new Jam("Blueberry Jam", 8, 0.8);
        Jam jam5 = new Jam("Apricot Jam", 4, 0.45);

        Console.WriteLine(jam1.Info());
        Console.WriteLine("------------------");
        Console.WriteLine(jam2.Info());
        Console.WriteLine("------------------");
        Console.WriteLine(jam3.Info());
        Console.WriteLine("------------------");
        Console.WriteLine(jam4.Info());
        Console.WriteLine("------------------");
        Console.WriteLine(jam5.Info());

       Console.WriteLine("AVG: " + Jam.AvgPrice() + "$");
    }
}
