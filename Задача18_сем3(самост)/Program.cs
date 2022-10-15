Console.Clear();    // По заданному номеру четверти,показывает диапазон возмож координат точек в той четверти(X и Y)
Console.Write("Введите номер четврти: ");
int X = Convert.ToInt32(Console.ReadLine());

if (X==1)
{
    Console.WriteLine("X>0&&Y>0");
}
if (X==2)
{
    Console.WriteLine("X<0&&Y>0");
}
if (X==3)
{
    Console.WriteLine("X<0&&Y<0");
}
if (X==4)
{
    Console.WriteLine("X>0&&Y<0");
}