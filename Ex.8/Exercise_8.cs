// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int N2 = 1;
int i = 1;

Console.Write($"Чётные числа от 1 до {N}: ");
while (i <= N)
{
    if (N2 % 2 == 0)
    {
        Console.Write($"{N2}, ");
        N2++;
        i++;
    }
    else
    {
        N2++;
        i++;
    }
}