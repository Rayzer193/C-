//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
Console.Clear();
Console.Write("Задайте количество строк первого массива:");
int vys1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов первого массива, которое будет равно колличеству строк второго массива:");
int dlin1vys2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов второго массива:");
int dlin2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Минимальное значение элемента массива:");
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


void UmnozhenieMatrixs(int[,] firstMartrix, int[,] secomdMartrix, int[,] itogMatrix)
{
  for (int i = 0; i < itogMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < itogMatrix.GetLength(1); j++)
    {
      int summ = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        summ = summ + firstMartrix[i,k] * secomdMartrix[k,j];
      }
      itogMatrix[i,j] = summ;
    }
  }
}


int[,] firstMartrix = new int[vys1, dlin1vys2];
CreateMatrix(firstMartrix);
Console.WriteLine("Первая матрица:");
WriteMatrix(firstMartrix);

int[,] secomdMartrix = new int[dlin1vys2, dlin2];
CreateMatrix(secomdMartrix);
Console.WriteLine("Вторая матрица:");
WriteMatrix(secomdMartrix);

int[,] itogMatrix = new int[vys1,dlin2];

UmnozhenieMatrixs(firstMartrix, secomdMartrix, itogMatrix);
Console.WriteLine("Произведение первой и второй матриц:");
WriteMatrix(itogMatrix);