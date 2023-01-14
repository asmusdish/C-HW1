// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Выводит массив всех четных чисел от 1 до N");
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
for (int i = 2; i <= N; i = i + 2)
{
    Console.WriteLine(i);
}