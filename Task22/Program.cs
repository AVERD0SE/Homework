// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {CountNaturalSum(m, n)}");

int InputInt(string input)
{
    Console.Write(input);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return n + CountNaturalSum(m, n - 1);
}