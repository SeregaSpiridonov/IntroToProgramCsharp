//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//и
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49

int[,] array = {{1, 4, 7, 2},
                {5, 9, 2, 3}, 
                {8, 4, 2, 4}, 
                {5, 2, 6, 7}};
int[,] array2 = {{1, 5, 8, 5},
                 {4, 9, 4, 2}, 
                 {7, 2, 2, 6}, 
                 {2, 3, 4, 7}};

int[,] MatrixMultiplication(int[,] numbers, int[,]numbers2)
{
    int[,] result = new int[numbers.GetLength(0), numbers.GetLength(1)];
    if(numbers.GetLength(0) == numbers2.GetLength(0) && 
        numbers.GetLength(1) == numbers2.GetLength(1))
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                result[i, j] = numbers[i, j] * numbers2[i, j];
            }
        }
        return result;
    }
    else
    {
        Console.WriteLine("Масссивы разного размера.");
        return result;
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine("");
    }
}
PrintArray(MatrixMultiplication(array, array2));