// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = {3, 7.5, 22, 2, 78};
double temp = 0;
double difference = 0;

for(int i=0; i < array.Length; i++)
{
    for(int j=0; j < array.Length - 1; j++)
    {
        if(array[j] > array[j+1])
        {
            temp = array[j+1];
            array[j+1] = array[j];
            array[j] = temp;
        }
    }
}
difference = array[array.Length-1] - array[0];
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {difference}");