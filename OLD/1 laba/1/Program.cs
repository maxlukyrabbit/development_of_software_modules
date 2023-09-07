using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Flat f = new Flat(5, 8);
        WriteLine(f.GetInfo());
    }


}

class Flat
{
    public int Number { get; set; }
    public static int Cost { get; } = 900;
    public int Square { get; set; }

    public Flat()
    {
        Number = 1;
        Square = 60;
    }

    public Flat(int number, int square)
    {
        Number = number;
        Square = square;
    }

    public string GetInfo()
    {
        return $"Номер кв. {Number}, результат {Cost * Square}";
    }
}
