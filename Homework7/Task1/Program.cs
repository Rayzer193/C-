//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -99,9
//8 7,8 -7,1 9

Console.WriteLine("Задайте количество строк двумерного массива:");
int vys = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int dlin = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Минимальное значение  эелемента массива:");
int niz = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Максимальное значение элемента массива:");
int verh = Convert.ToInt32(Console.ReadLine());

double[,] CreatMatrix()
{ 
    double[,] matrix = new double[vys,dlin];
    for (int i = 0; i < vys; i++)
    { 
        for (int j = 0; j < dlin; j++)
        { 
            matrix[i,j] = new Random().Next(niz, verh) + new Random().NextDouble();
        }
    }
    return matrix;
}

void PrintMatrix(double[,] printmatrix)
{ 
    
    for (int i = 0; i < vys; i++)
    { 
        for (int j = 1; j < dlin; j++)    
        {
            Console.Write(String.Format("{0,8}",$"{Math.Round(printmatrix[i, j],1)}|"));
        }
        Console.WriteLine();
    }
}

PrintMatrix(printmatrix: CreatMatrix());