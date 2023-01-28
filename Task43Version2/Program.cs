double x = 0;

Console.WriteLine("Данная программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2. Значения для уравнения: b1, k1, b2 и k2 задаются пользователем.");

Console.Write("Введите любое значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите любое значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите любое значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите любое значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

Console.Write($"Точкой пересечения двух прямых - является точка с координатами Y1: {y1}, Y2: {y2}");