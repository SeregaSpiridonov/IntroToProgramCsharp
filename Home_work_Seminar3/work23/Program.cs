//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0)
{
    Console.WriteLine($"Таблица кубов чисел от 1 до {number}:");
    for(int n = 1; n <= number; n++)
    {
        double cubeNumber = Math.Pow(n, 3);
        Console.Write($"{cubeNumber}, ");
    }
}
else Console.WriteLine("Ошибка, число меньше 1.");