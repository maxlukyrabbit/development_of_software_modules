using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("----------------------");
        double A1 = 0, B1 = 0;
        
        A1 = Convert.ToDouble(ReadLine());
        B1 = Convert.ToDouble(ReadLine());
        
        WriteLine(F(A1) + F(B1));
        
        WriteLine("----------------------");
        
        int A2 = 0, B2 = 0, C2 = 0;
        
        A2 = Convert.ToInt32(ReadLine());
        B2 = Convert.ToInt32(ReadLine());
        C2 = Convert.ToInt32(ReadLine());
        
        SumRange(A2, B2, C2);
        
        WriteLine("----------------------");
        
        int A3 = 0, B3 = 0, C3 = 0;
        
        A3 = Convert.ToInt32(ReadLine());
        B3 = Convert.ToInt32(ReadLine());
        C3 = Convert.ToInt32(ReadLine());
        
        WriteLine(Calc(A3, B3, C3));
        
    }
    
    static int F(double x)
    {
        int flag = 0;
        if(x < 0)
        {
            flag = -1;
        }
        
        if(x == 0)
        {
            flag = 0;
        }
        
        if(x > 0)
        {
            flag = 1;
        }

        return flag;
        
    }
    
    static void SumRange(int A, int B, int C)
    {
        int sum1 = 0;
        int sum2 = 0;
        
        
        if(A < B)
        {
            while(A <= B)
            {
                
                sum1 += A;
                
                A++;
                
            }
            
            while(B <= C)
            {
                
                sum2 += B;
                
                B++;
            }
            WriteLine("sum1: {0}, sum2: {1}", sum1, sum2);
        }
        else{
            WriteLine(0);
        }
        
        
    }
    
    
    static double Calc(double A, double B, int Op )
    {
        if(Op == 1)
        {
            return A - B;
        }
        
        if(Op == 2)
        {
            return A * B;
        }
        
        if(Op == 3)
        {
            return A / B;
        }
        
        return A + B;
        
        
    }
    
    
}
