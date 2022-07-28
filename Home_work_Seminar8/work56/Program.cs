//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = {{1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4},
                {5, 2, 6, 7},
                {3, 2, 0, 7}};

void LowerLineAmount(int[,] numbers)
{
    int sum2 = 0;
    int line = 1;
    for (int k = 0; k < numbers.GetLength(1); k++)
    {
        sum2 += array[0, k];
    }
    for (int i = 1; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum += numbers[i, j];
        }
        if(sum2 > sum) 
        {
            sum2 = sum;
            line = i+1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {line}.");
}
LowerLineAmount(array);