// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("input number");
int num1 = Convert.ToInt32(Console.ReadLine());
int first = num1/10;
int second = first%10;
Console.WriteLine(second);
