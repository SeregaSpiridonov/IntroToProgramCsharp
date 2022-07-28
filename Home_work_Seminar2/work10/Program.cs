//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000)
{
    int numberTwo = number%100/10;
    Console.Write("Вторая цифра числа: ("+number+") => "+numberTwo);
}
else
{
    Console.WriteLine("Число не трёхзначное или меньше 100");
}