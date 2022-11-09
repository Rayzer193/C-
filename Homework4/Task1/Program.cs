 //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt("Введите число:");
int power = Prompt("Введите степень:");
int i =1;
int itog = number;
while(i < power)
{
    itog = itog * number;
    i = i + 1;
}
System.Console.WriteLine($"Число {number} в степени {power} равно {itog}");