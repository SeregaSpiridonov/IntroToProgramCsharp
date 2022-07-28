//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] Array = new int[5];
int sumNegative = 0;
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(-10, 100);
    if(i%2 > 0) sumNegative += Array[i];
}
Console.WriteLine(String.Join(" ", Array));
Console.WriteLine(sumNegative);