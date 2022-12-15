using System;
					
public class MyCsharp
{
	public static void Main(string[] args)
	{
	Console.WriteLine("Please Enter your Full Name: ");
		string name = Console.ReadLine();
		printname(name);
	}
	
	public void printName(string name)
	{
		Console.WriteLine("Hello! My name is " + name);
	}
}

