using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Agropole a = new Agropole("Биба", 7);
        WriteLine(a.GetInfo());
    }


}



class Agropole
{
    public string name  { get; }
    public const double weight = 0.5;
    public double square { get; set; }


    public Agropole()
    {
        name = "Майский";
        square = 60;
    }

    public Agropole(string Name, double Square)
    {
        name = Name;
        square = Square;
    }

    public string GetInfo()
    {
        return $"Название - {name}, нужный вес {weight * square}";
    }
}