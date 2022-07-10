/* Задача 2: Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру этого числа. */

Random rnd = new Random();
int number = rnd.Next(100, 1000);
int result = 0;
Console.WriteLine ($"Число {number}");

    result = number / 100 * 10 + number % 10;
    Console.WriteLine($"Новое число: {result}");
