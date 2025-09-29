// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string name = "Alice";
int age = 30;
Console.WriteLine($"Name: {name}, Age: {age}");
Console.WriteLine(name);
Console.WriteLine(age);


string input = Console.ReadLine();
Console.WriteLine($"You entered: {input}");



int number = int.Parse(Console.ReadLine());
Console.WriteLine($"You entered the number: {number}");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine($"You entered the number2: {number2}");
int sum = number + number2;
Console.WriteLine($"The sum is: {sum}");