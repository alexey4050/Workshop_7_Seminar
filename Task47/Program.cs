/* Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
Console.WriteLine("Задача 47. Задайте двумерный массив, размером m x n, заполненный случайными вещественными числами.");
Console.Write("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов n: ");
int n = int.Parse(Console.ReadLine()!);

double [,] array = new double [m,n];

void FillArray (double [,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;

        }
    }
}
void PrintArray (double [,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++ )
    {
        Console.Write("[ ");
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine();

