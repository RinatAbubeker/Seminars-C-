// Напишите программу которая будет принимать на вход два числа и выводить, является ли второе число, кратным первому.
//Если второе число не кратно первому ,то программа выводит остаток деления/
Console.Clear();
Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num%num2 ==0) {
    Console.WriteLine("Кратно ");
}
else {
    Console.WriteLine($"Не кратно {num%num2}");
} 