class Program
{
  static void Main(String[] args)
  {
    Sum();
  }

  static void Sum()
  {
    Console.Clear();
    Console.Write("Enter first number: ");
    float n1 = float.Parse(Console.ReadLine());

    Console.Write("Enter second number: ");
    float n2 = float.Parse(Console.ReadLine());

    float result = n1 + n2;

    Console.Write($"Result is: {result}");
  }
}