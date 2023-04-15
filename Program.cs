// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Ведите трехзначное число");
int number = int.Parse(Console.ReadLine());
if (number < 100 || number > 999) {Console.WriteLine("Число не трехзначное");  return;}
int number1 = (number / 10) % 10;
Console.WriteLine("Вторая цифра введенного числа - " + number1);