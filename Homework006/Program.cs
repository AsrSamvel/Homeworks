// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// double Kolvo(double[] array, double size)
// {
//   double freq = 0;
//   double[] myArray = new double[size];
//   for (double i = 0; i < myArray.Length; i++)
//   {
//     if (array[i] > 0) freq++;
//   }
//   return freq;
// }

// void PrintArray (double size)
// {
// double[] cifri = new double[size];
// for (double i = 0; i < cifri.Length; i++)
// {
//   Console.Write($"Введите {i+1}ое число: ");
//   cifri[i] = Convert.ToDouble(Console.ReadLine());
//   Console.WriteLine();
// }
// if (Kolvo(cifri, size) == 0) Console.WriteLine("У вас не удалось ввести цифры больше чем ноль");
// if (Kolvo(cifri, size) == 1) Console.WriteLine($"Вы ввели {Kolvo(cifri, size)} число больше чем ноль");
// if (Kolvo(cifri, size) == 2 || Kolvo(cifri, size) == 3 || Kolvo(cifri, size) == 4) 
// Console.WriteLine($"Вы ввели {Kolvo(cifri, size)} числа больше чем ноль");
// if ((Kolvo(cifri, size) > 4)) Console.WriteLine($"Вы ввели {Kolvo(cifri, size)} чисел больше чем ноль");
// }

// Console.WriteLine("Какое количество цифр будет?");
// double size = Convert.ToDouble(Console.ReadLine());
// PrintArray(size);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint (double k1, double b1, double k2, double b2)
{
  double x = (b2-b1) / (k1 - k2);
  double y = k1 * x + b1;
  Console.WriteLine($"Точкой пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 является точка ({x}; {y})");
}

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
IntersectionPoint(k1,b1,k2,b2);