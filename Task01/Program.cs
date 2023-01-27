Console.Clear();
Console.WriteLine("Введите два целых числа.");
Console.Write("Первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
    Console.WriteLine($"Max={number1}");
else
{
    if (number1 < number2)
        Console.WriteLine($"Max={number2}");
    else
        Console.WriteLine("Числа равны");
}