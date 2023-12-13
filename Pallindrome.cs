using System;
public class Pallindrome{
    public static void Main(string[] args){
    Console.WriteLine("Enter a Number");
    int num = Convert.ToInt32(Console.ReadLine());
    int pal = num;
    int rem,rev=0;
    while(num!=0){
        rem = num % 10 ; 
        rev = rev * 10 + rem;
        num=num/10;
    }
    if(pal == rev){
        Console.WriteLine("The Number is Pallindrome");
    }else{
        Console.WriteLine("The Number is not Pallindrome");
    }

    }
}