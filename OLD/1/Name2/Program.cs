using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Even();
    }

    static void Even()
    {
        int i = 0;

        while(i < 10)
        {
            int x = Convert.ToInt32(ReadLine());

            if(x % 2 == 0)
                WriteLine("TRUE");
            else
                WriteLine("FALSE");
            i++;
        }
    }
}