using System.Diagnostics;

namespace uri_command;

public abstract class Hello
{

    public static void Main()
    {
        Console.WriteLine("Hello, World!");

        Process.Start(new ProcessStartInfo
        {
            FileName = "obsidian://new?vault=Personal%20Vault&name=NewFile&append",
            UseShellExecute = true
        });
        
        Console.WriteLine("Done now :)");
    }
}


