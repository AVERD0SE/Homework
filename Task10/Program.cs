// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int Sum = 0;

for (int i=3; i>=0; i--)
{
    Sum += N / (int)Math.Pow (10.0,i);
    N=N % (int)Math.Pow (10.0,i);
}

Console.WriteLine("Сумма всех цифр введённого числа: " + Sum);