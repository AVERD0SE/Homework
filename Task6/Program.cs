// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

//Console.WriteLine("Введите число: ");
//string input = Console.ReadLine();
//int stringlen = 3;
//int inputlen = input.Length;
//for (int i = 0; i <= inputlen; i++)
//{
//    Console.WriteLine("{0}->{1}",input, input[2]);
//    break;
//}
//Console.WriteLine("Третьей цифры нет");

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int inputlen = input.Length;
int index = 2;
if (inputlen >= index + 1)
{
    Console.WriteLine("{0}->{1}",input, input[index]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}