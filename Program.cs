// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// int number = int.Parse(Console.ReadLine());
// Console.WriteLine($"You entered the number: {number}");
// int number2 = int.Parse(Console.ReadLine());
// Console.WriteLine($"You entered the number2: {number2}");
// int sum = number + number2;
// Console.WriteLine($"The sum is: {sum}");


List<int> numbers = new List<int>();
for (int i = 0; i < 5; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    int number = int.Parse(Console.ReadLine());
    numbers.Add(number);
}
int sum = numbers.Sum();
Console.WriteLine($"The sum of the entered numbers is: {sum}");


Console.ReadKey();