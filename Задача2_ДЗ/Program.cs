Console.Clear();    // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());
if (num_A > num_B)
{
    Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
}
else
{
    Console.Write("Второе число " + num_B + " больше чем первое " + num_A ) ;
}
return;