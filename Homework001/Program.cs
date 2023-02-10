// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//   Console.WriteLine($"max = {num1}");
//   Console.Write($"min = {num2}");
// }
// else if (num1 == num2)
// {
//   Console.WriteLine("Введите два разных числа");
// }
// else
// {
//   Console.WriteLine($"max = {num2}");
//   Console.Write($"min = {num1}");
// }




// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2 && num1 > num3)
// {
//   Console.WriteLine($"max = {num1}");
// }
// else if (num1 == num2 && num2 == num3)
// {
//   Console.WriteLine("Введите разные числа");
// }
// else if (num2 > num1 && num2 > num3)
// {
//   Console.WriteLine($"max = {num2}");
// }
// else
// {
//   Console.WriteLine($"max = {num3}");
// }




// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int current = num1 % 2;

// if (current == 1) {
//   Console.WriteLine("Нечетное");
// }
// else {
//   Console.WriteLine("Четное");
// }






// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int current = 2;

if (num1 <= 1)
{
  Console.Write("Введите положительное число, отличное от 0 и 1");
}
else
{
  while (current <= num1)
  {
    Console.Write($"{current} ");
    current += 2;
  }
}



