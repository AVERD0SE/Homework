// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
//int stringlen = 3;
//int inputlen = input.Length;
for (int i = 0; i <= i + 2; i++)
{
    Console.WriteLine("{0}->{1}",input, input[2]);
    break;
}
Console.WriteLine("Третьей цифры нет");

//    while(input < inputlen)
//    {
//        if(inputlen == stringlen)
//            Console.WriteLine("{0}->{1}",input, input[1]);
//            break;
//    }

//int N = int.Parse(Console.ReadLine());
    
//for (int i = 1; i <= N; i++)
//    if (i % 2 == 0)
//        Console.WriteLine(i);