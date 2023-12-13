// sum = 1^2+2^2+3^2+4^2+..... to n 
using System;
public class Sequence1{
public static void Main(string[] args){
    Console.WriteLine("Enter the N");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    for(int i = 1 ; i <= n ; i++){
        sum += i*i;
    }
    Console.WriteLine("The sum of the sequence is : "+sum);
}
}