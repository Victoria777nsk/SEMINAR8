// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] TurnArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Перевёрнутый массив: ");

    int length = array.GetLength(0);
    int[,] newArray = new int[length,length];

    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++) 
        {
            for (int j = 0; j < array.GetLength(0); j++) 
            {
                newArray[i, j] = array[j, i];
                Console.Write($"{newArray[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Данный массив невозможно развернуть!");
    }
    return newArray;
}

TurnArray(GetArray());