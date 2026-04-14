class Program
{
    static void Main(string[] args)
    {
        var a = Int32.Parse(Console.ReadLine());
        var b = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Result of {0} + {1} = {2}", a, b, a+b);
        Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
        Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
        Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
        Console.WriteLine("Result of {0} % {1} = {2}", a, b, a % b);
    }
}
