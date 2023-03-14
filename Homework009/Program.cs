// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers(int n)
// {
//   if (n >= 1)
//   {

//     Console.Write(n + " ");
//     ShowNumbers(n - 1);
//   }
// }

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int FindSumm(int m, int n)
{
  if (m != n)
  {
  if (m > n) return FindSumm(m-1, n) + m;
  else
    return FindSumm(m, n-1) + n;
  }
  else return m;
}

Console.WriteLine("Введите 1 число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindSumm(m, n));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int FindAkkerman(int m, int n)
// {
//   if (m == 0) return n + 1;
//   if (n == 0) return FindAkkerman(m - 1, 1);
//   else return FindAkkerman(m - 1, FindAkkerman(m, n - 1));
// }

// Console.WriteLine("Введите 1 число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2 число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindAkkerman(m, n));