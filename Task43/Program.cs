Console.WriteLine("Данная программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2. Значения для уравнения: b1, k1, b2 и k2 задаются пользователем.");

Console.Write("Введите любое значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите любое значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите любое значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите любое значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = (k1 * x + b1);

Console.WriteLine($"Точкой пересечения двух прямых - является точка с координатами X: {x}, Y: {y}");

if ((k1 == k2) && (b1 == b2))
{
Console.WriteLine($"Координаты прямых совпадают!");
}
else if (k1 == k2)
{
Console.WriteLine($"Координаты прямых параллельны!");
}