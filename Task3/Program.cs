// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 7 || day == 6)
{
    System.Console.WriteLine("Ура, это выходной день!");

}
else if (day == 1 || day == 2 || day == 3 || day ==4 || day == 5)
{
    System.Console.WriteLine("Мне жаль, но это рабочий день");
}
else
{
    System.Console.WriteLine("Такого дня недели не существует");
}