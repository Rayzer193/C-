//Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

Console.Clear();

void WriteMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i,j] / 10 <= 0)
        {Console.Write($" {matrix[i,j]} ");}
        else 
        {Console.Write($"{matrix[i,j]} ");}
    }
    Console.WriteLine();
  }
}

int[,] SpiralMatrix = new int[4, 4];
int number = 1;
int i = 0;
int j = 0;

while (number <= SpiralMatrix.GetLength(0) * SpiralMatrix.GetLength(1))
{
  SpiralMatrix[i, j] = number;
  number = number + 1;
  if (i <= j + 1 && i + j < SpiralMatrix.GetLength(1) - 1)
    j = j + 1;
  else if (i < j && i + j >= SpiralMatrix.GetLength(0) - 1)
    i = i + 1;
  else if (i >= j && i + j > SpiralMatrix.GetLength(1) - 1)
    j = j - 1;
  else
    i = i - 1;
}

WriteMatrix(SpiralMatrix);