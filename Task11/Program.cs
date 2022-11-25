// Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.

int number(string text)
{
  Console.Write(text);
  int value = int.Parse(Console.ReadLine());
  return value;
}

int[] CreateArray(int n)
{
    return new int[n];
}

void Fill(int[] array, int min, int max)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      array[i] = number($"Array[{i}]: ");
    }
  }

string PrintArray(int[] numbers)
{
    string result = "[ ";
    int size = numbers.Length;
    for(int i = 0; i < size; i++)
    {
        result += ($"{numbers[i]} ");
    }
    return result + "]";
}

int[] array = CreateArray(8);
Fill(array, 1, 10);
Console.WriteLine(PrintArray(array));