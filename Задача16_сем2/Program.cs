// Прогр которая принимает на вход два числа и проверяет является ли одно число квадратом другого
Console.Clear();
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a * a  == b)
{
    Console.WriteLine("Число B квадрат числа A");
    return;
}
if (Math.Pow(b, 2) == a)
{
    Console.WriteLine("Число A квадрат числа B");
}
else
{
Console.WriteLine("Не является");
}