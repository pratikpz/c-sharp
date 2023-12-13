// sum = 1+2/2!+3/3!+4/4!+..... to n 
using System;
public class Sequence2{
public static void Main(string[] args){
    Console.WriteLine("Enter the N");
    int n = Convert.ToInt32(Console.ReadLine());
    double sum = 1.0;
    for(int i = 2 ; i <= n ; i++){
        double fact = 1.0;
        for(int j = 1; j<=i ; j++)
        {
            fact = fact*j;
        }
        sum += (double)i/fact;
    }
    Console.WriteLine("The sum of the sequence is : "+sum);
}
}