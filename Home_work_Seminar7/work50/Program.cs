// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int[,] numbersMatrix = {{1, 4, 7, 2},
                        {5, 9, 2, 3},
                        {8, 4, 2, 4}};
void SearchNumber(int[,] matr, int num)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i, j] == num)
            {
                Console.WriteLine($"Указанное число находится на строке: {i+1}, столбце {j+1}");
                count += 1;
            }
        }
    }
    if(count == 0) Console.WriteLine("Такого числа нет в массиве");
}
int NumberRequest()
{
    Console.Write("Введите число для поиска в массиве: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
SearchNumber(numbersMatrix, NumberRequest());