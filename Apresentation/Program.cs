class Program {
  static void Main(String[] args) {
    Age();
  }
  static void Age() {
    Console.Clear();

    Console.Write("Enter your name: ");
    string name = Console.ReadLine();

    Console.Write("Enter year: ");
    int year = int.Parse(Console.ReadLine());

    int age = 2022 - year;
    Console.WriteLine($"Your name is: {name} and your age is: {age} years old.");

    if (age >= 18) {
      Console.WriteLine("You old man.");
    } else {
      Console.WriteLine("You new.");
    }
  }
}
