//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("введите число А:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
double degree = numA;

for(int index = 1; index < Math.Abs(numB); index++)
{
    degree = degree * numA;
}
if(numB == 0) degree = 1;
if(numB < 0) degree = 1/degree;

Console.WriteLine($"Число {numA} в степени {numB} => {degree}.");