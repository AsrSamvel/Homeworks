// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// int[,] Organize(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1) - 1; j++)
//     {
//       int maxPosition = j;
//       for (int a = j + 1; a < array.GetLength(1); a++)
//       {
//         if (array[i, a] > array[i, maxPosition]) maxPosition = a;
//       }
//       int temporary = array[i, j];
//       array[i, j] = array[i, maxPosition];
//       array[i, maxPosition] = temporary;
//     }
//   }
//   return array;
// }

// Console.WriteLine("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(rows, colums, minValue, maxValue);
// Show2DArray(array);

// Show2DArray(Organize(array));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// !!!! МОЖНО БЫЛО КОНЕЧНО 2 МЕТОДА ОБЪЕДИНИТЬ, НО КАК-ТО НЕКРАСИВО ВСЁ ЭТО (в коде объединение методов закоментировано ) !!!!

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

// void ShowArray (int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write(array[i] + " ");
//   }
//   Console.WriteLine();
// }

// int[] FindRowsAmount(int[,] array)
// {
//   int[] newArray = new int[array.GetLength(0)];
//   int amount = 0;
//   // int minPosition = 0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         amount += array[i, j];
//     }
//     newArray[i] = amount;
//     amount = 0;
//   }

//   // for (int a = 0; a < newArray.Length; a++)
//   // {
//   //   if (newArray[a] < newArray[minPosition]) minPosition = a;
//   // }
//   // return minPosition + 1;
//   return newArray;
// }

// int FindMinAmount (int[] array)
// {
//   int minPosition = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] < array[minPosition]) minPosition = i;
//   }
//   return minPosition + 1;
// }

// Console.WriteLine("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(rows, colums, minValue, maxValue);
// Show2DArray(array);
// int[] newArray = FindRowsAmount(array);
// ShowArray(newArray);
// Console.WriteLine($"Строка с наименьшей суммой чисел -> {FindMinAmount(newArray)}");
// // Console.WriteLine($"Строка с наименьшей суммой чисел -> {FindRowsAmount(array)}");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4    a11 a12 | b11 b12
// 3 2 | 3 3    a21 a22 | b21 b22
// Результирующая матрица будет:
// 18 20
// 15 18
// c11 = a11 · b11 + a12 · b21 = 2 · 3 + 4 · 3 = 6 + 12 = 18
// c12 = a11 · b12 + a12 · b22 = 2 · 4 + 4 · 3 = 8 + 12 = 20
// c21 = a21 · b11 + a22 · b21 = 3 · 3 + 2 · 3 = 9 + 6 = 15
// c22 = a21 · b12 + a22 · b22 = 3 · 4 + 2 · 3 = 12 + 6 = 18
// newArray[0, 0] = firstArray[0, 0] * secondArray[0, 0] + firstArray[0, 1] * secondArray[1, 0]
// newArray[0, 1] = firstArray[0, 0] * secondArray[0, 1] + firstArray[0, 1] * secondArray[1, 1]
// newArray[1, 0] = firstArray[1, 0] * secondArray[0, 0] + firstArray[1, 1] * secondArray[1, 0]
// newArray[1, 1] = firstArray[1, 0] * secondArray[0, 1] + firstArray[1, 1] * secondArray[1, 1]

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

// int[,] FindArrayMultiply(int[,] array1, int[,] array2)
// {
//   int temp = 0;
//   int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
//   for (int i = 0; i < array1.GetLength(0); i++)
//   {
//     for (int j = 0; j < array2.GetLength(1); j++)
//     {
//       temp = 0;
//       for (int k = 0; k < array1.GetLength(1); k++)
//       {
//         temp += array1[i, k] * array2[k, j];
//       }
//       newArray[i, j] = temp;
//     }
//   }
//   return newArray;
// }

// Console.WriteLine("Введите количество строк массива 1: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива 1: ");
// int colums1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк массива 2: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива 2: ");
// int colums2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число массивов: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число массивов: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] firstArray = Create2DRandomArray(rows1, colums2, minValue, maxValue);
// int[,] secondArray = Create2DRandomArray(rows2, colums2, minValue, maxValue);
// Show2DArray(firstArray);
// Show2DArray(secondArray);
// if (colums1 != rows2)
// {
//   Console.WriteLine("Умножение матриц невозможно");
// }
// else
// {
//   Console.WriteLine("Произведение матриц будет следующим:");
//   Show2DArray(FindArrayMultiply(firstArray, secondArray));
// }



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Create3DTwoDigitsArray(int rows, int colums, int deep)
{
  int[,,] newArray = new int[rows, colums, deep];
  for (int i = 0; i < newArray.GetLength(0); i++)
  {
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
      for (int k = 0; k < newArray.GetLength(2); k++)
      {
         newArray[i, j, k] = new Random().Next(10, 100);
      }
    }
  }
  return newArray;
}

void Show2DArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
      Console.Write($"{array[i, j, k]}{(i,j,k)} ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}
 Console.WriteLine("Введите количество строк массива: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int j = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество граней массива: ");
int k = Convert.ToInt32(Console.ReadLine());

int[,,] array = Create3DTwoDigitsArray(i, j, k);
Show2DArray(array);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04    [0,0] [0,1] [0,2]
// 12 13 14 05    [1,0] [1,1] [1,2]
// 11 16 15 06    [2,0] [2,1] [2,2]
// 10 09 08 07