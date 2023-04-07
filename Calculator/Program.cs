Console.WriteLine("Enter the operation (+/-):");
char userOp = Char.Parse(Console.ReadLine());
Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOp)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Subtraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid op");
        break;
}

static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}



