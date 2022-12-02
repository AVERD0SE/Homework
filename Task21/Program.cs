// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int n = InputInt("Введите натуральное число: ");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Введено не натуральное число");
    return;
}
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
    {
        return n;
    }
    else
    {
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    }
    return m;
}

int InputInt(string input)
{
    Console.Write(input);
    return int.Parse(Console.ReadLine());
}