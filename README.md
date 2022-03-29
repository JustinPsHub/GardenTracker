# GardenTracker

Purpose - A console app to track land use and garden progress over time by allowing users to input data about their land use. It'll serve as a custom inventory of what a user spends on things like seeds, compost, and other garden materials and what they used on their land for that growing season or year. The project was created to meet the capstone project requirements of Code Kentucky Software Development with C# course. The idea is to store the user's input in a database but for now, the data is stored in a list and destroyed when the program exits.

Verson 1 - Console App	

Features
1. The program implements a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program by entering "2"
2. The Garden class inherits a name property from the BaseClass so I've created an additional class which inherits one or more properties from its parent
3. A list of Garden's and GardenStruct's are created and populated with data when more than one Gardens are created or a duplicate named Garden is created. When the program starts to exit, I print out the garden list so I've created a dictionary or list, populated it with several values, retrieved at least one value, and used it in the program
4. I use a LINQ query in the DupNameList and DupNameCheck methods so I used a LINQ query to retrieve information from a data structure (such as a list or array) or file

ToDo's
1. Implement Read, Update, Delete funcationality to garden list
2. Standup database to store data
3. Convert to MVC app


