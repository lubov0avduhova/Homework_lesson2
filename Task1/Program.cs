/* Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. */

int Prompt (string message)
{
Console.Write (message);
int a = int.Parse (Console.ReadLine ());
return a;
}

int result = 0;
int number = Prompt ("Введите трехзначное число: ");

if (number > 99 && number < 1000)
{
    for (int i = 0; i <= 1; i++)
    {
        result = number % 10;
        number = number / 10;
    }
    Console.WriteLine($"Второе число: {result}");
} else Console.WriteLine("Вы ввели неверное число");
