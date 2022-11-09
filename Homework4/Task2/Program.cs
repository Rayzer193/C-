//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите число:");
int itog = 0;
while (number>0)
{
    itog = itog + (number%10);
    number = number/10;

}
System.Console.Write($"Сумма цифра равна {itog}");
