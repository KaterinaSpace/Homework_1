//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
string input = Console.ReadLine();
int numberA = int.Parse(input);

Console.WriteLine("Введите второе число");
string input2 = Console.ReadLine();
int numberB = int.Parse(input2);

if (numberA > numberB)
{
    Console.WriteLine($"{numberA} больше чем  {numberB}");
}
else
{
    Console.WriteLine($"{numberB} больше чем {numberA} ");
}