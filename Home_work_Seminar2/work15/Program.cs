//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Является ли день выходным?");
Console.WriteLine("Введите номер дня недели(1-7)");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 0 && day < 8)
{
    if(day > 0 && day < 6) Console.WriteLine("Ответ: нет(");
    if(day > 5 && day < 8) Console.WriteLine("Ответ: ДА!");
}
else
{
    Console.WriteLine("Неверно указан номер дня недели!");
}