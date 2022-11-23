//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строкаConsole.Clear();
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


int SumLineElements(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine = sumLine + matrix[i,j];
  }
  return sumLine;
}

int[,] array = new int[vys, dlin];
CreateMatrix(array);
WriteMatrix(array);

int minSummLine = 0;
int summLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSummLine = SumLineElements(array, i);
  if (summLine > tempSummLine)
  {
    summLine = tempSummLine;
    minSummLine = i;
  }
}


Console.WriteLine($"{minSummLine+1} - строкa с наименьшей суммой элементов");
Console.WriteLine($"Наименьшая сумма элементов = {summLine}");