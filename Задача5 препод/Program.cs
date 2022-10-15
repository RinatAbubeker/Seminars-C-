Console.Clear();    //на вход принимает одно целое число на выходе показывает 2 -> -2,-1,0,1,2
int N=Convert.ToInt32(Console.ReadLine());
if (N < 0)
N = -N;
int B = -N;
while (B<=N)
{
    Console.WriteLine($"{B}");
    B++;
}