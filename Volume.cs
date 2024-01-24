using System;
public class VolumeConverter{
    public static void Main(string[] args){
        Console.WriteLine("Enter required  Volume in ml");
        int v = Convert.ToInt32(Console.ReadLine());
        int liter = v /1000;
        int ml = v - (1000*liter);
        Console.WriteLine("The area is :"+liter+":liter "+ ml+": mililiter");
    }
}
