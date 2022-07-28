// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
for(int index=0; index < array.Length; index++)
{
    array[index] = new Random().Next(0, 100);
}
for(int position=0; position < array.Length; position++)
{
    Console.Write(array[position]+", ");
}