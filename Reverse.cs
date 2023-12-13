using System;
public class Reverse{
    public static void main(string[] args){
    Console.WriteLine("Enter a Number");
    int num = Convert.ToInt32(Console.ReadLine());
    int rem,rev=0;
    while(num!=0){
        rem = num % 10 ; 
        rev = rev * 10 + rem;
        num=num/10;
    }
     Console.WriteLine("The reverse of a Number is :" + rev);
    }
} 