// Программа которая принимает на вход число и проверяет, кратно ли оно одновр 7 и 23
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if((num % 7 == 0) && (num % 23 ==0))
{
    Console.WriteLine("да");
}else{
    Console.WriteLine("Нет");
}