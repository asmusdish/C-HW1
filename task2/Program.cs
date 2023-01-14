// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Нахождение максимального числа из трех");
Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int z = int.Parse(Console.ReadLine());
int max = x;
if (y > max) max = y;    
if (z > max) max = z;
Console.WriteLine("max = " + max);