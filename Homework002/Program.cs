// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int Prompt (string message)
// {
//   System.Console.Write(message);
//   string value = Console.ReadLine();
//   int result = Convert.ToInt32(value);
//   return result;
// }

// int number = Prompt ("Введите 3х значное число ");
// if (number < 100 || number >= 1000)
// {
//   Console.WriteLine("Ошибка");
//   return;
// }

// Console.WriteLine($"Введенное число {number}");
// int secondRank = number / 10%10;
// Console.WriteLine($"Вторая цифра {secondRank}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int Prompt (string message)
// {
//   Console.Write(message);
//   string value = Console.ReadLine();
//   int result = Convert.ToInt32(value);
//   return result;
// }

// int GetThirdRank(int number)
// {
//   while (number > 999)
//   {
//     number /= 10;
//   }
//   return number % 10;
// }

// bool ValidateNumber(int number)
// {
//   while (number < 100)
//   {
//     Console.Write("Ошибка");
//     return false;
//   }
//   return true;
// }

// int number = Prompt("Введите число >");
// if (ValidateNumber(number))
// {
//   Console.WriteLine(GetThirdRank(number));
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// int Prompt (string message)
// {
//   Console.Write(message);
//   string value = Console.ReadLine();
//   int result = Convert.ToInt32(value);
//   return result;
// }

// bool IsWeekend (int WeekDay)
// {
//   if (WeekDay > 5)
//   {
//     return true;
//   }
//   return false;
// }

// bool  ValidateWeekday(int number)
// {
//   if (number > 0 && number <= 7)
//   {
//     return true;
//   }
//   Console.WriteLine("Ошибка");
//   return false;
// }

// int WeekDay = Prompt("Введите день недели");
// if (ValidateWeekday(WeekDay))
// {
//   if (IsWeekend(WeekDay))
//   {
//     Console.WriteLine("Выходной");
//   }
//   else  
//   {
//     Console.WriteLine("Будний день");
//   }
// }