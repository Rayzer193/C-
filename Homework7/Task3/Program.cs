//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
for (int j = 0; j < 4; j++)
{
    double summ = 0;
    double kol = 3;
    for (int i = 0; i < 3; i++)
    {
        summ = summ + Convert.ToDouble(matrix[i,j]);
    }
    double rez = summ/kol;
    Console.Write($"{Math.Round(rez,2)}");
    if (rez>0 && j<3)
    {
        Console.Write($";");
    }
}