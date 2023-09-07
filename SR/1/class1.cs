using System;
using static System.Console;

namespace gg;




class Jam
{
    private string name;
    private double price;
    private double weight;

    private const double VAT = 1.2;

    public Jam()
    {
        name = "Unknown";
        price = 0;
        weight = 0;

        counter++;
    }

    public Jam(string name, double price, double weight)
    {
        this.name = name;
        Price = price;
        this.weight = weight;
        
        sum += Price;
        counter++;
    }

    private static int counter;
    private static double sum;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
            {
                price = value;
            }
        }
    }

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public double NetPrice
    {
        get { return price * weight; }
    }

    public double GrossPrice
    {
        get { return NetPrice * VAT; }
    }

    public static double AvgPrice()
    {
        return sum / counter;
    }

    public string Info()
    {
        return $"Name: {name}\nPrice: {price}$\nWeight: {weight}kg\nNet Price: {NetPrice}$\nGross Price: {GrossPrice}$";
    }
}
