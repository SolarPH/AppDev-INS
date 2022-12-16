using System.Runtime.InteropServices;

public class MyCsharp
{


    public static void Main(string[] args)

    {
        
        MyCsharp pin = new MyCsharp();

        pin.printName("Mark Zedricx Corpuz");
        
    }

    public void printName(string name)

    {
        Console.WriteLine("Hello! My name is " + name);
        Console.ReadKey();
    }

}
