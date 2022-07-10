/* Задача 4: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным. */


int Prompt (string message)
{
Console.Write (message);
int a = int.Parse (Console.ReadLine ());
return a;
}


int number = Prompt ("Введите число ");

if (number >= 1 && number <= 5)
Console.WriteLine ("День недели - будни");
else if (number >= 6 && number <= 7)
Console.WriteLine ("День недели - выходной");
else Console.WriteLine ("Неправильный ввод");
