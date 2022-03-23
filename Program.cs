using GardenTracker.Model;

Console.WriteLine("Welcome to the Garden Tracker Application. Select 1 and enter to interact with the Garden Tracker database. Press 2 and enter at any point to close the application.");
string? input = "";
input = Console.ReadLine();
List<Garden> gardenList = new List<Garden>();
List<GardenStruct> dupGardenList = new List<GardenStruct>();
while (input != "2")
    {  
    if (input != "1")
    {
        Console.WriteLine($"You entered {input}, which is not a selection of 1 to interact with the Garden Tracker database or a selection of 2 to close the program. " +
            $"If you want to interact data to the database, press 1. If you want to exit the program press, press 2.");
        input = Console.ReadLine();
    }
    //do the work
    else
    {
        Console.WriteLine("The application provides CRUD access to the Garden Tracker database.");
       string crudString = AskForAction();
        bool crudStringBool = false;
        crudStringBool = CrudStringIsTwo(crudString);
        if (crudStringBool)
        {
            input = "2";

        }
   
        do
        {
            switch (crudString)
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

                    //writing to a list instead of a database for now

                    gardenList.Add(garden);

                    //linq query if there's more than 1 garden in the list to tell us if we have duplicate garden's

                    if (gardenList.Count > 1)
                    {
                        bool dupName = DupNameCheck(gardenList);

                        if (dupName)
                        {
                            dupGardenList = DupNameList(gardenList);
                            //write out duplicate names
                            dupGardenList.ForEach(dupName => Console.WriteLine($"You entered {dupName.Name} into the database {dupName.Count} times."));
                        }
                        Console.WriteLine();                        
                    }
                    crudString = AskForAction();
                    crudStringBool = CrudStringIsTwo(crudString);
                    if (crudStringBool)
                    {
                        input = "2";

                    }

                    break;
                case "Read":
                    crudString = DoNothingMethod();
                    crudStringBool = CrudStringIsTwo(crudString);
                    if (crudStringBool)
                    {
                        input = "2";

                    }
                    break;
                case "Update":
                    crudString = DoNothingMethod();
                    crudStringBool = CrudStringIsTwo(crudString);
                    if (crudStringBool)
                    {
                        input = "2";

                    }
                    break;
                case "Delete":
                    crudString = DoNothingMethod();
                    crudStringBool = CrudStringIsTwo(crudString);
                    if (crudStringBool)
                    {
                        input = "2";

                    }
                    break;
                default: Console.WriteLine($"You entered {crudString}, which is something other than Create, Read, Update, or Delete.");
                    Console.WriteLine();
                    crudString = AskForAction();
                    break;
            }
            Console.WriteLine($"You entered {crudString}, which is something other than Create, Read, Update, or Delete.");
            crudString = AskForAction();
            crudStringBool = CrudStringIsTwo(crudString);
            if (crudStringBool)
            {
                input = "2";

            }
            
        } while (crudString == "Create" || crudString == "Read" || crudString == "Update" || crudString == "Delete" && crudString != "2") ;

       

    }







Console.WriteLine("You pressed 2 to close the program. Goodbye!");

gardenList.ForEach(garden =>
{
    Console.WriteLine(garden.Name);
});

Console.ReadLine();
}


static bool CrudStringIsTwo(string crudString)
{
    bool answer = crudString == "2" ? true : false;
    return answer;
};

static string AskForAction()

{
    Console.WriteLine("Enter Create to create a new object " +
    "Enter Read to read from the database. Enter Update to update an object in the database. Enter Delete to delete an object in the database.");
    
    string? answer = "";
    answer = Console.ReadLine();
    return answer;
}

static bool DupNameCheck(List<Garden> gardenList)
{
    var nameCount = (from name in gardenList
                    group name by name.Name into g
                    let count = g.Count()
                    orderby count descending
                    select new { g.Key, count }).ToList();

    bool boolAnswer = false;

    foreach (var item in nameCount)
    {
        if (item.count > 1)

        {
            boolAnswer = true;
            break;
        }
    }

    return boolAnswer;
}

static List<GardenStruct> DupNameList(List<Garden> gardenList)
{
    var nameCount = (from name in gardenList
                     group name by name.Name into g
                     let count = g.Count()
                     orderby count descending
                     select new { g.Key, count }).ToList();


    List<GardenStruct> dupNames = new List<GardenStruct>();
    nameCount.ForEach(count =>
    {
        if (count.count > 1)
        {
            GardenStruct garden = new GardenStruct()
            {
                Name = count.Key,
                Count = count.count
            };
            dupNames.Add(garden);
        }

    });
    return dupNames;
}

static string DoNothingMethod()
{
    Console.WriteLine("Sorry, this functionality hasn't been implemented yet. All you can do right now is create gardens so either type 'Create' or 2 to close the program.");
          string answer = Console.ReadLine();
          return answer;
}


    struct GardenStruct
{
    public string Name { get; set; }
    public int Count { get; set; }

}




