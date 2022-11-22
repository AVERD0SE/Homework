// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int N = 10;
int i = 1;

while(i <= N)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i = i + 1;
}

//Решение 2 с вводом N в терминале
//Console.WriteLine("Введите N: ");
//int N = int.Parse(Console.ReadLine());
    
//for (int i = 1; i <= N; i++)
//    if (i % 2 == 0)
//        Console.WriteLine(i);