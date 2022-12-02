// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. Сделать отдельный метод который генерирует двумерный массив и отдельный метод который выводит его на экран.
// m и n вводит пользователь в консоль
// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintArray(Create2dArray(m, n));

double[,] Create2dArray(int length0, int length1)
{
    double[,] arr = new double[length0, length1];
    Random random = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(-20,20)+Math.Round(random.NextDouble(),1);
        }
    }
    return arr;
}

void PrintArray (double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}
