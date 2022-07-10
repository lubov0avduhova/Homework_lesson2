/* Задача 3: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет. */


Console.WriteLine ("Введите число ");
string number = Console.ReadLine();
char[] array = number.ToCharArray();


if (array.Length > 2)
{
    Console.WriteLine (array [2]);
   
} else Console.WriteLine ("Третьей цифры нет");


