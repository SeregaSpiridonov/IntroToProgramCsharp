// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] numbersMatrix = {{1, 4, 7, 2}, 
                        {5, 9, 2, 3}, 
                        {8, 4, 2, 4}};
void AverageColumn(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double average = 0;
        double sum = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sum += matr[j, i];
        }
        average = sum / matr.GetLength(0);
        Console.Write($"{Math.Round(average, 2)}; ");
    }
}
AverageColumn(numbersMatrix);