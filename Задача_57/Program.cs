// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
            
int[,] array = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(1,10);
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}

int trigger = 0;
int[,] dictionary = new int [rows * columns, 2];
int count = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        trigger = 0;
        for (int k = 0; k < count; k++)
        {
            if (dictionary[k, 0] == array[i, j])
            {
                dictionary[k, 1]++;
                trigger = 1;
                break;
            }
        }
        if (trigger == 0)
        {
            dictionary[count, 0] = array[i, j];
            dictionary[count, 1]++;
            count++;
        }
    }
}

for (int i = 0; i < count; i++)
{
    for (int j = 0; j < dictionary.GetLength(1); j++)
    {
        Console.Write($"{dictionary[i, j]} ");
    }
    Console.WriteLine();
}