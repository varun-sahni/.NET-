//How to swap two numbers without using a temporary variable?

using System;
 
public class Test {
    public static void Main()
    {
		Console.WriteLine("Enter First Number");
        int x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Second Number");
        int y = Convert.ToInt32(Console.ReadLine());;
		Console.WriteLine("Before Swap:x = " + x + ", y = " + y);
 
        x = x + y;
        y = x - y;
        x = x - y;
        Console.WriteLine("After swapping: x = " + x + ", y = " + y);
    }
}
