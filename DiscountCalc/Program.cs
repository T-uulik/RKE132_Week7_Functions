Console.WriteLine("Enter your total sum:");
int userTotal = Int32.Parse(Console.ReadLine());

double discount = CalcDiscount(userTotal);

Console.WriteLine($"Your discount is: {discount}%");

double newTotal = CalcNewTotal(userTotal, discount);

Console.WriteLine($"Your updated total with {discount}%:{newTotal}");


static double CalcDiscount(int total)
{
    if(total < 10)
    {
        return 1;
    }
    else if(total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}
static double CalcNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}