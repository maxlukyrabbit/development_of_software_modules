using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        double x = 0, y = 0;

        x = Convert.ToDouble(ReadLine());
        y = Convert.ToDouble(ReadLine());

        Quarter(x, y);
    }

    static void Quarter(double x, double y)
    {
        if(x == 0 && y == 0)
            WriteLine("nachalo");

        if(x > 0 && y > 0)
            WriteLine("1");
        if(x < 0 && y > 0)
            WriteLine("2");
        if(x < 0 && y < 0)
            WriteLine("3");
        if(x > 0 && y < 0)
            WriteLine("4");
    }
}