using GardenTracker.Model;

Console.WriteLine("Garden Tracker Application. Select 1 and Enter to interact with the Garden Tracker database. Press 2 and enter at any point to close the application.");
string? input = "";
input = Console.ReadLine();
while (input != "2")
    {  
    if (input != "1")
    {
        Console.WriteLine($"You pressed {input}, which is not a selection of 1 to interact with the Garden Tracker database or a selection of 2 to close the program. " +
            $"If you want to add new data to the database, press 1. If you want to exit the program press, press 2.");
        input = Console.ReadLine();
    }
    //do the work
    else
    {        
        Console.WriteLine("The application provides CRUD access to the Garden Tracker database. Enter Create to create a new object " +
            "Enter Read to read from the database. Enter Update to update an object in the database. Enter Delete to delete an object in the database.");
        input = Console.ReadLine();
        List<Garden> gardenList = new List<Garden>();
        while (input == "Create" || input == "Read" || input == "Update" || input == "Delete" && input != "2")
        {
            switch (input)
            {
                case "Create":
                    Garden garden = new Garden();
                    Console.WriteLine("What's the garden's name?");                                                     
                    input= Console.ReadLine();                   
                    garden.Name = input;
                    /*
                    Console.WriteLine("Provide a brief description of the garden.");
                    input = Console.ReadLine();
                    garden.Description = input; 
                    Console.WriteLine("Enter the square footage.");
                    input = Console.ReadLine();
                    garden.GardenSquareFeet = input;
                    */
                    garden.DateTimeCreated = DateTime.Now;
                   // Garden garden = new Garden(gardenName,gardenDescription, gardenSquareFeet, DateTime.Now);

                    //writing to a list instead of a database for now

                    gardenList.Add(garden);

                    //linq query if there's more than 1 garden in the list to tell us if we have duplicate garden's

                    if (gardenList.Count > 1)

                    {
                        var nameCount = from name in gardenList
                                        group name by name.Name into g
                                        let count = g.Count()
                                        orderby count descending
                                        select new { g.Key, count }
                                        ;

                        //join nameCount to original 

                        foreach (var item in nameCount)
                        {
                            if (item.count > 1)

                            {
                                Console.Write($"You have {item.count} gardens named {item.Key} in the database.");
                            }
                        }
                    }
                 

                    input = AskForAction();
                 
                    break;
                case "Read":
                    break;
                case "Update":
                    break;
                case "Delete":
                    break;

                default: Console.WriteLine("You typed something other than Create, Read, Update, or Delete.");
                    break;
            }
        };
    }



} ;

Console.WriteLine("You pressed 2 to close the program. Goodbye!");


Console.ReadLine();

static string AskForAction()

{
       Console.WriteLine("What else do you want to do? Enter Create to create a new object " +
       "Enter Read to read from the database. Enter Update to update an object in the database. Enter Delete to delete an object in the database.");
    string answer = Console.ReadLine();
    return answer;
}




