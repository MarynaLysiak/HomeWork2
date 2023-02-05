// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


System.Console.Write("Введите число:");
string number = Console.ReadLine();
int length = number.Length;


if ( length > 2)
{
    System.Console.Write($"Третяя цифра числа: {number[2]}");
} 
else 
System.Console.Write($"Третьей цифры нет");