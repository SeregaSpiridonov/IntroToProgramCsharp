//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)

int[] RandomNumbers(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100);
        for (int j = i-1; j == 0; j--)
        {
            if(array[i] == array[j])
            {
                array[i] = new Random().Next(0, 100);
            }
        }
    }
    return array;
}
int[,,] CubeArray(int[] array)
{
    int[,,] result = new int[2, 2, 2];
    int count = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = array[count];
                count++;
            }
        }
    }
    return result;
}
void PrintCubeArray(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write($"{cube[i, j, k]}({i}, {j}, {k})");
            }
            Console.WriteLine("");
        }
    }
}
PrintCubeArray(CubeArray(RandomNumbers(8)));