using System;
public class Sumofsqofdigit{
    public static void Main(string [] args){
    Console.WriteLine("Enter a Number");
    int num = Convert.ToInt32(Console.ReadLine());
    int rem,sum=0;
    while(num!=0){
        rem = num % 10 ; 
        sum = sum + rem*rem;
        num=num/10;
    }
     Console.WriteLine("The Sum of square of digit of a Number is :" + sum);
    }
} 