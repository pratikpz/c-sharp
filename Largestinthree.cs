using System;
public class LargestinThree{
    public static void Main(string[] args){
        Console.WriteLine("ENTER THE THREE NUMBERS");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
         Console.Write((num1 > num2 && num1 > num3) ? num1+" is the greatest":(num2>num3)?num2+" is the greatest":num3+" is the greatest");
        
    }
}