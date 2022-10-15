Console.Clear(); //на вход принимает одно целое число на выходе показывает 2 -> -2,-1,0,1,2

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

int number = Math.Abs(N);

for (int i = number * (-1); i <= number; i++) {
Console.Write($"{i} ");
}
Console.WriteLine("");
