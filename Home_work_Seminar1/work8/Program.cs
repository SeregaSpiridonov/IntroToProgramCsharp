//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int n = 1;

Console.Write("Чётные числа от 1 до ");
Console.WriteLine(number);

while(n < number+1)
{
    if(n%2 == 0)
    {    
        Console.WriteLine(n);
    }
    n++;
}
if(number < 2) Console.WriteLine("отсутствуют или введённое число меньше 1");