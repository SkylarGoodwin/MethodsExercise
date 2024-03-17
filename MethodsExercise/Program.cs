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
}