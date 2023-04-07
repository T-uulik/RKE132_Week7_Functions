Console.WriteLine("Choose C or F");
char userChoice = char.Parse(Console.ReadLine());
Console.WriteLine("Enter temp:");
int userTemp = Int32.Parse(Console.ReadLine());

switch (userChoice)
{
    case 'F':
        ConvertToFahrenheit(userTemp);
        break;
    case 'C':
        ConvertToCelsius(userTemp);
        break;
    default:
        Console.WriteLine("Error");
        break;
}





static void ConvertToCelsius(int fahrenheit)
{
    Console.WriteLine($"{(fahrenheit - 32) * 5 / 9}C");
}
static void ConvertToFahrenheit(int celsius)
{
    Console.WriteLine($"{(celsius * 9) / 5 + 32}F");
}
