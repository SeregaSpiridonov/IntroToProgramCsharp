// SЗадача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8

int[,] array = {{1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4}};
                
int[,] DescendingSort(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int count = 0; count < numbers.GetLength(1)-1; count++)
        {
            for (int j = 0; j < numbers.GetLength(1)-1; j++)
            {
                if(numbers[i, j+1] > numbers[i, j])
                {
                    int temp = numbers[i, j];
                    numbers[i, j] = numbers[i, j+1];
                    numbers[i, j+1] = temp;
                }
            }    
        }
    }
return numbers;
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
PrintArray(DescendingSort(array));