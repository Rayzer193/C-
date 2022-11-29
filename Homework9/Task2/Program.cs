//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30
Console.Clear();
Console.Write("Задайте первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число:");
int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;
void PrintChet (int m, int n)
{
    if (n < m)
    {
        return;
    }
    summ += m;
    PrintChet(m+1,n);
}


PrintChet(m,n);
Console.WriteLine(summ);