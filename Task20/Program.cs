// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2.

int size1 = InputInt("Введите размерность 1: ");
int size2 = InputInt("Введите размерность 2: ");
int size3 = InputInt("Введите размерность 3: ");

int[,,] result = Create3DMassive(size1, size2, size3);

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        for (int n = 0; n < result.GetLength(2); n++)
        {
            Console.WriteLine($"[{i},{j},{n}] - {result[i, j, n]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[size1 * size2 * size3];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = num
        ++;
    }

    for (int i = 0; i < values.Length; i++)
    {
        int randIndex = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randIndex];
        values[randIndex] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                array[i, j, n] = values[valueIndex++];
            }
        }
    }
    return array;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}