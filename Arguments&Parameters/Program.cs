Console.WriteLine("Enter something:");
string userInput = Console.ReadLine();


PrintAny(userInput);

static void PrintAny(string anyString)
{
    anyString = anyString.ToUpper();
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}