using System;
public class Time{
    public static void Main(string[] args){
        Console.WriteLine("Enter the Time in Seconds");
        int t = Convert.ToInt32(Console.ReadLine());
        int min = t / 60;
        int sec = t - (min*60);
        int hour =  0 ;
        if(min >= 60){
            hour = min / 60;
            min = min - (hour * 60 );
        }
        Console.WriteLine(hour+":Hour "+min+":min "+sec+":sec");
    }
}