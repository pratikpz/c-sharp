using System;
public class OddEven{
    public static void Main(string[] args){
        Console.WriteLine("ENTER THE NUMBER");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num%2==0?"The number is Even":"The number is Odd");
    }
}