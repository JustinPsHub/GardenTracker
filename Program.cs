

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Garden Tracker Application. Select 1 and Enter to interact with the Garden Tracker database. Press 2 and enter at any point to close the application.");
string? input = "";
input = Console.ReadLine();
while (input != "2")
    {  
    if (input != "1")
    {
        Console.WriteLine($"You pressed {input}, which is not a selection of 1 to interact with the Garden Tracker database or a selection of 2 to close the program. " +
            $"If you want to add new data to the database, press 1. If you want to exit the program press, press 2.");
    }
    //do the work
    else
    {
        Console.WriteLine("Do the work");
    }
   
    } ;


Console.WriteLine("You pressed 2. Goodbye!");




