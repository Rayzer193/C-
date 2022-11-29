//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"
Console.Clear();
Console.Write("Задайте первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число:");
int n = Convert.ToInt32(Console.ReadLine());

void PrintChet (int m, int n)
{
    if (n < m)
    {
        return;
    }
    if(m%2==0)
    {
        Console.Write(m);
        if(m<n-1)
        {
            Console.Write(',');
        }
    }
    PrintChet(m+1,n);
}
Console.Write('"');
PrintChet(m,n);
Console.Write('"');