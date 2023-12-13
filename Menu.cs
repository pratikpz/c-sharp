using System;
public class Menu{
    public static void Main(string[] args){
        Console.WriteLine("Choose to find \n1.perimeter of square\n2.Area of Rectangle\n3.Volume of cube");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice){
            case 1:
            Console.WriteLine("Enter length of the Square");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Perimeter of Square is : "4*l)
            break;
            case 2:
            Console.WriteLine("Enter length and breadth of the Rectangle");
            double len = Convert.ToDouble(Console.ReadLine());
            double bre = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Area of Rectangle is : "len*ber)
            break;
            case 3:
            Console.WriteLine("Enter length of the Cube");
            double v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Volume of Cube is : "v*v*v)
            break;
            default:
            Console.WriteLine("Enter Valid choice i.e 1 - 3 ");
            break;
        }
    }
}