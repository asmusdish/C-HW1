// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Четное или нечетное число?");
Console.WriteLine("Введите целое число: ");
double number = int.Parse(Console.ReadLine());
number = number/2*10;
double res = number%10;
Console.WriteLine(number);
Console.WriteLine(res);
if (res == 0) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");