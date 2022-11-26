// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Задайте (числом) размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] number = new int[length];
FillArrayRandNum(number);
Console.WriteLine("Получившийся массив: ");
PrintArray(number);
int sum = 0;

for (int j = 0; j < number.Length; j+=2)
    sum = sum + number[j];

Console.WriteLine($"В массиве всего {number.Length} числа(-ел). Сумма элементов, стоящих на нечётных позициях = {sum}.");

void FillArrayRandNum(int[] number){
    for(int i = 0; i < number.Length; i++){
            number[i] = new Random().Next (1, 100);
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