using System;
					
public class MyCsharp
{
	public static void Main(string[] args)
	{
		// Insert code from line below this comment where it instantiates the MyCsharp object into variable named pin, then call the method named printName(String name);
    // Expected Line 1, replace this comment with code on pull request
    // Expected Line 2, replace this comment with code on pull request
	}
	
	public void printName(string name)
	{
		
		MyCsharp pin = new MyCsharp();
		
		Console.WriteLine("Hello Everyone!. My name is " + name);
		
		Console.WriteLine("What is your name ? ");
		String name = Console.ReadLine();
		


		Console.WriteLine("Hello " + name);
		
		Console.ReadKey(true);
	}
}
