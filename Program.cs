// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// int number = int.Parse(Console.ReadLine());
// Console.WriteLine($"You entered the number: {number}");
// int number2 = int.Parse(Console.ReadLine());
// Console.WriteLine($"You entered the number2: {number2}");
// int sum = number + number2;
// Console.WriteLine($"The sum is: {sum}");


List<int> numbers = new List<int>();
for (int i = 0; i < 3; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    int number = int.Parse(Console.ReadLine());
    numbers.Add(number);
}
int sum = numbers.Sum();
Console.WriteLine($"The sum of the entered numbers is: {sum}");


IEnumerable<int> evenNumbers = numbers.Where(n => n % 2 == 0);
Console.WriteLine("Even numbers entered: " + string.Join(", ", evenNumbers));


IEnumerable<int> nums = Enumerable.Range(1, 10);
IEnumerable<int> squaredNumbers = nums.Select(n => n * n);
Console.WriteLine("Squared numbers from 1 to 10: " + string.Join(", ", squaredNumbers));
