//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int dlin = 8;
int niz = 1;
int verh = 99;
int summ = 0;

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
        if(i % 2 == 1)
        {
            summ = summ + intArray[i];
        }
    }
    System.Console.Write("]");
}


Console.Write("Массив:");
printArray(intArray: CreateArray());
Console.WriteLine("");
Console.WriteLine($"Сумма нечетных элементов:{summ}");