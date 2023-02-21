// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Degree (int a, int b)
// {
//   int otvet = 1;
//   for (int i = 1; i <= b; i++)
//   {
//     otvet = otvet * a;
//   }
//   return otvet;
// }

// Console.WriteLine("Введите первое число: ");
// int num1  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Degree(num1, num2));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Summa (int number)
// {
//   int sum = 0;
//   while (number > 0)
//   {
//     sum = sum + number % 10;
//     number = number / 10;
//   }
//   return sum;
// }
// Console.WriteLine("Введите число: ");
// int num  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Summa(num));


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(minValue, maxValue + 1);
  }
  return array;
}

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

Console.WriteLine("Введите длину массива: ");
int size  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int minValue  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int maxValue  = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(myArray);