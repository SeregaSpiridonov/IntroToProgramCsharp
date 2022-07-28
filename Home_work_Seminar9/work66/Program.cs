//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumIntegers(int m, int n)
{
    return m < n ? m + SumIntegers(m+1, n) : n;
}
void InputVariables()
{
    Console.WriteLine("Введите первое число: ");
    int start = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите последнее число: ");
    int end = Convert.ToInt32(Console.ReadLine());
    if(start > end) Console.WriteLine("Ошибка, начальное число больше конечного.");
    else
    {
        Console.WriteLine($"Сумма чисел от {start} до {end}: ");
        Console.WriteLine(SumIntegers(start, end));
    }
}
InputVariables();