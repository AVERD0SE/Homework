// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Задайте (цифрой) размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] number = new int[length];
FillArrayRandNum(number);
Console.WriteLine("Получившийся массив: ");
PrintArray(number);
int count = 0;

for (int j = 0; j < number.Length; j++)
if (number[j] % 2 == 0)
count++;

Console.WriteLine($"В массиве всего {number.Length} числа(-ел), {count} из них - чётные.");

void FillArrayRandNum(int[] number){
    for(int i = 0; i < number.Length; i++){
        number[i] = new Random().Next (100, 1000);
    }
}
void PrintArray(int[] number){
    Console.Write("[");
    for(int i = 0; i < number.Length; i++){
        Console.Write(number[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}