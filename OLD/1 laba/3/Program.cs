using System;

class Program
{
    static void Main(string[] args)
    {
        Table table = new Table();
        table.DisplayInfo();
        Console.WriteLine("Cost: " + table.GetCost());
    }
}

class Table
{
    private string name;
    private double area;
    private const double additionalCost = 500000;

    public Table()
    {
        name = "Table";
        area = 210;
    }

    public Table(string name, double area)
    {
        this.name = name;
        this.area = area;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Area
    {
        get { return area; }
        set { area = value; }
    }

    public double GetCost()
    {
        return area * area / 3 + additionalCost;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Area: " + area + " sq.cm");
    }
}
