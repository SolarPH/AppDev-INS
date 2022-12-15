using System;
					
public class MyCsharp
{
	public static void Main() { 
        
        Console.Write("Enter your surname: ");
	String SurName = Console.ReadLine();
	
	Console.Write("Enter your first name: ");
	String FirstName = Console.ReadLine();
	
	Console.Write("Enter your middle name: ");
	String MiddleName = Console.ReadLine();
	
	Console.WriteLine(" ________________________");
	Console.WriteLine("__________________________");
	Console.WriteLine(" -----------------------  ");
	
	Console.WriteLine ("My name is " + SurName, " " + FirstName," " + MiddleName );
    }
}
	

