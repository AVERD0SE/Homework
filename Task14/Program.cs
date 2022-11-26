// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Задайте (числом) размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] number = new double[length];
FillArrayRandNum(number);
Console.WriteLine("Получившийся массив: ");
PrintArray(number);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < number.Length; j++){
    if (number[j] > max){
            max = number[j];
        }
    if (number[j] < min){
            min = number[j];
        }
}

Console.WriteLine($"В массиве всего {number.Length} числа(-ел). Максимальное значение элемента = {max}, минимальное = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значениями = {max - min}");

void FillArrayRandNum(double[] number){
    for(int i = 0; i < number.Length; i++){
            number[i] = Convert.ToDouble(new Random().Next (10, 100)) / 10;
        }
}
void PrintArray(double[] number){
    Console.Write("[");
    for(int i = 0; i < number.Length; i++){
            Console.Write(number[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}