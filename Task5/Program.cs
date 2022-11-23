// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

//Console.Clear();

//Console.WriteLine("Введи трёхзначное число: ");

//int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine());
//string stringNumber = Convert.ToString(ThreeDigitNumber);

//Console.WriteLine("Вторая цифра введённого числа: " +stringNumber[1]);

Console.WriteLine("Введите трехзначное число: ");
string input = Console.ReadLine();
int stringlen = 3;
int inputlen = input.Length;
    while(true)
    {
        if(inputlen == stringlen)
            Console.WriteLine("{0}->{1}",input, input[1]);
            break;
    }
    