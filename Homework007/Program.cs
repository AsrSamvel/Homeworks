// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//   double[,] newArray = new double[rows, colums];
//   for (int i = 0; i < rows; i++)
//   {
//     for (int j = 0; j < colums; j++)
//     {
//       newArray[i, j] = new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(),2);
//     }
//   }
//   return newArray;
// }

// void Show2DArray(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
//   Console.WriteLine();
// }

// Console.WriteLine("Введите количество строк массива: ");
// int rows  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива: ");
// int colums  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число массива: ");
// int minValue  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число массива: ");
// int maxValue  = Convert.ToInt32(Console.ReadLine());

// double[,] array = Create2DRandomArray(rows, colums, minValue, maxValue);
// Show2DArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//   int[,] newArray = new int[rows, colums];
//   for (int i = 0; i < rows; i++)
//   {
//     for (int j = 0; j < colums; j++)
//     {
//       newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//     }
//   }
//   return newArray;
// }

// void Show2DArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
//   Console.WriteLine();
// }

// void CheckArray(int[,] array, int rows, int colums)
// {
//   if (rows > array.GetLength(0) || colums > array.GetLength(1) || rows <= 0 || colums <= 0)
//   {
//     Console.WriteLine($"Позиции ({rows},{colums}) нет в таблице");
//   }
//   else Console.WriteLine($"Согласно заданной Вами позиции ({rows},{colums}), значение элемента -> {array[rows-1, colums-1]}");
// }

// Console.WriteLine("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Выберите строку для поиска необходимого элемента: ");
// int findRows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Выберите столбец для поиска необходимого элемента ");
// int findColums = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(rows, colums, minValue, maxValue);
// Show2DArray(array);
// CheckArray(array, findRows, findColums);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
{
  int[,] newArray = new int[rows, colums];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < colums; j++)
    {
      newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return newArray;
}

void Show2DArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

void PrintArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}


double[] ArithMean(int[,] array)
{
  double[] newArray = new double[array.GetLength(1)];
  double summa = 0;
  for (int i = 0; i < array.GetLength(1); i++)
    {
      for (int j = 0; j < array.GetLength(0); j++)
      {
        summa += array[j, i];
      }
      newArray[i] = Math.Round(summa / array.GetLength(0),2);
      summa = 0;
    }
  return newArray;
}

Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DRandomArray(rows, colums, minValue, maxValue);
Show2DArray(array);
double[] srArArray = ArithMean(array);
Console.Write("Среднее арифмитическое элементов в каждом столбце -> ");
PrintArray(srArArray);
