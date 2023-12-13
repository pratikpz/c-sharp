using System;
public class DivideByFiveAndSeven{
    public static void Main(string[] args){
        Console.WriteLine("ENTER THE NUMBER");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num%5 == 0 && num%7 == 0){
        Console.WriteLine("The number is divisible by 5 and 7");
        }else{
        Console.WriteLine("The number is not divisible by 5 and 7");
        }
    }
}