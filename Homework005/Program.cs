// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//   int[] array = new int[size];
//   for (int i = 0; i < size; i++)
//   {
//     array[i] = new Random().Next(minValue, maxValue + 1);
//   }
//   return array;
// }

// void PrintArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write(array[i] + " ");
//   }
//   Console.WriteLine();
// }

// int FreqNum (int[] array)
// {
//   int summ = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] % 2 == 0) summ++;
//   }
//   return summ;
// }

// Console.WriteLine("Введите длину массива: ");
// int size  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число массива: ");
// int minValue  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число массива: ");
// int maxValue  = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// Console.WriteLine($"Количество четных элементов в массиве -> {FreqNum(myArray)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//   int[] array = new int[size];
//   for (int i = 0; i < size; i++)
//   {
//     array[i] = new Random().Next(minValue, maxValue + 1);
//   }
//   return array;
// }

// void PrintArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write(array[i] + " ");
//   }
//   Console.WriteLine();
// }

// int SumElem (int[] array)
// {
//   int sum = 0;
//   for(int i = 0; i < array.Length/2; i++)
//   {
//     sum += array[2*i + 1];
//   }
//   return sum;
// }

// Console.WriteLine("Введите длину массива: ");
// int size  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число массива: ");
// int minValue  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число массива: ");
// int maxValue  = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// Console.WriteLine($"Сумма нечетных элементов в нашем массиве -> {SumElem(myArray)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandomArray(int size, int maxValue, int minValue)
{
  double[] array = new double[size];
  for (int i = 0; i < size; i++)
  {
    // array[i] = Math.Round(new Random().NextDouble() * 100,2); //от 0 до 100 потому что NextDouble принмает значение от 0.0 до 1.0
    // array[i] = (maxValue - minValue) * Math.Round(new Random().NextDouble(),2) + minValue;

    array[i] = new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(),2); 
    //Другого варианта я не нашел :( не понял как заполнить массив и целыми числами и дробными
  }
  return array;
}

void PrintArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

double Diff (double[] array)
{
  double max = 0;
  double min = array[0];
  double razn = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > max) max = array[i];
    else if (array[i] <= min) min = array[i];
  }
return razn = max - min;
}

Console.WriteLine("Введите длину массива: ");
int size  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int minValue  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int maxValue  = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, maxValue, minValue);

PrintArray(myArray);

Console.WriteLine($"Разница между максимальным и минимальным элементов массива -> {Diff(myArray)}");
