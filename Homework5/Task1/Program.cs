//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int dlin = 8;
int niz = 100;
int verh = 999;
int num = 0;

int[] CreateArray(int Length = 100)
{
    int[] tempArray = new int[Length];
    for (int i = 0; i < dlin; i++)
    {
        tempArray[i] = new Random().Next(niz,verh+1);
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    System.Console.Write("[");
    System.Console.Write(value: $"{intArray[0]}");
    for (int i = 1; i< dlin; i++)
    {
        System.Console.Write(value: $",{intArray[i]}");
        if(intArray[i] % 2 == 0)
        {
            num = num + 1;
        }
    }
    System.Console.Write("]");
}


Console.Write("Массив:");
printArray(intArray: CreateArray());
Console.WriteLine("");
Console.WriteLine($"Колличество четных элементов:{num}");