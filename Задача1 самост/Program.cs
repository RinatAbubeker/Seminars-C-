Console.Clear(); // на вход два числа и проверяет , является ли первое число квадратом второго
Console.Write("Введите А: ");
int number1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int number2=Convert.ToInt32(Console.ReadLine());
if(number2*number2==number1)
{
    Console.Write("А является квадратом B");
}
else
{
    Console.Write("А не является квадратом B");
}
