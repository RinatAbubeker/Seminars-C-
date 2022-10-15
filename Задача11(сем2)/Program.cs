Console.Clear();                     // программа которая выводит случайное число и удаляет вторую цифру этого числа
int num = new Random().Next(100,1000);
int num2 = num / 100;
int num3 = num % 10;

Console.WriteLine($"{num}-{(num2*10)+ num3}");
