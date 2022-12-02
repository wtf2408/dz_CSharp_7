// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите 1 позицию элкмента: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 позицию элкмента: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2dArray(3, 4);
PrintArray2d(array);
if (PositionElementInArray(array, i, j))
{
    Console.WriteLine(array[i,j]);
}
else
{
    Console.WriteLine("такого элемента нет.");
}
;

bool PositionElementInArray(int [,] arr, int i, int j)
{
    
    if (i < arr.GetLength(0) && j < arr.GetLength(1) && i>=0 && j>=0) return true;
    else return false; 
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
int[,] Create2dArray(int length0, int length1)
{
    int[,] arr = new int[length0, length1];
    Random random = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(0, 20);
        }
    }
    return arr;
}