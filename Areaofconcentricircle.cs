using System;
public class AreaofConcentricCircle{
    public static void Main(string [] args){
        Console.WriteLine("Enter the radius of Inner Circle");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the radius of Outer Circle");
        double R = Convert.ToDouble(Console.ReadLine());
        double a = Math.PI * r * r ;
        double A = Math.PI * R * R ;
        Console.WriteLine("The Area of Inner Circle "+a);
        Console.WriteLine("The Area of Outer Circle "+A);
    }
}