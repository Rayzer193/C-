//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

System.Console.Write("Сколько чисел вы будете вводить?(число от 1 до 100):");
int dlin = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int Length = 100)
{
    int[] tempArray = new int[Length];
    for (int i = 0; i < dlin; i++)
    {
        System.Console.Write($"Введите {i+1} число: ");
        tempArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return tempArray;
}

void NumbersGreaterZero(int[] tempArray)
{
    int count = 0;
    for(int i = 0; i < dlin; i++)
    {
        if(tempArray[i]>0)
            count = count + 1;
    }
    System.Console.WriteLine($"Количество элементов больших нуля: {count}");
}

NumbersGreaterZero(tempArray: CreateArray());