//Main
DisplayMenu();
//Method to display menu to user
static void DisplayMenu()
{
    System.Console.WriteLine("Enter '1' for triangle, '2' for partial triangle, and '3' to exit.");
    string userInput = Console.ReadLine();
    if(userInput == "1")
    {
        Triangle();
    }
    else if(userInput == "2")
    {
        PartialTriangle();
    }
    else if(userInput == "3")
    {
        System.Console.WriteLine("This is the end of the program");
    }
    else
    {
        System.Console.WriteLine("Please enter a valid input");
        DisplayMenu();
    }
}
//Method for displaying a triangle
static void Triangle()
{
Random rnd = new Random();
int num = rnd.Next(3,9);
    for(int i=0; i<=num; i++)
    {
        for(int j=0; j<=i; j++)
        {
            System.Console.Write("o"); 
        }
        System.Console.WriteLine("  ");
    }
    DisplayMenu();
}
//Method for displaying a partial triangle
static void PartialTriangle()
{
Random rnd = new Random();
int num = rnd.Next(3,9);
    for(int i=0; i<=num; i++)
    {
        for(int j=0; j<=i; j++)
        {   
            Random random = new Random();
            int number = random.Next(2);
            if(number == 0)
            {
                System.Console.Write("o");   
            }
            else
            {
                System.Console.Write(" ");
            }
        }
        System.Console.WriteLine(" ");
    }
    DisplayMenu();
}