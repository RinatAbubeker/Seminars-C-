Console.Clear();  // Программа которая принимает трехзначное число и на выходе показывает его последн цифру
Console.WriteLine("Введите трёхзначное число ");
int num=Convert.ToInt32(Console.ReadLine());
int y=num%10;

Console.WriteLine($"{y}");
