//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3 ?

void CountPositiveElements(int m)
{
    int sumPositive = 0;
    int[] numbers = new int[m];
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите число {i+1} из {m}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        if(numbers[i] > 0) sumPositive += 1;
    }
    Console.WriteLine($"Введено чисел больше нуля: {sumPositive}.");
}
Console.Write("Введите общее колличество чисел: ");
CountPositiveElements(Convert.ToInt32(Console.ReadLine()));