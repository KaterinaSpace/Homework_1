/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.WriteLine("Введите второе число");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);

Console.WriteLine("Введите третье число");
string input3 = Console.ReadLine();
int number3 = int.Parse(input3);

if(number1 >= number2)
{
    if  (number1 >= number3)
    Console.WriteLine($" max={number1} ");
    else 
    Console.WriteLine($" max={number3} ");

}     

else 
{
    if (number2 >= number3)
    Console.WriteLine($"max={number2}");
    else
    Console.WriteLine($"max={number3}");
}