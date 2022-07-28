//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

int[,] numbers = new int [4,4];
void Spiral(int row, int col)
{
    int count = 1;
    for (col = 0; col < numbers.GetLength(1)-1;col++)
    {
        numbers[row,col] = count;
        count++;
    }
    for (row = 0; row < numbers.GetLength(0)-1; row++)
    {
        numbers[row,col] = count;
        count++;
    }
    for (col = numbers.GetLength(1)-1; col > 0; col--)
    {
        numbers[row,col] = count;
        count++;
    }
     for (row = numbers.GetLength(0)-1; row > 0; row--)
    {
        numbers[row,col] = count;
        count++;
    }
    row=1;
    col=1;
    while(count < numbers.GetLength(0) * numbers.GetLength(1) + 1)
    {
        if(numbers[row,col] == 0)
        {
            numbers[row,col] = count;
            count++;
        }
        else if(numbers[row, col+1] == 0)
        {
            col++;
            numbers[row,col] = count;
            count++;
        }
        else if(numbers[row+1, col] == 0)
        {
            row++;
            numbers[row,col] = count;
            count++;
        }
        else if(numbers[row, col-1] == 0)
        {
            col--;
            numbers[row,col] = count;
            count++;
        }
        else if(numbers[row-1, col] == 0)
        {
            row--;
            numbers[row,col] = count;
            count++;
        }
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
Spiral(0,0);
PrintArray(numbers);