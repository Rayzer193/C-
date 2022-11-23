//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.Clear();
Console.Write("Задайте количество строк двумерного массива:");
int vys = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов двумерного массива:");
int dlin = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Минимальное значение  эелемента массива:");
int niz = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Максимальное значение элемента массива:");
int verh = Convert.ToInt32(Console.ReadLine());


void CreateMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(niz,verh+1);
    }
  }
}


void WriteMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
}


void Sortet(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}


int[,] array = new int[vys, dlin];
Console.WriteLine($"Изначальный массив: ");
CreateMatrix(array);
WriteMatrix(array);

Console.WriteLine($"Отсортированный массив: ");
Sortet(array);
WriteMatrix(array);