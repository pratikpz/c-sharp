using System;
public class Prime{
    public static void Main(string[] args){
        Console.WriteLine("Enter a Number");
        int num = Convert.ToInt32(Console.ReadLine());
        int c = 0;
        for(int i = 1 ; i<=num ; i++){
            if(num%i==0){
                c++;
            }
        }
        if(c==2){
        Console.WriteLine("The Number is Prime");
        }else{
        Console.WriteLine("The Number is Composite");
        }
    }
}