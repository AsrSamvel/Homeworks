// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Answer (int number)
// {
//   if (number > 9999 && number < 100000)
//   {
//     int ed = number % 10;
//     int dec = (number % 100 - ed) / 10;
//     int ts = (number / 1000) % 10;
//     int dts = number / 10000;
//     if (ed == dts && dec == ts)
//     {
//       Console.WriteLine("Число является палиндромом");
//     }
//     else {
//     Console.WriteLine("Число не является палиндромом");
//     }
//   }
//   else{
//   Console.WriteLine("Посчитай сколько цифр ты ввел");
//   }
// }

// Console.WriteLine("Введите 5ти значное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Answer(number);


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Rast (double xA, double xB, double yA, double yB, double zA, double zB)
// {
//   return Math.Round(Math.Sqrt(Math.Pow(xB - xA,2) + Math.Pow(yB - yA,2) + Math.Pow(zB - zA,2)),2);
// }
// Console.WriteLine("Введите хA:");
// double xA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите хB:");
// double xB = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите yA:");
// double yA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите yB:");
// double yB = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите zA:");
// double zA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите zB:");
// double zB = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine(Rast(xA, xB, yA, yB, zA, zB));

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube (int num)
{
  int N = 0;
  while (N <= num)
  {
    Console.WriteLine(N*N*N);
    N++;
  }
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);