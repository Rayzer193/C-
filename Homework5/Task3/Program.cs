//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int dlin = 8;
int niz = 1;
int verh = 9;
double razn;

double[] CreateArray(int Length = 100)
{
    double[] tempArray = new double[Length];
    for (int i = 0; i < dlin; i++)
    {
        tempArray[i] = new Random().Next(niz,verh+1)+new Random().NextDouble();
    }
    return tempArray;
}

void prdbltArray(double[] dblArray)
{
    System.Console.Write("[");
    System.Console.Write(value: $"{Math.Round(dblArray[0],0)}");
    double min = dblArray[0];
    double max = dblArray[0];
    for (int i = 1; i< dlin; i++)
    {
        System.Console.Write(value: $",{Math.Round(dblArray[i],0)}");
        if(Math.Round(dblArray[i],0) > max)
        {
            max = dblArray[i];
        }
        if(Math.Round(dblArray[i],0) < min)
        {
            min = dblArray[i];
        }
    }
    razn = max - min;
    System.Console.Write("]");
}


Console.Write("Массив:");
prdbltArray(dblArray: CreateArray());
Console.WriteLine("");
Console.WriteLine( $"Разница между максимальным и минимальным элементов массива:{Math.Round(razn,0)}");