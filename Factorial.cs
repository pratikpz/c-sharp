using System;
public class Factorial{
    public static void Main(string [] args)
    {
        Console.WriteLine("Enter a number to find factorial");
        int num = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        if(num==0){
            Console.WriteLine("The factorial of the given number is :" + fact);
            return;
        }
        for(int i = 1 ; i <= num ; i++ )
        {
            fact *=i;
        }
        Console.WriteLine("The factorial of given number is :" + fact);
    }
}
