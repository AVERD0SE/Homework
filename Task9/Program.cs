// Задача 25: Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя

int Exp(int A, int B)
{
  int result = 1;
  for(int i=1; i <= B; i++)
  {
    result = result * A;
  }
    return result;
}
  Console.Write("Введите число A: ");
  int A = Convert.ToInt32(Console.ReadLine());
  
  Console.Write("Введите число B: ");
  int B = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exp(A, B);
  Console.WriteLine("A ^ B = " + exponentiation);