//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
System.Console.WriteLine("Нахождение точки пересечения двух уровнений");
System.Console.WriteLine("Для уравнения вида y = k * x + b введите ");
System.Console.Write("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
System.Console.Write($"Координаты точки пересечения: ({x};{y})");