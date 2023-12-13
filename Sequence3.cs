// sum = x-x^2+x^3-x^4..... to n 
using System;
public class Sequence3{
public static void Main(string[] args){
    Console.WriteLine("Enter the X");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the N");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum1=0,sum2=0;
    for(int i = 1 ; i<=n;i++)
    {
        int mul=x;
        for(int j=1;j<i;j++){
            mul *=x; 
        }
        if(i%2!=0){
            sum1+=mul;
        }else{
            sum2+=mul;
        }
    }
    int sum3 = sum1-sum2;
    Console.WriteLine("The sum of the sequence is : "+sum3);
}
}