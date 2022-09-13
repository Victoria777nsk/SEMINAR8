// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GetArray()
{
    Console.Write("Введите количество строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
            
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(10,100);
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] ChangeRows(int[,] NewArray)
{
    Console.WriteLine("Изменённый массив: ");
    for (int i = 0; i < NewArray.GetLength(1); i++)
    {
        var temp = NewArray[NewArray.GetLength(0) - 1, i];
        NewArray[NewArray.GetLength(0) - 1, i] = NewArray[0, i];
        NewArray[0, i] = temp;
    }
    return NewArray;
}

void PrintArray(int [,] NewArray)
{
    for (int i = 0; i < NewArray.GetLength(0); i++)
    {
        for (int j = 0; j < NewArray.GetLength(1); j++)
        {
            Console.Write($"{NewArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

PrintArray(ChangeRows(GetArray()));