//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) ?

void LineIntersection(double a1, double z1, double a2, double z2)
{
    if(a1 == a2 & z1 != z2)
    {
        Console.WriteLine("Прямые параллельны и не пересекаются.");
    }
    if(a1 != a2)
    {
        double x = (z2 - z1) / (a1 - a2);
        double y = a1 * x + z1;
        Console.WriteLine($"Точка пересечения: ({x}, {y})");
    }
    if(a1 == a2 & z1 == z2)
    {
        Console.WriteLine("Прямые параллельны.");
    }
}
void DataEntryForEquations()
{
    Console.WriteLine("Введите данные для уравнений прямых вида:");
    Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2;");
    
    Console.Write("Введите k1: ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b1: ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите k2: ");
    int k2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b2: ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    
    LineIntersection(k1, b1, k2, b2);
}
DataEntryForEquations();