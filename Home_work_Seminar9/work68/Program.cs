//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if(m == 0) return n+1;
    else if(m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
void InputVariables()
{
    Console.WriteLine("Введите первое неотрицательное число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе неотрицательное число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if(number1 < 0 || number2 < 0) Console.WriteLine("Ошибка, числа должны быть положительными.");
    else
    {
        Console.Write($"A({number1}, {number2}) = ");
        Console.WriteLine(Akkerman(number1, number2));
    }
}
InputVariables();