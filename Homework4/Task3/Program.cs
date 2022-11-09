//Напишите программу, которая задаёт массив из кооличства элементов введенного пользователем, генеруриет массив из случайных значений между указанными пользователем, и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

System.Console.Write("Сколько элементов будет в вашем массиве?(число от 1 до 100):");
int dlin = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Минимальное значение  эелемента массива:");
int niz = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Максимальное значение элемента массива:");
int verh = Convert.ToInt32(Console.ReadLine());

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
    }
    System.Console.Write("]");
}

printArray(intArray: CreateArray());