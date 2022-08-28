/* Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.WriteLine("Задача 50. Программа принимает позицию элемента и возвращает его значение, или указывает, что такого элемента нет.");
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

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
int [,] array = new int[m,n];

Console.WriteLine("Введите номер строки:");
int matrixRow = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите номер столбца:");
int matrixColumn = Convert.ToInt32(Console.ReadLine()) - 1;

if (matrixRow < 0 | matrixRow > array.GetLength(0) - 1 | matrixColumn < 0 | matrixColumn > array.GetLength(1) - 1)
    {
    Console.WriteLine("Элемент не существует");
    }
else
   {
    Console.WriteLine($"Значение элемента массива -> {array[matrixRow, matrixColumn]}");
   }
   
FillArray(array);
PrintArray(array);
Console.WriteLine();



