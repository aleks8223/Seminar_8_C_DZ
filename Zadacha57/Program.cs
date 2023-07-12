// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
int minValue = 0;
int maxValue = 10;
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
CountElements(array, minValue, maxValue);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CountElements(int[,] inArray, int minValue, int maxValue)
{
    for (int i = minValue; i < maxValue; i++)
    {
        int count = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            for (int k = 0; k < inArray.GetLength(1); k++)
            {
                if (inArray[j, k] == i) count++;
            }
        }
        if (count != 0) Console.WriteLine($"Число {i} встречается {count} раз. ");
    }
}
