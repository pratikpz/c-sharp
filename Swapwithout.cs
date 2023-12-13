using System;
public class SwapWthoutThird{
    public static void Main(string [] args){
        Console.WriteLine("ENTER THE TWO NUMBERS TO SWAP");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("THE NUMBERS BEFORE SWAP " + n1 +" and " + n2);
        n1=n1+n2; 
        n2=n1-n2;
        n1=n1-n2;
        Console.WriteLine("THE NUMBERS AFTER SWAP " + n1 +" and " + n2);
    }
}