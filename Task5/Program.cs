// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
string input = Console.ReadLine();
int stringlen = 3;
int inputlen = input.Length;
if (inputlen == stringlen)
{
    Console.WriteLine("{0}->{1}",input, input[1]);
}
else
{
    Console.WriteLine("Введено не трёхзначное число");
}