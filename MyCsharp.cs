using System;
					
public class MyCsharp
{
	public static void Main(string[] args)
	{
		// Insert code from line below this comment where it instantiates the MyCsharp object into variable named pin,then call the method named printName(String name);
    MyCsharp pin = new MyCsharp();
	pin.println("Clarisse Andal");
	}
	
	public void printName(string name)
	{
		Console.WriteLine("Hello! My name is " + name);
	}
}
