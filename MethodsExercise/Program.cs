using System.Dynamic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string playerName = Console.ReadLine();
        Console.WriteLine("Hello, " + playerName +
        ". what were you looking to purchase today?");
        string goalItem = Console.ReadLine();
        Console.WriteLine("A " + goalItem +
        " Eh?, an adventurer of taste");

        var num1 = GetUserNumber();
        var num2 = GetUserNumber();
        Console.WriteLine($"the sum of {num1} and {num2} is {Sum (num1, num2)}");
        Console.WriteLine($"the product of {num1} and {num2} is {Multiply(num1, num2)}");
    }
    public static int Sum( int summand1, int summand2)
    {
        int sum = summand1 + summand2;
        return sum;
    }
    public static int Multiply(int factor1, int factor2)
    {
        int product = factor1 * factor2;
        return product;
    }
    static int GetUserNumber()
    {
        Console.WriteLine("enter a number");
        var input = Console.ReadLine();
        var isNumber =int.TryParse(input, out var number);
        if (isNumber)
        {
            return number;
        }
        Console.WriteLine("Invalid Input");
        return GetUserNumber();
    }
  
}