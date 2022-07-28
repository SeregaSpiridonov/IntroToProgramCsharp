//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

void Integers(int m, int n)
{
    if(m == n) Console.Write(m);
    else
    {
        Console.Write($"{m} ");
        Integers(m+1, n);
    }
}
void InputVariables()
{
    Console.WriteLine("Введите первое число: ");
    int start = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите последнее число: ");
    int end = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Числа от {start} до {end}: ");
    Integers(start, end);
}
InputVariables();