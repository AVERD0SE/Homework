// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите желаемое количество строк массива: ");
int numLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите желаемое количество столбцов массива: ");
int numColumns = Convert.ToInt32(Console.ReadLine());
int[,] number = new int[numLines, numColumns];
FillArrayRandomNumbers(number);
Console.WriteLine();
Console.WriteLine("Получившийся массив: ");
PrintArray(number);

for (int i = 0; i < number.GetLength(0); i++){
    for (int j = 0; j < number.GetLength(1) - 1; j++)
    {
        for (int n = 0; n < number.GetLength(1) - 1; n++)
        {
            if (number[i, n] < number[i, n + 1])
            {
                int temp = 0;
                temp = number[i, n];
                number[i, n] = number[i, n + 1];
                number[i, n + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными по убыванию элементами: ");
PrintArray(number);

void FillArrayRandomNumbers(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}