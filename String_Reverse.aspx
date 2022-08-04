
using System;
	
public class Test
{
	public static void Main()
	
	{
		Console.WriteLine("Enter String");
	        string s = Console.ReadLine();
        string ans = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            ans += s[i];
        }
        Console.Write("Reversed String:\n");
        Console.Write(ans);
}
}
