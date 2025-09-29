// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int number = int.Parse(Console.ReadLine());
Console.WriteLine($"You entered the number: {number}");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine($"You entered the number2: {number2}");
int sum = number + number2;
Console.WriteLine($"The sum is: {sum}");


Console.ReadKey();