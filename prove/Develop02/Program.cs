using System;

class Program
{
    public string _userChoice = "";
    public string _userFilename = "";

    public void GetUserInput()
    {
        Console.WriteLine("Enter '1' to add an entry, '2' to view all entries, or '0' to quit:");
        _userChoice = Console.ReadLine();

        if (_userChoice == "1")
        {
            Console.WriteLine("Enter the filename for the entry:");
            _userFilename = Console.ReadLine();
        }
    }

    public void Run()
    {
        Journal journal = new Journal();
        if (_userChoice == "1")
        {
            journal.AddEntry(_userFilename);
        }
        else if (_userChoice == "2")
        {
            journal.Display();
        }
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.GetUserInput();
        program.Run();
    }
}
