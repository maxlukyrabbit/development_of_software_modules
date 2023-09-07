using System;
using static System.Console;

namespace gg;


class Program
{
    static void Main(string[] args)
    {
       Bank bank= new Bank();
       bank.Bl = -1;
       WriteLine(bank.Bl);
    }
}

class Bank
{
    private int bl;

    public int Bl{
        get { return bl; }
        set{
            if (value >= 0){
                bl = value;
            }
        }
    }
}