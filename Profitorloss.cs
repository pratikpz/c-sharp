using System;
public class ProfitOrLoss{
    public static void Main(string [] args){
        Console.WriteLine("ENTER THE COST PRICE ")
        double cp = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ENTER THE SELLING PRICE ")
        double sp = Convert.ToDouble(Console.ReadLine());

        if(cp>sp){
            double loss = cp - sp;
            Console.WriteLine("THE Loss Amount :"+loss);
        }else{
            double profit = sp - cp;
            Console.WriteLine("THE Profit Amount :"+profit);
        }
    }
}