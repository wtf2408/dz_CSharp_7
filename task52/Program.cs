// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. Поиск среднее арифметического в отдельном методе. Для создания массива и вывода можно воспользоваться методами из 47 задачи.
int[,] Create2dArray(int length0, int length1)
{
    int[,] arr = new int[length0, length1];
    Random random = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(0, 20) ;
        }
    }
    return arr;
}
void PrintArray2d(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticMean(int[,] arr)
{
    double sum = 0;
    double[] arrSum = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j,i] ;
        }
        arrSum[i] = Math.Round((sum / arr.GetLength(0)) , 1) ;
        sum = 0;
    }
    return arrSum;
}
int[,] array = Create2dArray(3,4);
PrintArray2d(array);
double [] res = ArithmeticMean(array);
foreach (var item in res)
{
    Console.Write($"{item} ");
}



