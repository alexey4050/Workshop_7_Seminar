/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Задача 52. Задать двумерный массив. Найти среднее арифметическое элементов в каждом столбце.");
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

int [,] array = new int [m,n];
FillArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double arithmeticMean = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        arithmeticMean += array[i,j];
    }
    arithmeticMean = Math.Round(arithmeticMean / m, 1);

    Console.WriteLine($"Среднее арифметическое каждого столбца № {j+1}: {arithmeticMean}");
}
Console.WriteLine();
PrintArray(array);

void FillArray (int [,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)   
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray (int [,] matr)
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






