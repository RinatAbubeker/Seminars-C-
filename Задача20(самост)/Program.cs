// Программу, которая принимает на вход коорд двух точек и находит расстояние между ними в 2D пространстве.
// AB = √(xb - xa)2 + (yb - ya)2

Console.Clear();             
Console.Write("введите координаты точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
int yB = Convert.ToInt32(Console.ReadLine());
double num = Math.Pow((xB-xA), 2) + Math.Pow((yB-yA), 2);
double AB = Math.Sqrt(num);
Console.Write($"Длина отрезка AB={AB.ToString("0.000")}");

