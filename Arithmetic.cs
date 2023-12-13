using System;
public class ArithmeticOperation{
    public static void Main(string[] args){
        Console.WriteLine("ENTER TWO NUMBER TO PERFORM ARITHMETIC OPERATION");
        int a,b;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
      
        Console.WriteLine("Additon is :"a+b);
        Console.WriteLine("Subtraction is :"a-b);
        Console.WriteLine("Multiplication is :"a*b);
        Console.WriteLine("Modulous is :"a%b);
        if(b==0){
        Console.WriteLine("Cannot divide by Zero");
        }else{
        Console.WriteLine("Division is :"a/b);
        }
    }
}